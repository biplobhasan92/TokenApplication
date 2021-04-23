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
    public partial class frmToken_Group : Form
    {
        clsToken_GroupManager aclsToken_GroupManager = new clsToken_GroupManager();
        public frmToken_Group()
        {
            InitializeComponent();
        }

        private void frmToken_Group_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            txtGroupName.Text = "";

            DataTable dt = aclsToken_GroupManager.GetGroupName();
            if (dt.Rows.Count > 0)
            {
                dgGroupHistory.DataSource = dt;
            }

            this.Owner.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsToken_Group aclsToken_Group = new clsToken_Group();
            aclsToken_Group.GroupName = txtGroupName.Text.Trim();

            aclsToken_GroupManager.SaveGroupName(aclsToken_Group);

            RefreshAll();
            MessageBox.Show("save data successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmToken_Group_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
