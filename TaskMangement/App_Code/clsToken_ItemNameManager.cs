using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsToken_ItemNameManager
    {
        internal void SaveItemInfo(clsToken_ItemName aclsToken_ItemName)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string query = @"INSERT INTO prd.prd_tkn_itemname (id,item_name,group_id,unit_id,unit_price) VALUES ((SELECT NVL(MAX(id),0)+1 id FROM PRD.prd_tkn_itemname),'" + aclsToken_ItemName.ItemName + "','" + aclsToken_ItemName.GroupID + "','" + aclsToken_ItemName.MeasureUnit + "','" + aclsToken_ItemName.UnitPrice + "')";
            DataManager.ExecuteNonQuery(connectionString, query);
        }

        internal DataTable GetItemHistory()
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"SELECT tn.id,tn.item_name,gp.group_name,un.unit_name,unit_price FROM prd.prd_tkn_itemname tn inner join prd.prd_tkn_group gp on tn.group_id=gp.id inner join prd.prd_tkn_unit_name un on tn.unit_id=un.id order by tn.id asc";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_itemname");
            return dt;
        }

        internal object GetMeasurementUnitName()
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"SELECT id,unit_name FROM prd.prd_tkn_unit_name order by id asc";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }

        internal DataTable GetGroupName()
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"select id,group_name from prd.prd_tkn_group order by id asc";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_group");
            return dt;
        }

        internal DataTable GetSelectedItem(string ItemID)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string select = @"SELECT id, item_name, group_id, unit_id, unit_price FROM prd.prd_tkn_itemname where id='" + ItemID + "'";
            DataTable dt = DataManager.ExecuteQuery(connectionString, select, "prd_tkn_itemname");
            return dt;
        }

        internal void UpdateItemInfo(clsToken_ItemName aclsToken_ItemName)
        {
            string connectionString = DataManager.OraConnString();
            OracleConnection con = new OracleConnection(DataManager.OraConnString());

            string query = @"update prd.prd_tkn_itemname set item_name='" + aclsToken_ItemName.ItemName + "',unit_price = '" + aclsToken_ItemName.UnitPrice + "' where id='" + aclsToken_ItemName.ItemID + "'";
            DataManager.ExecuteNonQuery(connectionString, query);
        }
    }
}
