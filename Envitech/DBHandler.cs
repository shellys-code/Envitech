using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Envitech
{
    public class DBHandler
    {
        private string m_ConnectionString = "";
        private SqlConnection m_Connection;       

        public DBHandler()
        {
            m_ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            m_Connection = new SqlConnection(m_ConnectionString);
        }

        public bool Open()
        {
            try
            {
                m_Connection.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            m_Connection.Close();
            //m_Connection.Dispose();
        }

        private SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, m_Connection);
                SqlDataReader reader = cmd.ExecuteReader();               
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {                             
                SqlCommand cmd = new SqlCommand(sql, m_Connection);
                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);                                          
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        public List<string> GetAllValues()
        {
            List<string> values = new List<string>();
            for (int i = 1; i <= 32; i++)
            {
                values.Add("Value" + i);
            }
            return values;
        }

        public SqlDataReader GetAllOperators()
        {
            string query = "SELECT distinct Name from [test].[dbo].[OPERATOR]";
            return ExecuteReader(query);
        }

        public SqlDataReader GetMinDate()
        {
            string query = "SELECT Min(Date_Time) 'Date_Time' from [test].[dbo].[DATA]";
            return ExecuteReader(query);
        }

        public DataTable GetReportTable(DateTime dateFrom, DateTime dateTo, string field,string operation, string val)
        {
            m_Connection.Open();
            Dictionary<int, string> statusNames = GetStatusName();
            Dictionary<int, bool> statusValidations = GetStatusValidation();
            string query = $@"SELECT * from [test].[dbo].[DATA] where {field}{operation}{val} and Date_Time between '{dateFrom.ToString("yyyy-MM-dd")}' and '{dateTo.ToString("yyyy-MM-dd")}'";
            DataTable dt =  GetDataTable(query);
            m_Connection.Close();

            DataTable table = new DataTable();
            table.Columns.Add("Time Stamp", typeof(string));
            for (int i = 1; i <= (dt.Columns.Count-1)/2; i++)
            {
                table.Columns.Add("Value" + i, typeof(string));
            }
            if (dt == null)
                return table;

            // calculate value - in case the value is not valid the status will be displayed
            foreach (DataRow row in dt.Rows)
            {
                List<string> list = new List<string>();
                list.Add(((DateTime)row["Date_Time"]).ToString("yyyy-MM-dd HH:mm:ss.fff"));
                for (int i = 1; i <= (dt.Columns.Count - 1) / 2; i++)
                {
                    string value  = row["Value" + i].ToString();
                    int  status = int.Parse(row["Status" + i].ToString());
                    if (!statusValidations[status])
                    {
                        value = statusNames[status];
                    }
                    list.Add(value);
                }

                table.Rows.Add(list.ToArray<string>());
            }
            return table;
        }

        public Dictionary<int, string> GetStatusName()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            string query = @"SELECT Id, Name from [test].[dbo].[STATUS]";
            DataTable dt = GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                dict.Add(int.Parse(row["Id"].ToString()), row["Name"].ToString());
            }

            return dict;
        }

        public Dictionary<int, bool> GetStatusValidation()
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            string query = @"SELECT Id, Valid from [test].[dbo].[STATUS]";
            DataTable dt = GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                dict.Add(int.Parse(row["Id"].ToString()), Convert.ToBoolean(row["Valid"]));
            }

            return dict;
        }
    }
}
