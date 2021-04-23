using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsTokenInfoManager
    {
        //string connectionString = DataManager.OraConnString();
        //OracleConnection con = new OracleConnection(DataManager.OraConnString());
        internal void SaveTokenInfo(clsTokenInfo aclsTokenInfo)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string query = @"INSERT INTO prd.prd_tkn_mst (id,token_id,emp_id,comments,group_id,add_date,add_user) VALUES ((SELECT NVL(MAX(id),0)+1 id FROM prd.prd_tkn_mst),'" + aclsTokenInfo.TokenID + "','" + aclsTokenInfo.EmpID + "','" + aclsTokenInfo.Comments + "','" + aclsTokenInfo.GroupID + "',sysdate,'" + aclsTokenInfo.UserID + "')";
            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal static object GetGroupName()
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select id,group_name from prd.prd_tkn_group";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }

        internal DataTable GetEmployeeInformation(string empID)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select vempname,vdepartmentname,vdesignationname,vunitname from erp.hrm_vw_employeeinfo where vemployeeid = '" + empID + "' and empstatus='Active'";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }

        internal static DataTable GetMaxID(string empID)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select nvl(count(token_id),0)+1 serial from PRD.prd_tkn_mst where emp_id='" + empID + "'";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }
    }
}
