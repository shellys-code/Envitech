using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envitech
{
    public partial class FormReport : Form
    {
        DBHandler m_dbHandler;
        Filter m_fillter;

        public FormReport(DBHandler dbHandler, Filter fillter)
        {
            m_dbHandler = dbHandler;
            m_fillter = fillter;
            InitializeComponent();
            this.Load += new EventHandler(FormReport_Load);
        }

        private void FormReport_Load(System.Object sender, System.EventArgs e)
        {                      
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable dataTable = m_dbHandler.GetReportTable(m_fillter.DateFrom, m_fillter.DateTo, m_fillter.Field, m_fillter.Operation, m_fillter.Value);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            reportDataGridView.AutoGenerateColumns = true;
            reportDataGridView.Columns.Clear();
            reportDataGridView.DataSource = dataTable;
            reportDataGridView.DataSource = bindingSource;
            reportDataGridView.Refresh();

           
            // Resize the master DataGridView columns to fit the newly loaded data.
            reportDataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            //reportDataGridView.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.AllCells;

        }




    }
}
