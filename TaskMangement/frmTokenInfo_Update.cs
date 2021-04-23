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
    public partial class frmTokenInfo_Update : Form
    {
        clsToken_ItemNameManager aclsToken_ItemNameManager = new clsToken_ItemNameManager();
        clsTokenInfo_UpdateManager aclsTokenInfo_UpdateManager = new clsTokenInfo_UpdateManager();
        public frmTokenInfo_Update()
        {
            InitializeComponent();

            txtTokenNo.Focus();
            txtSellDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmTokenInfo_Update_Load(object sender, EventArgs e)
        {
            RefreshAll();
            LoadGroupName();
        }

        private void RefreshAll()
        {            
            btnDelete.Visible = false;
            txtUpdateUser.Visible = false;

            txtTokenNo.Text = txtEmpName.Text = txtEmployeeID.Text = txtDepartment.Text = txtDesignation.Text = txtSection.Text = txtComment.Text = "";

            //DataTable dt = aclsTokenInfo_UpdateManager.GetSearchRelatedGrid(comItemGroup.SelectedValue);
            //dgItemInfo.DataSource = dt;
            dgItemInfo.Rows.Clear();
            txtUpdateUser.Text = frmLogin.LogUserID;
            this.Owner.Enabled = false;
        }

        private void LoadGroupName()
        {
            comItemGroup.DataSource = aclsToken_ItemNameManager.GetGroupName();
            comItemGroup.DisplayMember = "group_name";
            comItemGroup.ValueMember = "id";
            comItemGroup.SelectedIndex = -1;
        }

        private void txtTokenNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = aclsTokenInfo_UpdateManager.GetEmployeeInformation(txtTokenNo.Text);
                    if (dt.Rows.Count > 0)
                    {
                        txtEmpName.Text = dt.Rows[0]["vempname"].ToString();
                        txtDepartment.Text = dt.Rows[0]["vdepartmentname"].ToString();
                        txtDesignation.Text = dt.Rows[0]["vdesignationname"].ToString();
                        txtSection.Text = dt.Rows[0]["vunitname"].ToString();
                        txtEmployeeID.Text = dt.Rows[0]["emp_id"].ToString();
                        txtComment.Text = dt.Rows[0]["comments"].ToString();

                        //*************** This is checked If found ***************//
                        dgItemInfo.Rows.Clear();
                        DataTable dt2 = aclsTokenInfo_UpdateManager.GetTokenRelatedGrid(txtTokenNo.Text);
                        if (dt2.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt2.Rows)
                            {
                                string UnitQnty = Convert.ToString(dr["itemqty"]);
                                if (UnitQnty != "")
                                {
                                    dgItemInfo.Rows.Add();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colItemID.Index].Value = dr["id"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colitem_name.Index].Value = dr["item_name"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colunit_price.Index].Value = dr["unit_price"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[txtUnitQnty.Index].Value = dr["itemqty"].ToString();
                                }
                            }

                            //comItemGroup.DataSource = aclsToken_ItemNameManager.GetGroupName();
                            //comItemGroup.DisplayMember = "group_name";
                            //comItemGroup.ValueMember = "id";
                            //comItemGroup.SelectedIndex = -1;
                            //comItemGroup.SelectedValue= dt2.Rows[0]["group_id"].ToString();

                            //dgItemInfo.DataSource = dt;
                            btnDelete.Visible = true;
                        }
                        else
                        {
                            comItemGroup.SelectedValue = dt.Rows[0]["group_id"].ToString();
                            dgItemInfo.Rows.Clear();
                            DataTable dt3 = aclsTokenInfo_UpdateManager.GetSearchRelatedGrid(comItemGroup.SelectedValue);
                            if (dt3.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt3.Rows)
                                {
                                    dgItemInfo.Rows.Add();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colItemID.Index].Value = dr["id"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colitem_name.Index].Value = dr["item_name"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colunit_price.Index].Value = dr["unit_price"].ToString();
                                    dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[txtUnitQnty.Index].Value = "";
                                }

                                //dgItemInfo.DataSource = dt;
                            }
                        }
                        //btnSave.Focus();
                    }
                    else
                    {
                        MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgItemInfo.Rows.Clear();
                DataTable dt = aclsTokenInfo_UpdateManager.GetSearchRelatedGrid(comItemGroup.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgItemInfo.Rows.Add();
                        dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colItemID.Index].Value = dr["id"].ToString();
                        dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colitem_name.Index].Value = dr["item_name"].ToString();
                        dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[colunit_price.Index].Value = dr["unit_price"].ToString();
                        dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[txtUnitQnty.Index].Value = "";
                    }

                    //dgItemInfo.DataSource = dt;
                }
                else
                {
                    dgItemInfo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTokenInfo_Update aclsTokenInfo_Update = new clsTokenInfo_Update();
            List<clsTokenInfo_Update> UnitPriceList = new List<clsTokenInfo_Update>();
            aclsTokenInfo_Update.TokenNo = txtTokenNo.Text.Trim();
            aclsTokenInfo_Update.GroupID = comItemGroup.SelectedValue;
            aclsTokenInfo_Update.SellDate = txtSellDate.Text.Trim();
            aclsTokenInfo_Update.UpdateUser = txtUpdateUser.Text.Trim();
            string UnitQntyss = Convert.ToString(dgItemInfo.Rows[dgItemInfo.Rows.Count - 1].Cells[txtUnitQnty.Index].Value);


            if (dgItemInfo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgItemInfo.Rows)
                {
                    string UnitQnty = Convert.ToString(row.Cells[3].Value);
                    if (UnitQnty != "")
                    {
                        clsTokenInfo_Update aclsTokenInfo_UpdateList = new clsTokenInfo_Update();

                        string ItemID = Convert.ToString(row.Cells[0].Value);
                        string ItemName = Convert.ToString(row.Cells[1].Value);
                        string ItemPrice = Convert.ToString(row.Cells[2].Value);
                        UnitQnty = Convert.ToString(row.Cells[3].Value);

                        aclsTokenInfo_UpdateList.ItemsID = ItemID;
                        aclsTokenInfo_UpdateList.Name = ItemName;
                        aclsTokenInfo_UpdateList.Price = ItemPrice;
                        aclsTokenInfo_UpdateList.QntUnit = UnitQnty;

                        UnitPriceList.Add(aclsTokenInfo_UpdateList);
                    }                    
                }
            }
            if (UnitQntyss != "")
            {
                aclsTokenInfo_UpdateManager.SaveSellInfo(aclsTokenInfo_Update, UnitPriceList);

                RefreshAll();

                MessageBox.Show("save data successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsTokenInfo_Update aclsTokenInfo_Update = new clsTokenInfo_Update();
            aclsTokenInfo_Update.TokenNo = txtTokenNo.Text.Trim();

            aclsTokenInfo_UpdateManager.DeleteRecord(aclsTokenInfo_Update);

            RefreshAll();

            MessageBox.Show("delete data successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void frmTokenInfo_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
