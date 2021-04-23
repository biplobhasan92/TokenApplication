using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsNewFormSetupManager
    {
        string connectionString = DataManager.OraConnString();
        OracleConnection con = new OracleConnection(DataManager.OraConnString());
        internal DataTable GetAllForm()
        {
            string select = @"select id,formname,formdescription from user_form_name";

            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_form_name");
            return dt;
        }

        internal void SaveFormInfo(clsNewFormSetup aclsNewFormSetup)
        {
            string query = @"INSERT INTO user_form_name (id,formname,formdescription)
        VALUES ((SELECT max(nvl(id,0))+1 FROM user_form_name),'" + aclsNewFormSetup.FormName + "','" + aclsNewFormSetup.FormDescription + "')";

            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal DataTable GetSelectedPageInfo(string PageID)
        {
            string select = @"select id,formname,formdescription from user_form_name where id='" + PageID + "'";

            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_form_name");
            return dt;
        }

        internal void UpdateFormInfo(clsNewFormSetup aclsNewFormSetup)
        {
            string query = @"UPDATE user_form_name set formname='" + aclsNewFormSetup.FormName + "',formdescription='" + aclsNewFormSetup.FormDescription + "' where id = '" + aclsNewFormSetup.FormID + "'";

            DataManager.ExecuteNonQuery(connectionString, query);
        }
    }
}
