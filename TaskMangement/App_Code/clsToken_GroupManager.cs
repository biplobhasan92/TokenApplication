using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsToken_GroupManager
    {
        internal void SaveGroupName(clsToken_Group aclsToken_Group)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string query = @"INSERT INTO prd.prd_tkn_group (id,group_name) VALUES ((SELECT NVL(MAX(id),0)+1 id FROM PRD.prd_tkn_group),'" + aclsToken_Group.GroupName + "')";
            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal DataTable GetGroupName()
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select id,group_name from prd.prd_tkn_group";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }
    }
}
