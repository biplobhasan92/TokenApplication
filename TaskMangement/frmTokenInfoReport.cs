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
    public partial class frmTokenInfoReport : Form
    {
        clsToken_ItemNameManager aclsToken_ItemNameManager = new clsToken_ItemNameManager();
        public frmTokenInfoReport()
        {
            InitializeComponent();
        }

        private void frmTokenInfoReport_Load(object sender, EventArgs e)
        {
            LoadGroupName();
            //txtSellDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.Owner.Enabled = false;
        }

        private void LoadGroupName()
        {
            comItemGroup.DataSource = aclsToken_ItemNameManager.GetGroupName();
            comItemGroup.DisplayMember = "group_name";
            comItemGroup.ValueMember = "id";
            comItemGroup.SelectedIndex = -1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (comItemGroup.Text == "")
            {
                comItemGroup.Focus();
                return;
            }
            else
            {
                if (rdoSummary.Checked == true)
                {
                    try
                    {
                        frmReportShow crpt = new frmReportShow();

                        ReportDocument CrystalReport = new ReportDocument();
                        CrystalReport.Load(Application.StartupPath + ("\\crptToken_Summary_Report.rpt")); /******** this work when report will remain debug folder *******/

                        OracleConnection con = new OracleConnection(DataManager.OraConnString());
                        string Condition = "";
                        if (comItemGroup.SelectedValue != null && txtStartDate.Text != "" && txtStartDate.Text != "")
                        {
                            Condition = " where TO_DATE(tn.selldate, 'dd/mm/yy') >= TO_DATE('" + txtStartDate.Text + "', 'dd/mm/yy') AND TO_DATE(tn.selldate, 'dd/mm/yy') <= TO_DATE('" + txtEndDate.Text + "', 'dd/mm/yy') AND tn.group_id='" + comItemGroup.SelectedValue + "'";
                        }
                        if (comItemGroup.SelectedValue != null && txtStartDate.Text != "" && txtStartDate.Text != "" && txtEmpID.Text != "")
                        {
                            Condition = " where TO_DATE(tn.selldate, 'dd/mm/yy') >= TO_DATE('" + txtStartDate.Text + "', 'dd/mm/yy') AND TO_DATE(tn.selldate, 'dd/mm/yy') <= TO_DATE('" + txtEndDate.Text + "', 'dd/mm/yy') AND tn.group_id='" + comItemGroup.SelectedValue + "' and tn.emp_id='" + txtEmpID.Text + "'";
                        }
                        string query = @"select * from erp.vw_prd_tokeninfo_summary tn " + Condition;
                        OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                        DataSet Ds = new DataSet();

                        // here my_dt is the name of the DataTable which we created in the designer view.
                        adapter.Fill(Ds, "vw_prd_tokeninfo_summary");  /************ Here use the name of SP or View or query table in TableName ************/

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

                if (rdoDetails.Checked == true)
                {
                    try
                    {
                        frmReportShow crpt = new frmReportShow();

                        ReportDocument CrystalReport = new ReportDocument();
                        CrystalReport.Load(Application.StartupPath + ("\\crptToken_Details_Report.rpt")); /******** this work when report will remain debug folder *******/

                        OracleConnection con = new OracleConnection(DataManager.OraConnString());
                        string Condition = "";
                        if (comItemGroup.SelectedValue != null && txtStartDate.Text != "" && txtStartDate.Text != "")
                        {
                            Condition = " where TO_DATE(tn.selldate, 'dd/mm/yy') >= TO_DATE('" + txtStartDate.Text + "', 'dd/mm/yy') AND TO_DATE(tn.selldate, 'dd/mm/yy') <= TO_DATE('" + txtEndDate.Text + "', 'dd/mm/yy') AND tn.group_id='" + comItemGroup.SelectedValue + "'";
                        }
                        if (comItemGroup.SelectedValue != null && txtStartDate.Text != "" && txtStartDate.Text != "" && txtEmpID.Text != "")
                        {
                            Condition = " where TO_DATE(tn.selldate, 'dd/mm/yy') >= TO_DATE('" + txtStartDate.Text + "', 'dd/mm/yy') AND TO_DATE(tn.selldate, 'dd/mm/yy') <= TO_DATE('" + txtEndDate.Text + "', 'dd/mm/yy') AND tn.group_id='" + comItemGroup.SelectedValue + "' and tn.emp_id='" + txtEmpID.Text + "'";
                        }
                        string query = @"select * from erp.vw_prd_tokeninfo_details tn " + Condition;
                        OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                        DataSet Ds = new DataSet();

                        // here my_dt is the name of the DataTable which we created in the designer view.
                        adapter.Fill(Ds, "vw_prd_tokeninfo_details");  /************ Here use the name of SP or View or query table in TableName ************/

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
            }
        }

        private void rdoSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSummary.Checked == true)
            {
                rdoDetails.Checked = false;
            }
        }

        private void rdoDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDetails.Checked == true)
            {
                rdoSummary.Checked = false;
            }
        }

        private void frmTokenInfoReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
