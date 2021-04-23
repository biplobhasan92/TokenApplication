using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMangement.App_Code;

namespace TaskMangement
{
    public partial class frmToken_ItemName : Form
    {
        clsToken_ItemNameManager aclsToken_ItemNameManager = new clsToken_ItemNameManager();
        public frmToken_ItemName()
        {
            InitializeComponent();
        }

        private void frmToken_ItemName_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            txtItemName.Text = txtUnitPrice.Text = "";
            txtItemID.Visible = false;
            btnUpdate.Visible = false;
            LoadGroupName();
            LoadUnitName();

            DataTable dt = aclsToken_ItemNameManager.GetItemHistory();
            dgItemHistory.DataSource = dt;

            txtItemName.Focus();

            this.Owner.Enabled = false;
        }

        private void LoadUnitName()
        {
            comMeasurementUnit.DataSource = aclsToken_ItemNameManager.GetMeasurementUnitName();
            comMeasurementUnit.DisplayMember = "unit_name";
            comMeasurementUnit.ValueMember = "id";
            comMeasurementUnit.SelectedIndex = -1;
        }

        private void LoadGroupName()
        {
            comItemGroup.DataSource = aclsToken_ItemNameManager.GetGroupName();
            comItemGroup.DisplayMember = "group_name";
            comItemGroup.ValueMember = "id";
            comItemGroup.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsToken_ItemName aclsToken_ItemName = new clsToken_ItemName();

            aclsToken_ItemName.ItemName = txtItemName.Text.Trim();
            aclsToken_ItemName.GroupID = comItemGroup.SelectedValue;
            aclsToken_ItemName.MeasureUnit = comMeasurementUnit.SelectedValue;
            aclsToken_ItemName.UnitPrice = txtUnitPrice.Text.Trim();

            aclsToken_ItemNameManager.SaveItemInfo(aclsToken_ItemName);
            RefreshAll();
            
            MessageBox.Show("Save Information successfully...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgItemHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt = aclsToken_ItemNameManager.GetSelectedItem(dgItemHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtItemID.Text = dr["id"].ToString();
                    txtItemName.Text = dr["item_name"].ToString();
                    txtUnitPrice.Text = dr["unit_price"].ToString();

                    comItemGroup.DataSource = aclsToken_ItemNameManager.GetGroupName();
                    comItemGroup.DisplayMember = "group_name";
                    comItemGroup.ValueMember = "id";
                    comItemGroup.SelectedIndex = -1;
                    comItemGroup.SelectedValue = dr["group_id"].ToString();

                    comMeasurementUnit.DataSource = aclsToken_ItemNameManager.GetMeasurementUnitName();
                    comMeasurementUnit.DisplayMember = "unit_name";
                    comMeasurementUnit.ValueMember = "id";
                    comMeasurementUnit.SelectedIndex = -1;
                    comMeasurementUnit.SelectedValue = dr["unit_id"].ToString();

                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                clsToken_ItemName aclsToken_ItemName = new clsToken_ItemName();

                aclsToken_ItemName.ItemID = txtItemID.Text.Trim();
                aclsToken_ItemName.ItemName = txtItemName.Text.Trim();
                aclsToken_ItemName.UnitPrice = txtUnitPrice.Text.Trim();

                aclsToken_ItemNameManager.UpdateItemInfo(aclsToken_ItemName);
                RefreshAll();

                MessageBox.Show("Update Information successfully...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (comItemGroup.SelectedValue != null)
            {
                try
                {
                    frmReportShow crpt = new frmReportShow();

                    ReportDocument CrystalReport = new ReportDocument();
                    CrystalReport.Load(Application.StartupPath + ("\\crptToken_ItemPriceList.rpt")); /******** this work when report will remain debug folder *******/

                    OracleConnection con = new OracleConnection(DataManager.OraConnString());
                    string Condition = "";
                    if (comItemGroup.SelectedValue != null)
                    {
                        Condition = " where tn.group_id='" + comItemGroup.SelectedValue + "'";
                    }
                    string query = @"select * from vw_prd_tokeninfo_item tn " + Condition;
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataSet Ds = new DataSet();

                    // here my_dt is the name of the DataTable which we created in the designer view.
                    adapter.Fill(Ds, "vw_prd_tokeninfo_item");  /************ Here use the name of SP or View or query table in TableName ************/

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    CrystalReport.SetDataSource(Ds);
                    crpt.crystalReportViewer1.ReportSource = CrystalReport;
                    crpt.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select Group frist...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmToken_ItemName_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
