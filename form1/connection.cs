using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
    SqlConnection SqlCon = null;
    public Connection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection opneConnection()
    {
        try
        {
            ConnectionStringSettings consetting = ConfigurationManager.ConnectionStrings["dbString"];
            string connstr = consetting.ConnectionString;

            SqlCon = new SqlConnection(connstr);
            SqlCon.Open();
        }
        catch (Exception)
        {
            return null;
        }

        return SqlCon;
    }
    public void closeConnection(SqlConnection con)
    {
        con.Close();
       // return SqlCon;
    }
}
