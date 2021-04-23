using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsUserPermissionManager
    {
        string connectionString = DataManager.OraConnString();
        OracleConnection con = new OracleConnection(DataManager.OraConnString());
        internal DataTable GetAllInformationUserWise()
        {
            string select = @"select id,formname as form_name,formdescription from user_form_name";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_form_name");
            return dt;
        }

        internal DataTable GetUserName(string UserID)
        {
            string select = @"select user_id,user_name from user_login where user_id='" + UserID + "' ";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_login");
            return dt;
        }

        internal DataTable GetPermissData(string UserID)
        {
            string select = @"select id,user_id, form_name,status FROM user_permission where user_id = '" + UserID + "' ";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_permission");
            return dt;
        }

        internal void SaveUserPermisison(clsUserPermission aclsUserPermission, List<clsUserPermission> aFormNameList)
        {
            OracleConnection connection = new OracleConnection(DataManager.OraConnString());
            OracleTransaction transaction;
            connection.Open();
            transaction = connection.BeginTransaction();
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                foreach (clsUserPermission saveFormName in aFormNameList)
                {
                    command.CommandText = @"INSERT INTO user_permission (id,user_id,form_name,status) 
                VALUES
                ((SELECT (nvl(MAX(ID),0)+1) FROM user_permission),'" + aclsUserPermission.UserID + "','" + saveFormName.FormName + "','" + saveFormName.UserStatus + "')";
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        internal void DeleteUserInfo(clsUserPermission aclsUserPermission)
        {
            try
            {
                string query = @"delete from user_permission where user_id='" + aclsUserPermission.UserID + "'";
                DataManager.ExecuteNonQuery(connectionString, query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
