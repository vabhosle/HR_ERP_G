using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
class xmlMaker
{

    public string ConvertToXMLDataString(DataTable table)
    {
        StringBuilder XMLString = new StringBuilder();
        if (string.IsNullOrEmpty(table.TableName))
            table.TableName = "DataTable";
        XMLString.AppendFormat("<{0}>", table.TableName);
        DataColumnCollection tableColumns = table.Columns;
        foreach (DataRow row in table.Rows)
        {
            XMLString.AppendFormat("<ParamRow>");
            foreach (DataColumn column in tableColumns)
            {
                XMLString.AppendFormat("<{1}>{0}</{1}>", row[column].ToString(), column.ColumnName);
            }
            XMLString.AppendFormat("</ParamRow>");
        }
        XMLString.AppendFormat("</{0}>", table.TableName);
        return XMLString.ToString();
    }

}

