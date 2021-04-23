using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TaskMangement.App_Code
{
    class clsRegistrationManger
    {
        string connectionString = DataManager.OraConnString();
        OracleConnection con = new OracleConnection(DataManager.OraConnString());
        internal void SaveRegistrationInfo(clsRegistration aclsRegistration)
        {
            string query = @"INSERT INTO user_login (id,user_id,password,user_name,confirmpassword,usertype,status)
        VALUES ((SELECT max(nvl(id,0))+1 FROM user_login),'" + aclsRegistration.UserID + "','" + aclsRegistration.UserPassword + "','" + aclsRegistration.UserName + "','" + aclsRegistration.UserConfirmPassword + "','" + aclsRegistration.UserType + "','" + aclsRegistration.UserStatus + "')";

            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal DataTable GetUserInfo()
        {
            string select = @"SELECT user_id,user_name,usertype,status FROM user_login";

            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_login");
            return dt;
        }

        internal void UpdateRegistrationInfo(clsRegistration aclsRegistration)
        {
            string query = @"update user_login set password='" + aclsRegistration.UserPassword + "',user_name='" + aclsRegistration.UserName + "',confirmpassword='" + aclsRegistration.UserConfirmPassword + "',usertype='" + aclsRegistration.UserType + "',status='" + aclsRegistration.UserStatus + "' where user_id= '" + aclsRegistration.UserID + "' ";

            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal void DeleteRegistrationInfo(clsRegistration aclsRegistration)
        {
            string query = @"DELETE FROM user_login WHERE user_id = '" + aclsRegistration.UserID + "' ";
            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal DataTable GetSelectedUser(object UserID)
        {
            string select = @"SELECT user_id,password,user_name,confirmpassword,usertype,status FROM user_login where user_id='" + UserID + "'";

            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "user_login");
            return dt;
        }
    }
}
