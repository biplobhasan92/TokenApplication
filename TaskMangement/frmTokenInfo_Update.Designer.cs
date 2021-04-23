namespace TaskMangement
{
    partial class frmTokenInfo_Update
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
            this.comItemGroup = new System.Windows.Forms.ComboBox();
            this.txtTokenNo = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgItemInfo = new System.Windows.Forms.DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitem_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitQnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSellDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comItemGroup
            // 
            this.comItemGroup.FormattingEnabled = true;
            this.comItemGroup.Location = new System.Drawing.Point(150, 281);
            this.comItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comItemGroup.Name = "comItemGroup";
            this.comItemGroup.Size = new System.Drawing.Size(201, 24);
            this.comItemGroup.TabIndex = 7;
            this.comItemGroup.SelectedIndexChanged += new System.EventHandler(this.comItemGroup_SelectedIndexChanged);
            // 
            // txtTokenNo
            // 
            this.txtTokenNo.Location = new System.Drawing.Point(150, 89);
            this.txtTokenNo.Name = "txtTokenNo";
            this.txtTokenNo.Size = new System.Drawing.Size(201, 22);
            this.txtTokenNo.TabIndex = 0;
            this.txtTokenNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTokenNo_KeyDown);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(150, 254);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(201, 22);
            this.txtComment.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Token No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "Comments";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(150, 226);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(201, 22);
            this.txtSection.TabIndex = 5;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(150, 198);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(201, 22);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(150, 171);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(201, 22);
            this.txtDepartment.TabIndex = 3;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(150, 143);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(201, 22);
            this.txtEmpName.TabIndex = 2;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(150, 116);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(201, 22);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 98;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 97;
            this.label5.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Token Update Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgItemInfo);
            this.panel1.Location = new System.Drawing.Point(380, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 269);
            this.panel1.TabIndex = 111;
            // 
            // dgItemInfo
            // 
            this.dgItemInfo.AllowUserToAddRows = false;
            this.dgItemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colitem_name,
            this.colunit_price,
            this.txtUnitQnty});
            this.dgItemInfo.Location = new System.Drawing.Point(3, 3);
            this.dgItemInfo.Name = "dgItemInfo";
            this.dgItemInfo.RowTemplate.Height = 24;
            this.dgItemInfo.Size = new System.Drawing.Size(550, 263);
            this.dgItemInfo.TabIndex = 0;
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "ID";
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colitem_name
            // 
            this.colitem_name.HeaderText = "Item Name";
            this.colitem_name.Name = "colitem_name";
            this.colitem_name.ReadOnly = true;
            this.colitem_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colitem_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colunit_price
            // 
            this.colunit_price.HeaderText = "Unit Price";
            this.colunit_price.Name = "colunit_price";
            this.colunit_price.ReadOnly = true;
            this.colunit_price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunit_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtUnitQnty
            // 
            this.txtUnitQnty.HeaderText = "Quantity";
            this.txtUnitQnty.Name = "txtUnitQnty";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(678, 347);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(573, 347);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSellDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(28, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 275);
            this.panel2.TabIndex = 115;
            // 
            // txtSellDate
            // 
            this.txtSellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSellDate.Location = new System.Drawing.Point(122, 6);
            this.txtSellDate.Name = "txtSellDate";
            this.txtSellDate.Size = new System.Drawing.Size(200, 22);
            this.txtSellDate.TabIndex = 116;
            this.txtSellDate.Value = new System.DateTime(2020, 6, 5, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 117;
            this.label10.Text = "Sell Date";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(783, 347);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 37);
            this.btnClear.TabIndex = 116;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Location = new System.Drawing.Point(71, 347);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(201, 22);
            this.txtUpdateUser.TabIndex = 117;
            // 
            // frmTokenInfo_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 417);
            this.Controls.Add(this.txtUpdateUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comItemGroup);
            this.Controls.Add(this.txtTokenNo);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmTokenInfo_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTokenInfo_Update_FormClosed);
            this.Load += new System.EventHandler(this.frmTokenInfo_Update_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comItemGroup;
        private System.Windows.Forms.TextBox txtTokenNo;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgItemInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitem_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnitQnty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtSellDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtUpdateUser;
    }
}