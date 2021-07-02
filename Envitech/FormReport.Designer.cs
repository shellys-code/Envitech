
using System.Drawing;
using System.Windows.Forms;

namespace Envitech
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormReport";
            this.reportDataGridView = new DataGridView();           

            this.Controls.Add(reportDataGridView);
            
            reportDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            reportDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            reportDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(reportDataGridView.Font, FontStyle.Bold);

            reportDataGridView.Name = "reportDataGridView";
            reportDataGridView.Location = new Point(8, 8);
            reportDataGridView.Size = new Size(790, 440);
            reportDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            reportDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            reportDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            reportDataGridView.GridColor = Color.Black;
            reportDataGridView.RowHeadersVisible = false;
            reportDataGridView.AllowUserToAddRows = false;

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
  
    }
}