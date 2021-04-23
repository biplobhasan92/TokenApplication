using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMangement.App_Code;

namespace TaskMangement
{
    public partial class frmMainLayout : Form
    {
        clsPermissionCheckUserMain aclsPermissionCheckUserMain = new clsPermissionCheckUserMain();
        DataTable dtPermission = new DataTable();
        DataRow dr;
        private int childFormNumber = 0;

        public frmMainLayout()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
            //************************ upper code is used for active one page in a time *************************//
            //foreach (Form childForm in MdiChildren)
            //{
            //    childForm.Close();
            //}
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin ss = new frmLogin();
            ss.Show();
        }

        private void groupCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToken_Group f = new frmToken_Group();
            f.Owner = this;
            f.Show();
        }

        private void itemCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToken_ItemName f = new frmToken_ItemName();
            f.Owner = this;
            f.Show();
        }

        private void tokenSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /************** If needed permission compress then here add or remove id *************/
            //if (frmLogin.LogUserID == "012038" || frmLogin.LogUserID == "003002" || frmLogin.LogUserID == "009642" || frmLogin.LogUserID == "009641" || frmLogin.LogUserID == "009644" || frmLogin.LogUserID == "021086")
            //{
                frmTokenInfo ss = new frmTokenInfo();
                ss.Owner = this;
                ss.Show();
            //}
        }

        private void tokenRecordEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTokenInfo_Update ss = new frmTokenInfo_Update();
            ss.Owner = this;
            ss.Show();
        }

        private void rportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTokenInfoReport ss = new frmTokenInfoReport();
            ss.Owner = this;
            ss.Show();
        }
    }
}
