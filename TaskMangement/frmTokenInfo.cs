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
    public partial class frmTokenInfo : Form
    {
        clsTokenInfoManager aclsTokenInfoManager = new clsTokenInfoManager();
        public frmTokenInfo()
        {
            InitializeComponent();
        }

        private void FrmTokenIno_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            comGroup.DataSource = clsTokenInfoManager.GetGroupName();
            comGroup.DisplayMember = "group_name";
            comGroup.ValueMember = "id";
            comGroup.SelectedIndex = -1;

            txtEmpName.Text = txtEmployeeID.Text = txtDepartment.Text = txtDesignation.Text = txtSection.Text = txtTokenNo.Text = "";
            txtUserID.Text = frmLogin.LogUserID;
            //txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtUserID.Visible = false;
            this.Owner.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmployeeID.Text == "")
                {
                    txtEmployeeID.Focus();
                    return;
                }
                else if (txtTokenNo.Text == "")
                {
                    txtTokenNo.Focus();
                    return;
                }
                else if (comGroup.SelectedText == "Select")
                {
                    comGroup.Focus();
                    return;
                }
                else
                {
                    clsTokenInfo aclsTokenInfo = new clsTokenInfo();

                    aclsTokenInfo.TokenID = txtTokenNo.Text.Trim();
                    aclsTokenInfo.EmpID = txtEmployeeID.Text.Trim();
                    aclsTokenInfo.GroupID = comGroup.SelectedValue;
                    aclsTokenInfo.Comments = txtComment.Text.Trim();
                    aclsTokenInfo.UserID = txtUserID.Text.Trim();

                    aclsTokenInfoManager.SaveTokenInfo(aclsTokenInfo);

                    PrintReport(txtTokenNo.Text);
                    RefreshAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = aclsTokenInfoManager.GetEmployeeInformation(txtEmployeeID.Text);
                    if (dt.Rows.Count > 0)
                    {
                        txtEmpName.Text = dt.Rows[0]["vempname"].ToString();
                        txtDepartment.Text = dt.Rows[0]["vdepartmentname"].ToString();
                        txtDesignation.Text = dt.Rows[0]["vdesignationname"].ToString();
                        txtSection.Text = dt.Rows[0]["vunitname"].ToString();

                        /*********** This was used by user id and then increment in +1 value it's skip becuse of year+month+day+table max id ***********/
                        //DataTable dt1 = clsTokenInfoManager.GetMaxID(txtEmployeeID.Text);
                        //string ChkID = txtEmployeeID.Text + dt1.Rows[0]["serial"].ToString();

                        /******* year+month+day then should be add max id to generate token no ********/
                        string Serial = DataManager.GetNextID("prd.prd_tkn_mst", "id").ToString();
                        string ChkID = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + Serial;
                        //+ dt1.Rows[0]["serial"].ToString();

                        
                        txtTokenNo.Text = ChkID;

                        comGroup.Focus();
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

        private void PrintReport(string tknID)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                ReportDocument reportDocument = new ReportDocument();
                if (comGroup.Text == "Fish")
                {
                    reportDocument.Load(Application.StartupPath + "\\crptToken_Report.rpt");

                }
                else if(comGroup.Text == "Vegetables")
                {
                    reportDocument.Load(Application.StartupPath + "\\crptToken_Report_vegetables.rpt");
                }
                else if(comGroup.Text == "Milk & Meat")
                {
                    reportDocument.Load(Application.StartupPath + "\\crptToken_Report_Milk_Meat.rpt");
                }
                else if(comGroup.Text == "Clothes")
                {
                    reportDocument.Load(Application.StartupPath + "\\crptToken_Report_Clothes.rpt");
                }

                OracleConnection con = new OracleConnection(DataManager.OraConnString());

                string Condition = "";
                if (!string.IsNullOrEmpty(txtTokenNo.Text))
                {
                    Condition = " where tn.token_id='" + tknID + "'";
                }
                string query = @"select * from vw_prd_tokeninfo tn " + Condition;

                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataSet Ds = new DataSet();

                // here my_dt is the name of the DataTable which we created in the designer view.
                adapter.Fill(Ds, "vw_prd_tokeninfo");  /************ Here use the name of SP or View or query table in TableName ************/

                if (Ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Setting data source of our report object
                reportDocument.SetDataSource(Ds);

                reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void comGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (comGroup.Text == "")
                {
                    comGroup.Focus();
                    return;
                }
                if (txtDate.Text == "")
                {
                    txtDate.Focus();
                    return;
                }
                else
                {
                    frmReportShow crpt = new frmReportShow();

                    ReportDocument CrystalReport = new ReportDocument();
                    CrystalReport.Load(Application.StartupPath + ("\\crptTokenInfoList.rpt")); /******** this work when report will remain debug folder *******/

                    OracleConnection con = new OracleConnection(DataManager.OraConnString());
                    string Condition = "";
                    if (comGroup.SelectedValue != null && txtDate.Text != "")
                    {
                        Condition = " where TO_DATE(tn.add_date, 'dd/mm/yy') = TO_DATE('" + txtDate.Text + "', 'dd/mm/yy') AND tn.group_id='" + comGroup.SelectedValue + "'";
                    }
                    string query = @"select * from erp.vw_prd_tokeninfolist tn " + Condition;
                    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                    DataSet Ds = new DataSet();

                    // here my_dt is the name of the DataTable which we created in the designer view.
                    adapter.Fill(Ds, "vw_prd_tokeninfolist");  /************ Here use the name of SP or View or query table in TableName ************/

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    CrystalReport.SetDataSource(Ds);
                    crpt.crystalReportViewer1.ReportSource = CrystalReport;
                    crpt.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void frmTokenInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmReportShow crpt = new frmReportShow();

        //        ReportDocument CrystalReport = new ReportDocument();

        //        //CrystalReport.Load(@"E:\Jashim\Working\Task Application\TaskMangement\TaskMangement\Reports\rptMilestoneHistory.rpt"); /********** this work with local pc *********/
        //        CrystalReport.Load(Application.StartupPath + ("\\crptToken_Report.rpt")); /******** this work when report will remain debug folder *******/

        //        OracleConnection con = new OracleConnection(DataManager.OraConnString());

        //        string Condition = "";
        //        if (!string.IsNullOrEmpty(txtTokenNo.Text))
        //        {
        //            Condition = " where tn.token_id='" + txtTokenNo.Text + "'";
        //        }

        //        //string query = @"SELECT distinct tn.milestoneid,tn.ticketno as Ticket,tn.problemin,ul.user_name assign,tn.assigndate,tm.problemtype as type,le.problemoriginname as name,le.mechinetagno as tag,le.add_date as logdt FROM milestone_entry_mst tn inner join milestone_entry_dtls tm on tn.milestoneid=tm.milestoneid inner join log_entry le on le.ticketno=tn.ticketno inner join user_login ul on tn.assignperson=ul.user_id " + Condition;
        //        string query = @"select * from vw_prd_tokeninfo tn " + Condition;

        //        OracleDataAdapter adapter = new OracleDataAdapter(query, con);
        //        DataSet Ds = new DataSet();

        //        // here my_dt is the name of the DataTable which we created in the designer view.
        //        adapter.Fill(Ds, "vw_prd_tokeninfo");  /************ Here use the name of SP or View or query table in TableName ************/

        //        if (Ds.Tables[0].Rows.Count == 0)
        //        {
        //            MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //        // Setting data source of our report object
        //        CrystalReport.SetDataSource(Ds);

        //        crpt.crystalReportViewer1.ReportSource = CrystalReport;
        //        crpt.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("There is some problem to do the task. Try again properly.!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btnDirectPrint_Click(object sender, EventArgs e)
        //{
        //    PrintDialog printDialog = new PrintDialog();
        //    if (printDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        ReportDocument reportDocument = new ReportDocument();
        //        reportDocument.Load(Application.StartupPath + "\\crptToken_Report.rpt");

        //        OracleConnection con = new OracleConnection(DataManager.OraConnString());

        //        string Condition = "";
        //        if (!string.IsNullOrEmpty(txtTokenNo.Text))
        //        {
        //            Condition = " where tn.token_id='" + txtTokenNo.Text + "'";
        //        }
        //        string query = @"select * from vw_prd_tokeninfo tn " + Condition;

        //        OracleDataAdapter adapter = new OracleDataAdapter(query, con);
        //        DataSet Ds = new DataSet();

        //        // here my_dt is the name of the DataTable which we created in the designer view.
        //        adapter.Fill(Ds, "vw_prd_tokeninfo");  /************ Here use the name of SP or View or query table in TableName ************/

        //        if (Ds.Tables[0].Rows.Count == 0)
        //        {
        //            MessageBox.Show("There have no data with this related search!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //        // Setting data source of our report object
        //        reportDocument.SetDataSource(Ds);

        //        reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
        //        reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
        //    }
        //}
    }
}
        