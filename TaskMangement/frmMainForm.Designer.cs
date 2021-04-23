namespace TaskMangement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SplitVar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.problemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPeriod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.periodicallyUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicallyUpdateHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMilestone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.milestoneCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milestoneHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnCompleteTicket = new System.Windows.Forms.Button();
            this.btnPeriodicallyUpdate = new System.Windows.Forms.Button();
            this.btnTaskAssign = new System.Windows.Forms.Button();
            this.btnLogEntry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.SplitVar.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuPeriod.SuspendLayout();
            this.contextMenuMilestone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnCheck);
            this.MenuVertical.Controls.Add(this.btnSetup);
            this.MenuVertical.Controls.Add(this.btnCompleteTicket);
            this.MenuVertical.Controls.Add(this.btnPeriodicallyUpdate);
            this.MenuVertical.Controls.Add(this.btnTaskAssign);
            this.MenuVertical.Controls.Add(this.btnLogEntry);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 611);
            this.MenuVertical.TabIndex = 0;
            // 
            // SplitVar
            // 
            this.SplitVar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SplitVar.Controls.Add(this.btnLogOut);
            this.SplitVar.Controls.Add(this.iconMinimize);
            this.SplitVar.Controls.Add(this.iconRestore);
            this.SplitVar.Controls.Add(this.iconMaximize);
            this.SplitVar.Controls.Add(this.iconClose);
            this.SplitVar.Controls.Add(this.btnSlide);
            this.SplitVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitVar.Location = new System.Drawing.Point(250, 0);
            this.SplitVar.Name = "SplitVar";
            this.SplitVar.Size = new System.Drawing.Size(1034, 70);
            this.SplitVar.TabIndex = 1;
            this.SplitVar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitVar_MouseDown);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(939, 34);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 30);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContainer.Controls.Add(this.txtUserID);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(250, 70);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1034, 541);
            this.PanelContainer.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(351, 453);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemTypeToolStripMenuItem,
            this.solutionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 56);
            // 
            // problemTypeToolStripMenuItem
            // 
            this.problemTypeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.problemTypeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTypeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.problemTypeToolStripMenuItem.Name = "problemTypeToolStripMenuItem";
            this.problemTypeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.problemTypeToolStripMenuItem.Text = "Problem Type";
            this.problemTypeToolStripMenuItem.Click += new System.EventHandler(this.problemTypeToolStripMenuItem_Click);
            // 
            // solutionToolStripMenuItem
            // 
            this.solutionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.solutionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
            this.solutionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.solutionToolStripMenuItem.Text = "Solution";
            this.solutionToolStripMenuItem.Click += new System.EventHandler(this.solutionToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userCreateToolStripMenuItem,
            this.userPermissionToolStripMenuItem,
            this.formSetupToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(191, 82);
            // 
            // userCreateToolStripMenuItem
            // 
            this.userCreateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.userCreateToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCreateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userCreateToolStripMenuItem.Name = "userCreateToolStripMenuItem";
            this.userCreateToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.userCreateToolStripMenuItem.Text = "User Create";
            this.userCreateToolStripMenuItem.Click += new System.EventHandler(this.userCreateToolStripMenuItem_Click);
            // 
            // userPermissionToolStripMenuItem
            // 
            this.userPermissionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.userPermissionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPermissionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userPermissionToolStripMenuItem.Name = "userPermissionToolStripMenuItem";
            this.userPermissionToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.userPermissionToolStripMenuItem.Text = "User Permission";
            this.userPermissionToolStripMenuItem.Click += new System.EventHandler(this.userPermissionToolStripMenuItem_Click);
            // 
            // formSetupToolStripMenuItem
            // 
            this.formSetupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.formSetupToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.formSetupToolStripMenuItem.Name = "formSetupToolStripMenuItem";
            this.formSetupToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.formSetupToolStripMenuItem.Text = "Form Setup";
            this.formSetupToolStripMenuItem.Click += new System.EventHandler(this.formSetupToolStripMenuItem_Click);
            // 
            // contextMenuPeriod
            // 
            this.contextMenuPeriod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodicallyUpdateToolStripMenuItem,
            this.periodicallyUpdateHistoryToolStripMenuItem});
            this.contextMenuPeriod.Name = "contextMenuPeriod";
            this.contextMenuPeriod.Size = new System.Drawing.Size(283, 56);
            // 
            // periodicallyUpdateToolStripMenuItem
            // 
            this.periodicallyUpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.periodicallyUpdateToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodicallyUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.periodicallyUpdateToolStripMenuItem.Name = "periodicallyUpdateToolStripMenuItem";
            this.periodicallyUpdateToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.periodicallyUpdateToolStripMenuItem.Text = "Periodically Update";
            this.periodicallyUpdateToolStripMenuItem.Click += new System.EventHandler(this.periodicallyUpdateToolStripMenuItem_Click);
            // 
            // periodicallyUpdateHistoryToolStripMenuItem
            // 
            this.periodicallyUpdateHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.periodicallyUpdateHistoryToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodicallyUpdateHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.periodicallyUpdateHistoryToolStripMenuItem.Name = "periodicallyUpdateHistoryToolStripMenuItem";
            this.periodicallyUpdateHistoryToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.periodicallyUpdateHistoryToolStripMenuItem.Text = "Periodically Update History";
            this.periodicallyUpdateHistoryToolStripMenuItem.Click += new System.EventHandler(this.periodicallyUpdateHistoryToolStripMenuItem_Click);
            // 
            // contextMenuMilestone
            // 
            this.contextMenuMilestone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.milestoneCreateToolStripMenuItem,
            this.milestoneHistoryToolStripMenuItem,
            this.simpleToolStripMenuItem});
            this.contextMenuMilestone.Name = "contextMenuMilestone";
            this.contextMenuMilestone.Size = new System.Drawing.Size(212, 82);
            // 
            // milestoneCreateToolStripMenuItem
            // 
            this.milestoneCreateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.milestoneCreateToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milestoneCreateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.milestoneCreateToolStripMenuItem.Name = "milestoneCreateToolStripMenuItem";
            this.milestoneCreateToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.milestoneCreateToolStripMenuItem.Text = "Milestone Create";
            this.milestoneCreateToolStripMenuItem.Click += new System.EventHandler(this.milestoneCreateToolStripMenuItem_Click);
            // 
            // milestoneHistoryToolStripMenuItem
            // 
            this.milestoneHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.milestoneHistoryToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milestoneHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.milestoneHistoryToolStripMenuItem.Name = "milestoneHistoryToolStripMenuItem";
            this.milestoneHistoryToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.milestoneHistoryToolStripMenuItem.Text = "Milestone History";
            this.milestoneHistoryToolStripMenuItem.Click += new System.EventHandler(this.milestoneHistoryToolStripMenuItem_Click);
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(959, 6);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(20, 20);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconRestore
            // 
            this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestore.Image = ((System.Drawing.Image)(resources.GetObject("iconRestore.Image")));
            this.iconRestore.Location = new System.Drawing.Point(985, 6);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(20, 20);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestore.TabIndex = 3;
            this.iconRestore.TabStop = false;
            this.iconRestore.Visible = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximize.Image")));
            this.iconMaximize.Location = new System.Drawing.Point(985, 6);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(20, 20);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximize.TabIndex = 2;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1011, 6);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(20, 20);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 1;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(4, 6);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(-2, 314);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(250, 40);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Admisnistrative";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ForeColor = System.Drawing.Color.White;
            this.btnSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetup.Image")));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(-1, 268);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(250, 40);
            this.btnSetup.TabIndex = 5;
            this.btnSetup.Text = "Setup Form";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnCompleteTicket
            // 
            this.btnCompleteTicket.FlatAppearance.BorderSize = 0;
            this.btnCompleteTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTicket.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnCompleteTicket.Image")));
            this.btnCompleteTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleteTicket.Location = new System.Drawing.Point(-1, 222);
            this.btnCompleteTicket.Name = "btnCompleteTicket";
            this.btnCompleteTicket.Size = new System.Drawing.Size(250, 40);
            this.btnCompleteTicket.TabIndex = 3;
            this.btnCompleteTicket.Text = "Completed Ticket";
            this.btnCompleteTicket.UseVisualStyleBackColor = true;
            this.btnCompleteTicket.Click += new System.EventHandler(this.btnCompleteTicket_Click);
            // 
            // btnPeriodicallyUpdate
            // 
            this.btnPeriodicallyUpdate.FlatAppearance.BorderSize = 0;
            this.btnPeriodicallyUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPeriodicallyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodicallyUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodicallyUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPeriodicallyUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnPeriodicallyUpdate.Image")));
            this.btnPeriodicallyUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeriodicallyUpdate.Location = new System.Drawing.Point(-1, 176);
            this.btnPeriodicallyUpdate.Name = "btnPeriodicallyUpdate";
            this.btnPeriodicallyUpdate.Size = new System.Drawing.Size(250, 40);
            this.btnPeriodicallyUpdate.TabIndex = 2;
            this.btnPeriodicallyUpdate.Text = "Periodically Update";
            this.btnPeriodicallyUpdate.UseVisualStyleBackColor = true;
            this.btnPeriodicallyUpdate.Click += new System.EventHandler(this.btnPeriodicallyUpdate_Click);
            // 
            // btnTaskAssign
            // 
            this.btnTaskAssign.FlatAppearance.BorderSize = 0;
            this.btnTaskAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTaskAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskAssign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskAssign.ForeColor = System.Drawing.Color.White;
            this.btnTaskAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskAssign.Image")));
            this.btnTaskAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskAssign.Location = new System.Drawing.Point(-1, 130);
            this.btnTaskAssign.Name = "btnTaskAssign";
            this.btnTaskAssign.Size = new System.Drawing.Size(250, 40);
            this.btnTaskAssign.TabIndex = 1;
            this.btnTaskAssign.Text = "Task Assign";
            this.btnTaskAssign.UseVisualStyleBackColor = true;
            this.btnTaskAssign.Click += new System.EventHandler(this.btnTaskAssign_Click);
            // 
            // btnLogEntry
            // 
            this.btnLogEntry.FlatAppearance.BorderSize = 0;
            this.btnLogEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogEntry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEntry.ForeColor = System.Drawing.Color.White;
            this.btnLogEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnLogEntry.Image")));
            this.btnLogEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogEntry.Location = new System.Drawing.Point(-1, 84);
            this.btnLogEntry.Name = "btnLogEntry";
            this.btnLogEntry.Size = new System.Drawing.Size(250, 40);
            this.btnLogEntry.TabIndex = 0;
            this.btnLogEntry.Text = "Log Entry";
            this.btnLogEntry.UseVisualStyleBackColor = true;
            this.btnLogEntry.Click += new System.EventHandler(this.btnLogEntry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.SplitVar);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuVertical.ResumeLayout(false);
            this.SplitVar.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuPeriod.ResumeLayout(false);
            this.contextMenuMilestone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SplitVar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Button btnLogEntry;
        private System.Windows.Forms.Button btnPeriodicallyUpdate;
        private System.Windows.Forms.Button btnTaskAssign;
        private System.Windows.Forms.Button btnCompleteTicket;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem problemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionToolStripMenuItem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem userCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPermissionToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ToolStripMenuItem formSetupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuPeriod;
        private System.Windows.Forms.ToolStripMenuItem periodicallyUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicallyUpdateHistoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMilestone;
        private System.Windows.Forms.ToolStripMenuItem milestoneCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milestoneHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
    }
}

