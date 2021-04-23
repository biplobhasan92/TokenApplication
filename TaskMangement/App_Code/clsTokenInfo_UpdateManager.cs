using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsTokenInfo_UpdateManager
    {
        internal DataTable GetEmployeeInformation(string TokenID)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select tn.emp_id,em.vempname,em.vdepartmentname,em.vdesignationname,em.vunitname,tn.group_id,tn.comments from prd.prd_tkn_mst tn inner join ERP.hrm_vw_employeeinfo em on tn.emp_id = em.vemployeeid where tn.token_id = '" + TokenID + "'";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_mst");
            return dt;
        }

        internal DataTable GetSearchRelatedGrid(object selectedValue)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"SELECT tn.id,tn.item_name,tn.unit_price FROM prd.prd_tkn_itemname tn where tn.group_id='" + selectedValue + "' order by tn.id asc";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_mst");
            return dt;
        }

        internal void SaveSellInfo(clsTokenInfo_Update aclsTokenInfo_Update, List<clsTokenInfo_Update> unitPriceList)
        {
            OracleConnection connection = new OracleConnection(DataManager.OraConnString());
            OracleTransaction transaction;
            connection.Open();
            transaction = connection.BeginTransaction();
            try
            {
                //connection.Open();
                //transaction = connection.BeginTransaction();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                OracleCommand command1 = new OracleCommand();
                command1.Connection = connection;
                command1.Transaction = transaction;

                command.CommandText = @"update prd.prd_tkn_mst set selldate = '" + aclsTokenInfo_Update.SellDate + "',edit_user = '" + aclsTokenInfo_Update.UpdateUser + "' where token_id = '" + aclsTokenInfo_Update.TokenNo + "' ";
                command.ExecuteNonQuery();

                foreach (clsTokenInfo_Update saveUnitPriceList in unitPriceList)
                {
                    command1.CommandText = @"INSERT INTO prd.prd_tkn_dtls (id,token_id,group_id,item_id,itemqty,unit_price) VALUES ((SELECT NVL(MAX(id),0)+1 id FROM prd.prd_tkn_dtls),'" + aclsTokenInfo_Update.TokenNo + "','" + aclsTokenInfo_Update.GroupID + "','" + saveUnitPriceList.ItemsID + "','" + saveUnitPriceList.QntUnit + "','" + saveUnitPriceList.Price + "')";
                    command1.ExecuteNonQuery();
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

        internal DataTable GetTokenRelatedGrid(string TokenID)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select ptd.token_id,ptd.group_id,ptd.itemqty,tn.id,tn.item_name,tn.unit_price from prd.prd_tkn_dtls ptd
inner join prd.prd_tkn_itemname tn on ptd.item_id=tn.id where ptd.token_id ='" + TokenID + "' order by tn.id asc";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_mst");
            return dt;
        }

        internal void DeleteRecord(clsTokenInfo_Update aclsTokenInfo_Update)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string Query = @"delete from prd.prd_tkn_dtls where token_id ='" + aclsTokenInfo_Update.TokenNo + "' ";
            DataManager.ExecuteNonQuery(connectionString, Query);
        }
    }
}
