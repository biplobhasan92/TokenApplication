using Oracle.ManagedDataAccess.Client;
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
    public partial class frmLogin : Form
    {
        public static string LogUserID = "";
        public frmLogin()
        {
            InitializeComponent();
            txtUserID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtPassword.Text != "")
            {
                LogUserID = txtUserID.Text;
                string Connstring = DataManager.OraConnString();
                //string Connstring = "DATA SOURCE = Localhost:1521/orcl; PERSIST SECURITY INFO=True;USER ID=taskmanagement; password=taskmanagement; Pooling = False; ";

                OracleConnection myConnection = new OracleConnection(Connstring);
                //string query = "SELECT * FROM User_Login WHERE  (User_ID = '" + txtUserID.Text + "') AND (Password = '" + txtPassword.Text + "') ";
                string query = @"SELECT U.VEMPID, U.VUSERID,  U.VPASSWORD, U.NUSERLAVEL, H.VEMPNAME FROM ADN_USERINFORMATION  U,HRM_EMPLOYEE H WHERE U.VUSERID ='" + txtUserID.Text + "' AND U.VPASSWORD = '" + txtPassword.Text + "' AND U.VEMPID = H.VEMPLOYEEID";
                myConnection.Open();

                OracleCommand cmd = new OracleCommand(query, myConnection);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                myConnection.Close();
                if (dt.Rows.Count > 0)
                {
                    if (LogUserID == "012038" || LogUserID == "012022" || LogUserID == "003002" || LogUserID == "009642" || LogUserID == "009641" || LogUserID == "009644" || LogUserID == "021086")
                    {
                        /*************  Main code*************/
                        /************ Startup page set in program.cs file **************/
                        this.Hide();
                        //frmMain main = new frmMain();
                        //main.Show();
                        frmMainLayout f = new frmMainLayout();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("You have not enough permission!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Check your id and password");
                }
            }
            else
            {
                MessageBox.Show("Should type a valid user id and password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin.Focus();
            }            
        }
    }
}
