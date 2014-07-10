using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
namespace form1
{
    public partial class Invt_Tracker_Search : Form
    {
        

        object param = new Object();

        public Invt_Tracker_Search()
        {
            
            InitializeComponent();
        }

        private void invt_EDPNo_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void invt_EDPNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void InterventionTrackTabManSearchBtn_Click(object sender, EventArgs e)
        {

        }

    }
}






             //string connstr = consetting.ConnectionString;

            //try
            //{
                //string[] parameters = new string[] { };
                //conn = new SqlConnection(connstr);
                //var Params = new List<fld>
                //{
                //    new fld() { mp_EDP_NO="12345"},
                //    new fld() { mp_Name=""},
                //    new fld() { mp_Grade=""},
                //    new fld() { mp_Cadre=""},
                //    new fld() { mp_Function=""},
                //    new fld() { mp_ReptMngr=""},
                //    new fld() { mp_Location=""},
                //    new fld() { mp_DOJ=""}
                //};

                        //foreach (Galaxy theGalaxy in theGalaxies)
                        //{
                        //    Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
                        //}


                //dr = cmd.ExecuteReader();
                //int attrVal = 0;
                //while (dr.Read())
                //{
                //    string XMLStr = dr[0].ToString();
                //    XmlDocument doc = new XmlDocument();
                //    doc.LoadXml(XMLStr);
                //    XmlNodeList elemList = doc.GetElementsByTagName("Intervention");
                //    invt_DG.Rows.Clear();
                //    invt_DG.Refresh();
                //    for (int i = 0; i < elemList.Count; i++)
                //    {
                //        attrVal = elemList[i].Attributes.Count;
                //        List<string> myCollection = new List<string>();
                //        string s = Convert.ToString(i + 1);
                //        myCollection.Add(s);
                //        for (int j = 0; j < attrVal; j++)
                //        {
                //            myCollection.Add(elemList[i].Attributes[j].Value);
                //        }
                        
                //        invt_DG.Rows.Add(myCollection.ToArray());
                        
                //    }

                                      
                //}