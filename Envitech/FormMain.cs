using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envitech
{
    public partial class FormMain : Form
    {

        DBHandler dbHandler = new DBHandler();

        public FormMain()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            setDataTimePicker();
            setDataComboBox();
        }

        private void setDataTimePicker()
        {           
            dbHandler.Open();
            SqlDataReader row = dbHandler.GetMinDate();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    this.dateTimePicker1.Value = (DateTime)row["Date_Time"];
                }
            }
            dbHandler.Close();
        }

        private void setDataComboBox()
        {
            var values = dbHandler.GetAllValues();
            foreach (var value in values)
            {
                comboBox1.Items.Add(value);
            }
            comboBox1.SelectedIndex = 1;

            dbHandler.Open();
            SqlDataReader row = dbHandler.GetAllOperators();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    comboBox2.Items.Add(row["name"].ToString());
                }
            }
            dbHandler.Close();
            comboBox2.SelectedIndex = 1;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormMain NewForm = new FormMain();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter(dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), numericUpDown.Value.ToString());
            var formReport = new FormReport(dbHandler, filter);
            formReport.Show();
        }

      
    }
}
