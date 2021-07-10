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
                    this.dateTimePickerFrom.Value = (DateTime)row["Date_Time"];
                }
            }
            dbHandler.Close();
        }

        private void setDataComboBox()
        {
            var values = dbHandler.GetAllValues();
            foreach (var value in values)
            {
                comboBoxField.Items.Add(value);
            }
            comboBoxField.SelectedIndex = 0;

            dbHandler.Open();
            SqlDataReader row = dbHandler.GetAllOperators();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    comboBoxOperator.Items.Add(row["name"].ToString());
                }
            }
            dbHandler.Close();
            comboBoxOperator.SelectedIndex = 0;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormMain NewForm = new FormMain();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter(dateTimePickerFrom.Value, dateTimePickerTo.Value, comboBoxField.SelectedItem.ToString(), comboBoxOperator.SelectedItem.ToString(), numericUpDown.Value.ToString());
            var formReport = new FormReport(dbHandler, filter);
            formReport.Show();
        }

      
    }
}
