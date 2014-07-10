using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
class queryShooter
{
    SqlConnection SqlCon = null;
    SqlCommand sqlCmd;
    SqlDataReader dr;
    XmlDocument doc = new XmlDocument();
    Connection connectionObj = new Connection();
    public XmlDocument invt_trck_srach_mp_srch(Dictionary<string, string> dict)
    {
        SqlCon = createConnection();
        sqlCmd = new SqlCommand("EXEC [dbo].[usp_hr_invt_select_on_mp] @mp_EDP_NO=@edpNo,"
        + "@mp_Name=@name,"
        + "@mp_Grade=@grade,"
        + "@mp_Cadre=@cadre,"
        + "@mp_Function=@function,"
        + "@mp_ReptMngr=@rptMan,"
        + "@mp_Location=@location,"
        + "@mp_DOJFrom=@dojFrom,"
        + "@mp_DOJTo=@dojTo", SqlCon);
        
        if (dict["edpNo"].Equals(""))
        {
            sqlCmd.Parameters.Add("@edpNo", SqlDbType.VarChar,50); sqlCmd.Parameters["@edpNo"].Value = ""; 
        }
        else
        {
            sqlCmd.Parameters.Add("@edpNo", SqlDbType.Int); sqlCmd.Parameters["@edpNo"].Value = dict["edpNo"];
        }
        sqlCmd.Parameters.Add("@name", SqlDbType.VarChar,50); sqlCmd.Parameters["@name"].Value = dict["name"];
        sqlCmd.Parameters.Add("@grade", SqlDbType.VarChar,50); sqlCmd.Parameters["@grade"].Value = dict["grade"];
        sqlCmd.Parameters.Add("@cadre", SqlDbType.VarChar,50); sqlCmd.Parameters["@cadre"].Value = dict["cadre"];
        sqlCmd.Parameters.Add("@function", SqlDbType.VarChar,50); sqlCmd.Parameters["@function"].Value = dict["function"];
        sqlCmd.Parameters.Add("@rptMan", SqlDbType.VarChar,50); sqlCmd.Parameters["@rptMan"].Value = dict["rptMgr"];
        sqlCmd.Parameters.Add("@location", SqlDbType.VarChar,50); sqlCmd.Parameters["@location"].Value = dict["location"];
        if (dict["dojFrom"] == null)
        {
            sqlCmd.Parameters.Add("@dojFrom", SqlDbType.DateTime); sqlCmd.Parameters["@dojFrom"].Value = DBNull.Value;
        }
        else
        {
            sqlCmd.Parameters.Add("@dojFrom", SqlDbType.DateTime); sqlCmd.Parameters["@dojFrom"].Value = dict["dojFrom"];
        }
        if (dict["dojTo"] == null)
        {
            sqlCmd.Parameters.Add("@dojTo", SqlDbType.DateTime); sqlCmd.Parameters["@dojTo"].Value = DBNull.Value;
        }
        else
        {
            sqlCmd.Parameters.Add("@dojTo", SqlDbType.DateTime); sqlCmd.Parameters["@dojTo"].Value = dict["dojTo"];
        }
        dr = sqlCmd.ExecuteReader();
        while (dr.Read())
        {
            string XMLStr = dr[0].ToString();
            doc.LoadXml(XMLStr);
        }
        destroyConnection(SqlCon);
        return doc;
    }
    public int invt_invt_add_invt_add(Dictionary<string, string> dict)
    {
        SqlCon = createConnection();
        sqlCmd = new SqlCommand("EXEC [dbo].[usp_hr_intervention_insert] "
        + "@iv_invtName=@INVTNAME,"
        + "@iv_invtBatch=@INVTBATCH,"
        + "@iv_invtLocation=@INVTLOCATION,"
        + "@iv_trainerName=@TRAINERNAME,"
        + "@iv_invtMonth=@MONTH,"
        + "@iv_invtHours=@HOURS,"
        + "@iv_venueCost=@VENUECOST,"
        +"@iv_trainerCost=@TRAINERCOST,"
        + "@iv_trasportCost=@TRANSPORTCOST,"
        + "@iv_acmdCost=@ACMDCOST,"
        + "@iv_miscCost=@MISCCOST,"
        + "@iv_attdCount=@ATTDCOUNT,"
        + "@iv_invtFromDate=@INVTFROMDATE,"
        + "@iv_invtToDate=@INVTTODATE,"
        + "@iv_Search1=@SEARCH1,"
        + "@iv_Search2=@SEARCH2,"
        + "@iv_Search3=@SEARCH3,"
        + "@iv_Search4=@SEARCH4,"
        + "@iv_Search5=@SEARCH5", SqlCon);


        sqlCmd.Parameters.Add("@INVTNAME", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTNAME"].Value = dict["invtName"];
        sqlCmd.Parameters.Add("@INVTBATCH", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTBATCH"].Value = dict["invtBatch"];
        sqlCmd.Parameters.Add("@INVTLOCATION", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTLOCATION"].Value = dict["invtLocation"];
        sqlCmd.Parameters.Add("@TRAINERNAME", SqlDbType.VarChar, 50); sqlCmd.Parameters["@TRAINERNAME"].Value = dict["trainerName"];
        sqlCmd.Parameters.Add("@MONTH", SqlDbType.VarChar, 50); sqlCmd.Parameters["@MONTH"].Value = dict["invtMonth"];
        sqlCmd.Parameters.Add("@HOURS", SqlDbType.Decimal); sqlCmd.Parameters["@HOURS"].Value = Math.Round(Convert.ToDecimal(dict["invtHours"]), 2);
        sqlCmd.Parameters.Add("@VENUECOST", SqlDbType.Decimal); sqlCmd.Parameters["@VENUECOST"].Value = Math.Round(Convert.ToDecimal(dict["venueCost"]), 2);
        sqlCmd.Parameters.Add("@TRAINERCOST", SqlDbType.Decimal); sqlCmd.Parameters["@TRAINERCOST"].Value = Math.Round(Convert.ToDecimal(dict["trainerCost"]),2);
        sqlCmd.Parameters.Add("@TRANSPORTCOST", SqlDbType.Decimal); sqlCmd.Parameters["@TRANSPORTCOST"].Value = Math.Round(Convert.ToDouble(dict["trasportCost"]), 2);
        sqlCmd.Parameters.Add("@ACMDCOST", SqlDbType.Decimal); sqlCmd.Parameters["@ACMDCOST"].Value = Math.Round(Convert.ToDecimal(dict["acmdCost"]), 2);
        sqlCmd.Parameters.Add("@MISCCOST", SqlDbType.Decimal); sqlCmd.Parameters["@MISCCOST"].Value = Math.Round(Convert.ToDecimal(dict["miscCost"]), 2);
        sqlCmd.Parameters.Add("@ATTDCOUNT", SqlDbType.Int); sqlCmd.Parameters["@ATTDCOUNT"].Value = Convert.ToInt32(dict["attdCount"]);
        sqlCmd.Parameters.Add("@INVTFROMDATE", SqlDbType.DateTime); sqlCmd.Parameters["@INVTFROMDATE"].Value = dict["invtFromDate"];
        sqlCmd.Parameters.Add("@INVTTODATE", SqlDbType.DateTime); sqlCmd.Parameters["@INVTTODATE"].Value = dict["invtToDate"];
        sqlCmd.Parameters.Add("@SEARCH1", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH1"].Value = dict["Search1"];
        sqlCmd.Parameters.Add("@SEARCH2", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH2"].Value = dict["Search2"];
        sqlCmd.Parameters.Add("@SEARCH3", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH3"].Value = dict["Search3"];
        sqlCmd.Parameters.Add("@SEARCH4", SqlDbType.Int); sqlCmd.Parameters["@SEARCH4"].Value = Convert.ToInt32(dict["Search4"]);
        sqlCmd.Parameters.Add("@SEARCH5", SqlDbType.Int); sqlCmd.Parameters["@SEARCH5"].Value = Convert.ToInt32(dict["Search5"]);

        dr = sqlCmd.ExecuteReader();
        int id = 0;
        while (dr.Read())
        {
            id = Convert.ToInt16(dr[0]);
           
        //        MessageBox.Show(""+dr[0]);
        }
        destroyConnection(SqlCon);
        return id;
    }
    public int invt_invt_update_invt_add(Dictionary<string, string> dict)
    {
        SqlCon = createConnection();
        sqlCmd = new SqlCommand("EXEC [dbo].[usp_hr_intervention_update] "
        + "@iv_invtId=@INVTID,"
        + "@iv_invtName=@INVTNAME,"
        + "@iv_invtBatch=@INVTBATCH,"
        + "@iv_invtLocation=@INVTLOCATION,"
        + "@iv_trainerName=@TRAINERNAME,"
        + "@iv_invtMonth=@MONTH,"
        + "@iv_invtHours=@HOURS,"
        + "@iv_venueCost=@VENUECOST,"
        + "@iv_trainerCost=@TRAINERCOST,"
        + "@iv_trasportCost=@TRANSPORTCOST,"
        + "@iv_acmdCost=@ACMDCOST,"
        + "@iv_miscCost=@MISCCOST,"
        + "@iv_attdCount=@ATTDCOUNT,"
        + "@iv_invtFromDate=@INVTFROMDATE,"
        + "@iv_invtToDate=@INVTTODATE,"
        + "@iv_Search1=@SEARCH1,"
        + "@iv_Search2=@SEARCH2,"
        + "@iv_Search3=@SEARCH3,"
        + "@iv_Search4=@SEARCH4,"
        + "@iv_Search5=@SEARCH5", SqlCon);

        sqlCmd.Parameters.Add("@INVTID", SqlDbType.Int); sqlCmd.Parameters["@INVTID"].Value = Convert.ToInt32(dict["invtId"]);
        sqlCmd.Parameters.Add("@INVTNAME", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTNAME"].Value = dict["invtName"];
        sqlCmd.Parameters.Add("@INVTBATCH", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTBATCH"].Value = dict["invtBatch"];
        sqlCmd.Parameters.Add("@INVTLOCATION", SqlDbType.VarChar, 50); sqlCmd.Parameters["@INVTLOCATION"].Value = dict["invtLocation"];
        sqlCmd.Parameters.Add("@TRAINERNAME", SqlDbType.VarChar, 50); sqlCmd.Parameters["@TRAINERNAME"].Value = dict["trainerName"];
        sqlCmd.Parameters.Add("@MONTH", SqlDbType.VarChar, 50); sqlCmd.Parameters["@MONTH"].Value = dict["invtMonth"];
        sqlCmd.Parameters.Add("@HOURS", SqlDbType.Decimal); sqlCmd.Parameters["@HOURS"].Value = Math.Round(Convert.ToDecimal(dict["invtHours"]), 2);
        sqlCmd.Parameters.Add("@VENUECOST", SqlDbType.Decimal); sqlCmd.Parameters["@VENUECOST"].Value = Math.Round(Convert.ToDecimal(dict["venueCost"]), 2);
        sqlCmd.Parameters.Add("@TRAINERCOST", SqlDbType.Decimal); sqlCmd.Parameters["@TRAINERCOST"].Value = Math.Round(Convert.ToDecimal(dict["trainerCost"]), 2);
        sqlCmd.Parameters.Add("@TRANSPORTCOST", SqlDbType.Decimal); sqlCmd.Parameters["@TRANSPORTCOST"].Value = Math.Round(Convert.ToDouble(dict["trasportCost"]), 2);
        sqlCmd.Parameters.Add("@ACMDCOST", SqlDbType.Decimal); sqlCmd.Parameters["@ACMDCOST"].Value = Math.Round(Convert.ToDecimal(dict["acmdCost"]), 2);
        sqlCmd.Parameters.Add("@MISCCOST", SqlDbType.Decimal); sqlCmd.Parameters["@MISCCOST"].Value = Math.Round(Convert.ToDecimal(dict["miscCost"]), 2);
        sqlCmd.Parameters.Add("@ATTDCOUNT", SqlDbType.Int); sqlCmd.Parameters["@ATTDCOUNT"].Value = Convert.ToInt32(dict["attdCount"]);
        sqlCmd.Parameters.Add("@INVTFROMDATE", SqlDbType.DateTime); sqlCmd.Parameters["@INVTFROMDATE"].Value = dict["invtFromDate"];
        sqlCmd.Parameters.Add("@INVTTODATE", SqlDbType.DateTime); sqlCmd.Parameters["@INVTTODATE"].Value = dict["invtToDate"];
        sqlCmd.Parameters.Add("@SEARCH1", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH1"].Value = dict["Search1"];
        sqlCmd.Parameters.Add("@SEARCH2", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH2"].Value = dict["Search2"];
        sqlCmd.Parameters.Add("@SEARCH3", SqlDbType.VarChar, 500); sqlCmd.Parameters["@SEARCH3"].Value = dict["Search3"];
        sqlCmd.Parameters.Add("@SEARCH4", SqlDbType.Int); sqlCmd.Parameters["@SEARCH4"].Value = Convert.ToInt32(dict["Search4"]);
        sqlCmd.Parameters.Add("@SEARCH5", SqlDbType.Int); sqlCmd.Parameters["@SEARCH5"].Value = Convert.ToInt32(dict["Search5"]);

        dr = sqlCmd.ExecuteReader();
        int id = 0;
        while (dr.Read())
        {
            id = Convert.ToInt16(dr[0]);
        }
        destroyConnection(SqlCon);
        return id;
    }
    public int invt_invt_add_mp_add(Dictionary<string, string> dict)
    {
        SqlCon = createConnection();
        sqlCmd = new SqlCommand("EXEC [dbo].[usp_hr_invt_mp_mapping_insert] "
        +"@ivmp_invtNo=@invtno,"
        +"@ivmp_EDPNo=@edpstr,"
        +"@ivmp_rate=@rate,"
        +"@ivmp_Search1=@search1,"
        +"@ivmp_Search2=@search2,"
        +"@ivmp_Search3=@search3,"
        +"@ivmp_Search4=@search4,"
        +"@ivmp_Search5=@search5", SqlCon);


        sqlCmd.Parameters.Add("@invtno", SqlDbType.Int); sqlCmd.Parameters["@invtno"].Value = dict["invtNo"];
        sqlCmd.Parameters.Add("@edpstr", SqlDbType.VarChar, 500); sqlCmd.Parameters["@edpstr"].Value = dict["EDPNo"];
        sqlCmd.Parameters.Add("@rate", SqlDbType.VarChar,500); sqlCmd.Parameters["@rate"].Value = dict["rate"];

        sqlCmd.Parameters.Add("@search1", SqlDbType.VarChar, 500); sqlCmd.Parameters["@search1"].Value = dict["Search1"];
        sqlCmd.Parameters.Add("@search2", SqlDbType.VarChar, 500); sqlCmd.Parameters["@search2"].Value = dict["Search2"];
        sqlCmd.Parameters.Add("@search3", SqlDbType.VarChar, 500); sqlCmd.Parameters["@search3"].Value = dict["Search3"];
        sqlCmd.Parameters.Add("@search4", SqlDbType.Int); sqlCmd.Parameters["@search4"].Value = Convert.ToInt32(dict["Search4"]);
        sqlCmd.Parameters.Add("@search5", SqlDbType.Int); sqlCmd.Parameters["@search5"].Value = Convert.ToInt32(dict["Search5"]);

        dr = sqlCmd.ExecuteReader();
        int id = 0;
        while (dr.Read())
        {
            id = Convert.ToInt16(dr[0]);

            //        MessageBox.Show(""+dr[0]);
        }
        destroyConnection(SqlCon);
        return id;
    }


    public XmlDocument invt_mp_srach_mp_add(Dictionary<string, string> dict)
    {
        SqlCon = createConnection();
        sqlCmd = new SqlCommand("EXEC [dbo].[usp_hr_manpower_select] @mp_EDP_NO=@edpno", SqlCon);

        sqlCmd.Parameters.Add("@edpno", SqlDbType.Int); sqlCmd.Parameters["@edpno"].Value = Convert.ToInt32(dict["EDP_NO"]);
        
        dr = sqlCmd.ExecuteReader();
        while (dr.Read())
        {
            string XMLStr = dr[0].ToString();
            doc.LoadXml(XMLStr);
        }
        destroyConnection(SqlCon);
        return doc;
    }



    private SqlConnection createConnection()
    {
        try
        {
            return connectionObj.opneConnection();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return null;
        }
        
    }
    private void destroyConnection(SqlConnection con)
    {
       // Connection connectionObj = new Connection();
        connectionObj.closeConnection(con);
    }
}

//public class Connection
//{
//    SqlConnection SqlCon = null;
//    public Connection()
//    {
//        //
//        // TODO: Add constructor logic here
//        //
//    }
//    public SqlConnection opneConnection()
//    {
//        try
//        {
//            ConnectionStringSettings consetting = ConfigurationManager.ConnectionStrings["dbString"];
//            string connstr = consetting.ConnectionString;

//            SqlCon = new SqlConnection(connstr);
//            SqlCon.Open();
//        }
//        catch (Exception)
//        {
//            return null;
//        }

//        return SqlCon;
//    }
//    public SqlConnection closeConnection()
//    {
//        SqlCon.Close();
//        return SqlCon;
//    }
//}
