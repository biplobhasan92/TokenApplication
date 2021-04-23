namespace TaskMangement
{
    partial class frmTokenInfoReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.comItemGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoSummary = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.txtStartDate);
            this.panel1.Controls.Add(this.comItemGroup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoDetails);
            this.panel1.Controls.Add(this.rdoSummary);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 244);
            this.panel1.TabIndex = 0;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Location = new System.Drawing.Point(103, 108);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(219, 22);
            this.txtEndDate.TabIndex = 122;
            this.txtEndDate.Value = new System.DateTime(2020, 5, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 121;
            this.label4.Text = "To Date";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(103, 164);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(219, 22);
            this.txtEmpID.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Emp ID";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(225, 193);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 37);
            this.btnPrint.TabIndex = 118;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Location = new System.Drawing.Point(103, 81);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(219, 22);
            this.txtStartDate.TabIndex = 117;
            this.txtStartDate.Value = new System.DateTime(2020, 5, 22, 0, 0, 0, 0);
            // 
            // comItemGroup
            // 
            this.comItemGroup.FormattingEnabled = true;
            this.comItemGroup.Location = new System.Drawing.Point(103, 135);
            this.comItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comItemGroup.Name = "comItemGroup";
            this.comItemGroup.Size = new System.Drawing.Size(220, 24);
            this.comItemGroup.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Form Date";
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Location = new System.Drawing.Point(230, 45);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(72, 21);
            this.rdoDetails.TabIndex = 20;
            this.rdoDetails.Text = "Details";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoDetails_CheckedChanged);
            // 
            // rdoSummary
            // 
            this.rdoSummary.AutoSize = true;
            this.rdoSummary.Checked = true;
            this.rdoSummary.Location = new System.Drawing.Point(136, 45);
            this.rdoSummary.Name = "rdoSummary";
            this.rdoSummary.Size = new System.Drawing.Size(88, 21);
            this.rdoSummary.TabIndex = 19;
            this.rdoSummary.TabStop = true;
            this.rdoSummary.Text = "Summary";
            this.rdoSummary.UseVisualStyleBackColor = true;
            this.rdoSummary.CheckedChanged += new System.EventHandler(this.rdoSummary_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Token Report";
            // 
            // frmTokenInfoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 292);
            this.Controls.Add(this.panel1);
            this.Name = "frmTokenInfoReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTokenInfoReport_FormClosed);
            this.Load += new System.EventHandler(this.frmTokenInfoReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comItemGroup;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label4;
    }
}