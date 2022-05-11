using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCResourceManagement
{
    class clsMonitorSaleData
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static DataTable CheckTransactionGroup1()
        {
            var sQuery = string.Empty;
            DataTable result = new DataTable();
            SqlHelper oSqlHelper = new SqlHelper("cfnq");
            try
            {
                sQuery = " select[DATE], STORE, COUNT(TX_NO) 'TRANSACTIONS', SUM([VALUE]) 'AMOUNT' from INVTSERV1 WHERE  [DATE] >= dateadd(day, -day(getdate()), getdate())";
                sQuery += " and [DATE] <= getdate()";
                sQuery += " GROUP BY[DATE], STORE";
                sQuery += " ORDER BY [DATE]";
                result = oSqlHelper.GetData(sQuery);
                return result;
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "error");
            }

            return null;

        }

        public static DataTable CheckTransactionGroup2()
        {
            var sQuery = string.Empty;
            DataTable result = new DataTable();
            SqlHelper oSqlHelper = new SqlHelper("cfnq2");
            try
            {
                sQuery = " select[DATE], STORE, COUNT(TX_NO) 'TRANSACTIONS', SUM([VALUE]) 'AMOUNT' from INVTSERV1 WHERE   [DATE] >=  dateadd(day,-day(getdate()), getdate())";
                sQuery += " and [DATE] <= getdate()";
                sQuery += " GROUP BY[DATE], STORE";
                sQuery += " ORDER BY [DATE]";
                result = oSqlHelper.GetData(sQuery);
                return result;
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "error");
            }

            return null;

        }
    }
}
