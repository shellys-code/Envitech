
using System;
using System.Windows.Forms;

namespace Envitech
{
    partial class FormMain
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
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelField = new System.Windows.Forms.Label();
            this.comboBoxField = new System.Windows.Forms.ComboBox();
            this.labelOperator = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(388, 46);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDateFrom.Size = new System.Drawing.Size(47, 13);
            this.labelDateFrom.TabIndex = 0;
            this.labelDateFrom.Text = "מתאריך";
            this.labelDateFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(151, 39);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            this.dateTimePickerFrom.Value = DateTimePicker.MinimumDateTime;

            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(378, 104);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDateTo.Size = new System.Drawing.Size(57, 13);
            this.labelDateTo.TabIndex = 2;
            this.labelDateTo.Text = "עד תאריך";
            this.labelDateTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(151, 104);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerTo.TabIndex = 3;
            this.dateTimePickerFrom.Value = DateTime.Now;
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Location = new System.Drawing.Point(402, 183);
            this.labelField.Name = "labelField";
            this.labelField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelField.Size = new System.Drawing.Size(30, 13);
            this.labelField.TabIndex = 4;
            this.labelField.Text = "שדה";
            this.labelField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxField
            // 
            this.comboBoxField.FormattingEnabled = true;
            this.comboBoxField.Location = new System.Drawing.Point(151, 175);
            this.comboBoxField.Name = "comboBoxField";
            this.comboBoxField.Size = new System.Drawing.Size(171, 21);
            this.comboBoxField.TabIndex = 5;

            // 
            // labelOperator
            // 
            this.labelOperator.AutoSize = true;
            this.labelOperator.Location = new System.Drawing.Point(384, 253);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelOperator.Size = new System.Drawing.Size(51, 13);
            this.labelOperator.TabIndex = 6;
            this.labelOperator.Text = "אופרטור";
            this.labelOperator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(151, 250);
            this.comboBoxOperator.Name = "comboBox2";
            this.comboBoxOperator.Size = new System.Drawing.Size(171, 21);
            this.comboBoxOperator.TabIndex = 7;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(405, 318);
            this.labelValue.Name = "labelValue";
            this.labelValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValue.Size = new System.Drawing.Size(27, 13);
            this.labelValue.TabIndex = 8;
            this.labelValue.Text = "ערך";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(151, 318);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(171, 20);
            this.numericUpDown.TabIndex = 9;
         
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(151, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "נקה טופס";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(290, 387);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 11;
            this.buttonReport.Text = "הצג";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.labelOperator);
            this.Controls.Add(this.comboBoxField);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelDateFrom);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.ComboBox comboBoxField;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button buttonReport;
    }
}

