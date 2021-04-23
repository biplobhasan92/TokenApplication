using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsPermissionCheckUserMain
    {
        string connectionString = DataManager.OraConnString();
        OracleConnection con = new OracleConnection(DataManager.OraConnString());

        internal DataTable GetPermissionInfo(string UserID)
        {
            string select = @"select id,user_id, form_name,status FROM user_permission where user_id ='" + UserID + "'";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_permission");
            return dt;
        }
    }
}
