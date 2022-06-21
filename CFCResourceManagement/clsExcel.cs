using System.Data.OleDb;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Serilog;
using System.IO;

namespace CFCResourceManagement
{
    class clsExcel
    {
        DataObject _dataOject;
        string _path = "";
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        OleDbConnection connection;
        public clsExcel(DataObject dataOject)
        {
            _dataOject = dataOject;
        }

        public clsExcel(string sFileName)
        {
            _path = sFileName;
        }
        public void ExportExcel()
        {

            Microsoft.Office.Interop.Excel.Application excelApp;
            Workbook excelWkbk;
            Worksheet excelWksht;
            object misValue = System.Reflection.Missing.Value;
            excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            excelWkbk = excelApp.Workbooks.Add(misValue);
            excelWksht = (Worksheet)excelWkbk.Worksheets.get_Item(1);
            Range CR = (Range)excelWksht.Cells[1, 1];
            CR.Select();
            excelWksht.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private List<string> ToExcelsSheetList()
        {
            List<string> sheets = new List<string>();
            using (OleDbConnection connection =
                    new OleDbConnection((_path.TrimEnd().ToLower().EndsWith("x"))
                    ? "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + _path + "';" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'"
                    : "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _path + "';Extended Properties=Excel 8.0;"))
            {
                connection.Open();
                System.Data.DataTable dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                foreach (DataRow drSheet in dt.Rows)
                    if (drSheet["TABLE_NAME"].ToString().Contains("$"))
                    {
                        string s = drSheet["TABLE_NAME"].ToString();
                        sheets.Add(s.StartsWith("'") ? s.Substring(1, s.Length - 3) : s.Substring(0, s.Length - 1));
                    }
                connection.Close();
            }
            return sheets;
        }

        public bool ImportExcel()
        {
            bool isSuccessful = false;
            var lst = ToExcelsSheetList();
            string sQueryIns = "";
            try
            {
                using (OleDbConnection excelConnection =
                   new OleDbConnection((_path.TrimEnd().ToLower().EndsWith("x"))
                   ? "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + _path + "';" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'"
                   : "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _path + "';Extended Properties=Excel 8.0;"))
                {
                    //Create OleDbCommand to fetch data from Excel 
                    var sQuery = String.Format("Select * from [{0}$]", lst[1]);
                    using (OleDbCommand cmd = new OleDbCommand(sQuery, excelConnection))
                    {
                        excelConnection.Open();
                        using (OleDbDataAdapter dReader = new OleDbDataAdapter())
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dReader.SelectCommand = cmd;
                            dReader.Fill(dt);


                            foreach (DataRow item in dt.Rows)
                            {
                                if (item[13].ToString().Contains('/'))
                                {


                                    sQueryIns = "INSERT INTO CF_TRUC_THUOC(MaSoThue,MaCH, TenCH, DiaChi,NgayBatCo, NgayKT_DK,NgayKT_CT, PriceZone, POS,HoatDong,KtSlbh, UpdateTime) Values(";
                                    sQueryIns += "'" + item[12].ToString() + "'";
                                    sQueryIns += ",'" + item[5].ToString() + "'";
                                    sQueryIns += ",N'" + item[1].ToString() + "'";
                                    sQueryIns += ",N'" + item[2].ToString() + "'";
                                    sQueryIns += ",'" + Convert2DbDatetime(item[14].ToString()) + "'";
                                    sQueryIns += ",'" + Convert2DbDatetime(item[13].ToString()) + "'";
                                    sQueryIns += ",'" + Convert2DbDatetime(item[13].ToString()) + "'";
                                    sQueryIns += ",'" + item[9].ToString() + "','TOPOS',1,1,GETDATE())";

                                    SqlHelper sqlHelper = new SqlHelper("cnn");
                                    sqlHelper.ExecNonQuery(sQueryIns);
                                }
                            }

                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "Error");
            }
            return isSuccessful;
        }
        string Convert2DbDatetime(string pattern)
        {
            var sResult = "";
            if (pattern.Contains('/'))
            {
                var tmp = pattern.Split('/');
                sResult = tmp[2] + tmp[1] + tmp[0];
            }


            return sResult;
        }
    }
}
