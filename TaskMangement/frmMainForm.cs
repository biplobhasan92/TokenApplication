using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMangement.App_Code;

namespace TaskMangement
{
    public partial class frmMain : Form
    {
        clsPermissionCheckUserMain aclsPermissionCheckUserMain = new clsPermissionCheckUserMain();
        DataTable dtPermission = new DataTable();
        DataRow dr;
        
        public frmMain()
        {
            InitializeComponent();
            txtUserID.Visible = false;            
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUserID.Text = frmLogin.LogUserID;
            DataTable dt = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
            if (dt.Rows.Count > 0)
            {
                dtPermission = dt;
                dr = dtPermission.Rows[0];
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCatpture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMaximize.Visible = false;
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Normal;
            iconRestore.Visible = false;
            iconMaximize.Visible = true;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SplitVar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainFormInPanel(object FormInfo)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);

            Form frm = FormInfo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(frm);
            this.PanelContainer.Tag = frm;
            frm.Show();
        }
        private void btnLogEntry_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[0];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmLogEntry")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmLogEntry());
                        //frmLogEntry fr = new frmLogEntry();
                        //fr.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaskAssign_Click(object sender, EventArgs e)
        {
             contextMenuMilestone.Show(btnTaskAssign, btnTaskAssign.Width, 1);
           // frmMilestoneCreate f = new frmMilestoneCreate();
           // f.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin ss = new frmLogin();
            ss.Show();
        }

        private void btnPeriodicallyUpdate_Click(object sender, EventArgs e)
        {
            contextMenuPeriod.Show(btnPeriodicallyUpdate, btnPeriodicallyUpdate.Width, 1);
        }

        private void btnCompleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[7];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmCompleteTicket")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmCompleteTicket());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnSetup, btnSetup.Width, 1);
        }

        private void problemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[3];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmProblemSetup")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmProblemSetup());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void solutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[4];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmSolutionSetup")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmSolutionSetup());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(btnCheck, btnCheck.Width, 1);

            //AbriarFormInPanel(new frmTransferTest());
        }

        private void userPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[6];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmUserPermission")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmUserPermission());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void userCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    dr = dtPermission.Rows[5];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmUserRegistration")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmUserRegistration());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    dr = dtPermission.Rows[8];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmNewFormSetup")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmNewFormSetup());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void periodicallyUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[2];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmPeriodicallyUpdate")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmPeriodicallyUpdate());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void periodicallyUpdateHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[9];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmPeriodicallyUpdateHistory")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmPeriodicallyUpdateHistory());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void milestoneCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[1];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmMilestoneCreate")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmMilestoneCreate());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void milestoneHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = aclsPermissionCheckUserMain.GetPermissionInfo(txtUserID.Text);
                if (dtPermission.Rows.Count > 0)
                {
                    DataRow dr = dtPermission.Rows[10];
                    if ((dr["form_name"].ToString() == Convert.ToString("frmMilestoneHistory")) && (dr["status"].ToString() == Convert.ToString("Yes")))
                    {
                        MainFormInPanel(new frmMilestoneHistory());
                    }
                    else
                    {
                        MessageBox.Show("You have not sufficcient permission..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Permission not create yet..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permission not sufficient for this page..!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFormInPanel(new frmTest());
        }
    }
}
