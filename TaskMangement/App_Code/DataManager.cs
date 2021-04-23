using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class DataManager
    {
        public static void ExecuteNonQuery(string ConnectionString, string query)
        {
            //using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            //{
            //    using (SqlCommand myCommand = new SqlCommand(query, myF:\FKL_Project_Workspaces\Project_WorkSpace_DotNet\TokenApplication\TaskMangement\App_Code\DataManager.csConnection))
            //    {
            //        myConnection.Open();
            //        myCommand.ExecuteNonQuery();
            //    }
            //}

            using (OracleConnection myConnection = new OracleConnection(ConnectionString))
            {
                using (OracleCommand myCommand = new OracleCommand(query, myConnection))
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string ConnectionString, string query, string tableName)
        {
            //using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            //{
            //    using (SqlDataAdapter myAdapter = new SqlDataAdapter(query, myConnection))
            //    {
            //        DataSet ds = new DataSet();
            //        myAdapter.Fill(ds, tableName);
            //        ds.Tables[0].TableName = tableName;
            //        return ds.Tables[0];
            //    }
            //}

            using (OracleConnection myConnection = new OracleConnection(ConnectionString))
            {
                using (OracleDataAdapter myAdapter = new OracleDataAdapter(query, myConnection))
                {
                    DataSet ds = new DataSet();
                    myAdapter.Fill(ds, tableName);
                    ds.Tables[0].TableName = tableName;
                    return ds.Tables[0];
                }
            }
        }

        //public string OraConnString(string host, string port, string service, string user, string pass)
        //{
        //    return String.Format(
        //        "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST+{0})" +
        //    " (PORT={1})) (CONNECT_DATA=(SERVICE_NAME={2}))); User Id={3};Password{4};",
        //    host,
        //    service,
        //    user,
        //    pass);
        //}
        public static string OraConnString()
        {
            /*************** this will work local pc *******************/
            //return String.Format("DATA SOURCE = Localhost:1521/orcl; PERSIST SECURITY INFO=True;  USER ID=taskmanagement; password=taskmanagement;");

            return String.Format("DATA SOURCE = 192.168.100.157:1522/erp; PERSIST SECURITY INFO=True;  USER ID=erp; password=erp;");

            //return String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=172.16.100.8)(HOST=172.16.100.8)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl))); PERSIST SECURITY INFO=True; User Id=taskmanagement;Password=taskmanagement;");

            //string connectionString = "Data Source = (DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)));User Id = hr; password = hr;"; 

            //return String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=MyHost)(PORT=MyPort))(CONNECT_DATA=(SERVICE_NAME=MyOracleSID)));User Id=taskmanagement;Password=taskmanagement;");
        }

        public static int GetNextID(string tableName, string idField)
        {
            int val = 0;
            String ConnectionString = DataManager.OraConnString();
            OracleConnection myConnection = new OracleConnection(ConnectionString);

            string Query = "select TO_NUMBER(nvl(max(" + idField + "),0)) from  " + tableName;
            myConnection.Open();
            OracleCommand myCommand = new OracleCommand(Query, myConnection);
            object maxValue = myCommand.ExecuteScalar();
            myConnection.Close();
            if (maxValue == DBNull.Value) return 1;
            else
                val = int.Parse((maxValue).ToString());
            val = val + 1;
            return val;
        }
    }
}
