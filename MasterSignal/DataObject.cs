using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MasterSignal
{
    public partial class DataObject
    {
        Utilities util = new Utilities();
        DataTable dt;
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection con = new SQLiteConnection(string.Format(DBSQL.conStr, util.GetConfigValue("DBFilePath")));
            con.Open();
            return con;
        }
        private string getSqlString(string pdata)
        {
            string rstr = "";
            foreach (string str in pdata.Split(','))
                rstr += "'" + str + "',";
            return rstr.Trim(',');
        }
        private StringBuilder GetDataSetSB(string sql, bool withColumn = true)
        {
            using var cmd = new SQLiteCommand(sql, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            if (withColumn == true)
            {
                var columnNames = Enumerable.Range(0, rdr.FieldCount).Select(rdr.GetName).ToList();
                sb.Append(string.Join(",", columnNames));
                sb.AppendLine();
            }
            while (rdr.Read())
            {
                string singleRow = "";
                for (int i = 1; i < rdr.FieldCount; i++)
                    singleRow += rdr.GetString(i) + ",";
                sb.AppendLine(singleRow);
            }
            return sb;
        }

        internal void UpdateTimeSheet(string rowHeader, string colHeader, string val)
        {
            string mainsql = string.Format(DBSQL.sqlTimeSheetUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();

        }
        //Ticks
        public StringBuilder GetTickByDate(string pData, bool wCol)
        {
            return GetDataSetSB(string.Format(DBSQL.sqlTickByDate, pData), wCol);
        }
        public bool AnyTickNotComplete(string pData)
        {
            StringBuilder sb = GetDataSetSB(string.Format(DBSQL.sqlTickByDate, pData), false);
            return sb.ToString().Contains("False");
        }
        internal void UpdateCurTrend(string rowHeader, string colHeader, string val)
        {
            string mainSQL = string.Format(DBSQL.sqlTrendUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        internal void UpdatePattern(string rowHeader, string colHeader, string val)
        {
            string mainSQL = string.Format(DBSQL.sqlPatternUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        public void AddOrUpdateTick(string pData)
        {
            string sqlInsert = "INSERT INTO tblTickOption(CurDate,opt1,opt2,opt3,opt4,opt5,opt6) values(";
            string sqlDelete = "DELETE FROM tblTickOption WHERE lower(CurDate) = '" + pData.Split(',')[0].ToLower() + "'";

            using var cmd = new SQLiteCommand(GetConnection());
            cmd.CommandText = sqlDelete;
            cmd.ExecuteNonQuery();

            cmd.CommandText = sqlInsert + getSqlString(pData) + ")";
            cmd.ExecuteNonQuery();
        }
        internal void UpdateCheckList(string rowHeader, string colHeader, string val)
        {
            string mainSQL = string.Format(DBSQL.sqlCheckListUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        //Quotes
        public string GetQuoteByID()
        {
            SQLiteConnection con = GetConnection();
            SQLiteCommand cmd = new SQLiteCommand(DBSQL.sqlQuotesById, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string qotesVal = "";
            if (rdr.HasRows)
            {
                string qotesID = "";

                while (rdr.Read())
                {
                    qotesID = rdr[0].ToString();
                    qotesVal = rdr[1].ToString();
                }

                cmd = new SQLiteCommand(string.Format(DBSQL.sqlQuotesUpdateById, qotesID), con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SQLiteCommand(DBSQL.sqlQuotesUpdateAll, con);
                cmd.ExecuteNonQuery();
            }
            return qotesVal;
        }
        //WebSites
        public string GetWebSitesAll()
        {
            using var cmd = new SQLiteCommand(DBSQL.sqlWebSitesAll, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string singleRow = "";
            while (rdr.Read())
                singleRow += rdr.GetString(0) + ",";
            return singleRow;
        }
        public List<Website> GetWSYoutubeAll(VideoType type)
        {
            List<Website> lstWebsites = new List<Website>();
            Website lstWebsite;
            string mainsql = (type == VideoType.All) ? DBSQL.sqlWSYouTubeAll : string.Format(DBSQL.sqlWebSitesByType, type);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());

            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lstWebsite = new Website
                {
                    id = rdr.GetInt32(0),
                    Type = rdr.GetString(1),
                    Title = rdr.GetString(2),
                    Link = rdr.GetString(3)
                };
                lstWebsites.Add(lstWebsite);
            }
            return lstWebsites;
        }
        //ENews
        public DataTable GetENewsAll(ENewsPriority priority, string cPri = "", string cCon = "")
        {
            using var cmd = new SQLiteCommand(DBSQL.sqlENewsAll, GetConnection());
            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            return dt;

        }
        public DataTable GetENewsAllDT(ENewsPriority priority, string cPri = "", string cCon = "")
        {
            string mainsql = (priority == ENewsPriority.ALL) ? DBSQL.sqlENewsAll : string.Format(DBSQL.sqlENewsByCondition, cPri, cCon);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        private static List<EconomicNews> GetClassObjets(SQLiteDataReader rdr)
        {
            List<EconomicNews> lstEconomicNews = new List<EconomicNews>();
            while (rdr.Read())
            {
                lstEconomicNews.Add(new EconomicNews
                {
                    id = rdr.GetInt32(0),
                    NewsDate = rdr.GetString(1),
                    Country = rdr.GetString(2),
                    Priority = rdr.GetString(3),
                    ShortDetails = rdr.GetString(4),
                    Day = rdr.GetString(1).Substring(3, 2),
                    Month = rdr.GetString(1).Substring(11, 5)
                });
            }
            return lstEconomicNews;
        }
        internal void InsertTrade(string accName, string pair, string action, string tdate, string tMonth, string units, string TradeSize, string desc)
        {
            string mainSQL = string.Format(DBSQL.sqlInsertLiveTrades, accName, pair, action, tdate, tMonth, units, desc, TradeSize);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        internal void UpdateTrade(string id, string accName, string pair, string action, string tdate, string tMonth, string units, string TradeSize, string desc)
        {
            string mainSQL = string.Format(DBSQL.sqlUpdateTrade, accName, pair, action, tdate, tMonth, units, desc, id, TradeSize);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        public List<EconomicNews> GetENewsByToday()
        {
            string mainSQL = string.Format(DBSQL.sqlENewsByDay, DateTime.Now.ToString("dd"));
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            return GetClassObjets(cmd.ExecuteReader());
        }
        //LiveTrades
        public DataTable GetLiveTradeAll(string acc, string mon)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlLiveTradesAll, acc, mon, DateTime.Now.ToString("yyyy"));
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetLiveTradeAll(string acc)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlLiveValTradeAll, acc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        internal Account getNewAccountDetails(string accNo)
        {
            Account rtnAccount = new Account();
            
            string mainSQL = string.Format(DBSQL.sqlGetAccountNewDetails, accNo);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                rtnAccount.ID = rdr.GetInt32(i);
                rtnAccount.AccountType = rdr.GetString(++i);
                rtnAccount.ChallengeType = rdr.GetString(++i);
                rtnAccount.CurrencyType = rdr.GetString(++i);
                rtnAccount.Fundingfirm = rdr.GetString(++i);
                rtnAccount.Accountno = rdr.GetString(++i);
                rtnAccount.Capital = rdr.GetString(++i);
                rtnAccount.UserName= rdr.GetString(++i);
                rtnAccount.Password = rdr.GetString(++i);
                rtnAccount.ProfitShare = rdr.GetString(++i);
                rtnAccount.Accopendate= rdr.GetString(++i);
                rtnAccount.Accclosedate = rdr.GetString(++i);
                rtnAccount.Tradestartdate = rdr.GetString(++i);
                rtnAccount.Tradeenddate = rdr.GetString(++i);
                rtnAccount.Maxdailylossamt = rdr.GetString(++i);
                rtnAccount.Maxdailylossper = rdr.GetString(++i);
                rtnAccount.Maxtotallossamt = rdr.GetString(++i);
                rtnAccount.Maxtotallossper= rdr.GetString(++i);
                rtnAccount.Profittargetamt = rdr.GetString(++i);
                rtnAccount.Profittargetper = rdr.GetString(++i);
                rtnAccount.Trader = rdr.GetString(++i);
                rtnAccount.Challengefee = rdr.GetString(++i);
                rtnAccount.Details = rdr.GetString(++i);
                rtnAccount.Currencypair= rdr.GetString(++i);
                rtnAccount.Tradepattern = rdr.GetString(++i);
                rtnAccount.Totaltradingdays = rdr.GetString(++i);
                rtnAccount.Mintradingdays = rdr.GetString(++i);
                rtnAccount.Weekenedtrade = rdr.GetString(++i);
                rtnAccount.Stoporders = rdr.GetString(++i);
                rtnAccount.Newstrading = rdr.GetString(++i);
                rtnAccount.Minpositionduration = rdr.GetString(++i);
                rtnAccount.Closingopenpositions = rdr.GetString(++i);
                rtnAccount.Lotsizerange = rdr.GetString(++i);
                rtnAccount.Actuallotsize = rdr.GetString(++i);
                rtnAccount.Platform = rdr.GetString(++i);
                rtnAccount.Status = rdr.GetString(++i);
                rtnAccount.Website = rdr.GetString(++i);
            }
            return rtnAccount;
        }

        public DataTable GetTradeGroupByDate(string acc)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlGroupByDateVal, acc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetTradeGroupByPair(string acc)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlGroupByPairVal, acc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetTradeGroupByDate(string acc, string mon)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlGroupByDate, acc, mon);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetTradeGroupByPair(string acc, string mon)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlGroupByPair, acc, mon);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetLiveTradeByID(string id)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlLiveTradesByID, id);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetLiveTradeMaster(string acc, string mon)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlLiveTradesMaster, acc, mon);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetLiveTradeMaster(string acc)
        {
            DataTable dt = new DataTable();
            string mainSQL = string.Format(DBSQL.sqlLiveTradesMasterVal, acc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetChartData(string acc, string type)
        {
            DataTable dt = new DataTable();

            string mainSQL = string.Format(type == "1" ? DBSQL.sqlChartData1 : DBSQL.sqlChartData2, acc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        //Seasonal Data
        public List<SeasonalData> GetSeasonalDataAll()
        {
            List<SeasonalData> lstSeasonalData = new List<SeasonalData>();
            SeasonalData sData;
            string mainSql = string.Format(DBSQL.sqlSeasonalAll, DateTime.Now.ToString("MMM"), DateTime.Now.AddMonths(1).ToString("MMM"), DateTime.Now.AddMonths(2).ToString("MMM"));
            using var cmd = new SQLiteCommand(mainSql, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                sData = new SeasonalData
                {
                    id = rdr.GetInt32(0),
                    Pair = rdr.GetString(1),
                    CurMonth = rdr.GetString(2),
                    NextMonth = rdr.GetString(3),
                    ToNextMonth = rdr.GetString(4),
                    IsCurrency = rdr.GetString(5)
                };
                lstSeasonalData.Add(sData);
            }
            return lstSeasonalData;
        }
        //NFPDate
        public bool IsNFPToday()
        {
            string mainSql = string.Format(DBSQL.sqlNfpDateToday, DateTime.Now.ToString("dd-MMM"));
            using var cmd = new SQLiteCommand(mainSql, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            return rdr.HasRows;
        }
        //Possible Signal
        internal void DeleteTrade(string tradeId)
        {
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlDeleteTrade, tradeId), GetConnection());
            cmd.ExecuteNonQuery();
        }
        //User Details
        public Login GetUserDetails(string UName)
        {
            Login login = new Login();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlUserByName, UName), GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                login = new Login
                {
                    ID = rdr.GetInt32(0),
                    DisplayName = rdr.GetString(1),
                    Password = rdr.GetString(2),
                    Email = rdr.GetString(3),
                    Phone = rdr.GetString(4),
                    RoleType = (RoleType)Enum.Parse(typeof(RoleType), rdr.GetString(5), true),
                    CreatedDate = rdr.GetString(6),
                    isActive = rdr.GetString(7) == "True",
                    PaymentReceived = rdr.GetString(8) == "True"
                };
            }
            return login;
        }
        public bool IsValidUSer(string UName, string pwd)
        {
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlUserValid, UName, pwd), GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            return rdr.HasRows;
        }
        public bool IsUserActive(string UName)
        {
            Login login = new Login();
            string mainsql = string.Format(DBSQL.sqlUserIsActive, UName);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            return rdr.HasRows;
        }
        //Login events
        public bool InsertEvents(LoginEvents le)
        {
            string mainSQL = string.Format(DBSQL.sqlInsertLoginEvent, le.LogDate, le.UserAction, le.LoggedInBy);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
            return true;
        }
        public void SetupInitialDB(string v)
        {
            InsertEmptyRowDay(MarketData.MajDay, v);
            InsertEmptyRowDay(MarketData.MinDay, v);
            string day = DateTime.Now.ToString("ddd").ToLower();
            if (day == "sun" || day == "sat" || day == "mon")
            {
                InsertEmptyRowWeek(MarketData.MajWeek, v);
                InsertEmptyRowWeek(MarketData.MinWeek, v);
            }
        }
        private void InsertEmptyRowDay(MarketData md, string name)
        {
          /*  DateTime ExitingDate = Convert.ToDateTime(GetLastTradingDate(md) + DateTime.Now.ToString("yyyy"));
            DateTime NewDate = DateTime.Now.ToString("ddd") == "Tue" ? ExitingDate.AddDays(3) : ExitingDate.AddDays(1);
            if (NewDate.AddDays(1) < DateTime.Now)
            {
                string day = NewDate.ToString("ddd").ToLower();
                if (day != "sun" && day != "sat")
                    InsertMDataEmptyRow(md, name, NewDate.ToString("dd-MMM"));
            }*/
        }
        private void InsertEmptyRowWeek(MarketData md, string name)
        {
            DateTime ExitingDate = Convert.ToDateTime(GetLastTradingDate(md) + "-" + DateTime.Now.ToString("yyyy"));
            DateTime NewDate = ExitingDate.AddDays(13);
            if (NewDate < DateTime.Now)
            {
                string dateStr = ExitingDate.AddDays(7).ToString("dd-MMM");
                if (md == MarketData.MajWeek || md == MarketData.MinWeek)
                    dateStr = dateStr.ToUpper();

                InsertMDataEmptyRow(md, name, dateStr);
            }
        }
        //Major and Minor data
        public DataTable GetMarketData(MarketData md)
        {
            dt = new DataTable();
            string mainsql = string.Format(DBSQL.sqlMarketDataActive, getTableName(md), md);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            dt.Load(cmd.ExecuteReader());

            return dt;
        }
        public DataTable GetMarketDataTotal(MarketData md)
        {
            dt = new DataTable();
            string mainsql = string.Format(
                (md == MarketData.MajDay || md == MarketData.MajWeek) ?
                DBSQL.sqlMarketDataTotalMaj : DBSQL.sqlMarketDataTotalMin, getTableName(md), md);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            dt.Load(cmd.ExecuteReader());

            return dt;
        }
        public void UpdateMData(MarketData md, string pair, string date, string value)
        {
            string mainsql = string.Format(DBSQL.sqlMDataUpdate, getTableName(md), pair, value, getFieldName(md), date, md);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
        }
        private string getTableName(MarketData md)
        {
            return (md == MarketData.MajDay || md == MarketData.MajWeek) ? "tblMajorCurrencyPair" : "tblMinorCurrencyPair";
        }
        private string getFieldName(MarketData md)
        {
            return (md == MarketData.MajDay || md == MarketData.MajWeek) ? "MajorDate" : "MinorDate";
        }
        public bool InsertMDataEmptyRow(MarketData md, string user, string PDate)
        {
            string mainSQL = string.Format(DBSQL.sqlInsertMDEmpty, getTableName(md), getFieldName(md), PDate, md, user);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
            return true;
        } 
        public DataTable GetTimesheets()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlTimesheetAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public string GetLastTradingDate(MarketData md)
        {
            string mainSQL = string.Format(DBSQL.sqlGetLastTraDate, getFieldName(md), getTableName(md), md);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string rtrValue = "";
            while (rdr.Read())
            {
                rtrValue = rdr.GetString(0);
            }
            return rtrValue;
        }
        public DataTable GetHolidayAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlGetHDs, "1"), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void UpdateHD(string colName, string colValue, string id)
        {
            string mainsql = string.Format(DBSQL.sqlHDUpdate, colName, colValue, id);
            SQLiteCommand cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
            if (colName == "Notes")
            {
                cmd = new SQLiteCommand(DBSQL.sqlHDInsert, GetConnection());
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetTrendAll(bool isAllMatch)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(isAllMatch ? DBSQL.sqlTrendsGetAll : DBSQL.sqlTrendsGetAllMatch, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetdisbursementAll(string accid)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPayDisbursementAll, accid), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetAccCodeAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlLiveAccAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetSingleBar()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlSingleBar, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetPairReport()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlpairreportSelect, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void AddInvoice(Invoice ni)
        {
            long rowID;
            using SQLiteConnection con = GetConnection();
            SQLiteTransaction transaction = null;
            transaction = con.BeginTransaction();

            string mainSQL = string.Format(DBSQL.sqlInsertInvoice, ni.InvoiceCode, ni.InvDate, ni.TotalAmt, ni.AccId, ni.Type, ni.CapitalInterest, ni.NetAmount, ni.ExchangeRate);
            SQLiteCommand cmd = new SQLiteCommand(mainSQL, con);
            cmd.ExecuteNonQuery();
            rowID = con.LastInsertRowId;
            SQLiteCommand cmdItem;
            foreach (KeyValuePair<int, string> kvp in ni.invItem)
            {
                cmdItem = new SQLiteCommand(string.Format(DBSQL.sqlInsertInvItem, rowID, kvp.Key, kvp.Value, Convert.ToDouble(ni.ExchangeRate) * Convert.ToDouble(kvp.Value)), con);
                cmdItem.ExecuteNonQuery();
            }
            transaction.Commit();
        }
        public DataTable GetPHheader()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlPHheader, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetPHdetails(string invid)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPHdetails, invid), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        internal DataTable GetPHheaderItem()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlPHItem, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetPHItemdetails(string dName)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPHItemDetail, dName.ToLower()), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetCLList(string cltime)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlCLGetAll, cltime), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetLiveAccounts()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlLiveAccAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetTradeImageAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlTradingImageAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetImageTypeAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlImageTypeAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetImageDetails(string imageID)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlGetImageDetail, imageID), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public bool InsertImage(string name, string type, string source, string desc)
        {
            string mainSQL = string.Format(DBSQL.sqlImageInsert, name, type, source, desc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
            return true;
        }
        public bool UpdateImage(string id, string type, string source, string desc)
        {
            string mainSQL = string.Format(DBSQL.sqlImageUpdate, id, type, source, desc);
            using var cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
            return true;
        }
        public bool InsertPattern(string Date, string[] pat, string TimeFrame, string curType)
        {
            SQLiteConnection con = GetConnection();
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPatternFind, Date, TimeFrame, curType), con);
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count == 0)
            {
                string mainSQL = string.Format(DBSQL.sqlPatternInsert, Date, util.Rcomma(pat[0]), util.Rcomma(pat[1]), util.Rcomma(pat[2]), util.Rcomma(pat[3]), TimeFrame, curType);
                using var cmd1 = new SQLiteCommand(mainSQL, con);
                cmd1.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public DataTable Getpattern()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlPatternAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataTable GetPatternFilter(string timeframe, string currency)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPatternSarch, timeframe, currency), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataView GetChartProfit(string accno)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlChartMonth, accno), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt.DefaultView;
        }
        public DataView GetChartCount(string accno)
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlChartCount, accno), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt.DefaultView;
        }
        public bool LoadNews(List<EconomicNews> lstNews)
        {
            SQLiteConnection con = GetConnection();

            SQLiteCommand cmd1 = new SQLiteCommand(DBSQL.sqlENewsDelete, con);
            cmd1.ExecuteNonQuery();

            foreach (EconomicNews item in lstNews)
            {
                string mainSQL = string.Format(DBSQL.sqlENewsInsert, item.NewsDate, item.Country, item.Priority, item.ShortDetails);
                using var cmd = new SQLiteCommand(mainSQL, con);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public DataTable GetTypes()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlGetTypes, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        } 

        internal void DeletePayment(string invId)
        {
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlPaymentDelete, invId), GetConnection());
            cmd.ExecuteNonQuery();
            using var cmd1 = new SQLiteCommand(string.Format(DBSQL.sqlPaymentItemDelete, invId), GetConnection());
            cmd1.ExecuteNonQuery();
        }

        internal void UpdateNews(string rowHeader, string colHeader, string val)
        {
            string mainsql = string.Format(DBSQL.sqlNewsUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal void UpdateQQE(string rowHeader, string colHeader, string val)
        {
            string mainsql = string.Format(DBSQL.sqlQQEUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
        }

        public DataTable GetQQEAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlQQESelect, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void InsertQQE()
        {
            using var cmd = new SQLiteCommand(string.Format(DBSQL.sqlQQEInsert, DateTime.Now.ToString("dd-MMM")), GetConnection());

            cmd.ExecuteNonQuery();
        }
        public DataTable GetNewsCount()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlENewsCount, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
       
        internal object GetTradeOption()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlTradeIdeasAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        internal void UpdateTradeOption(string rowHeader, string colHeader, string val)
        {
            string mainsql = string.Format(DBSQL.sqlTradeOptionUpdate, rowHeader, val, colHeader);
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal string GetScrollValue()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.sqlGetScrollText, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt.Rows[0][2].ToString();
        }

        public DataTable GetAccountNewAll()
        {
            dt = new DataTable();
            using var cmd = new SQLiteCommand(DBSQL.GetAccountNewAll, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void ProcessAccount(Account acc, string action)
        {
           
            string mainsql = (action == "u") ? string.Format(DBSQL.sqlUpdateAccountNew, acc.AccountType, acc.ChallengeType, acc.CurrencyType, acc.Fundingfirm, acc.Accountno,
                                        acc.Capital, acc.UserName, acc.Password, acc.ProfitShare, acc.Accopendate, acc.Accclosedate, acc.Tradestartdate, acc.Tradeenddate,
                                        acc.Maxdailylossamt, acc.Maxdailylossper, acc.Maxtotallossamt, acc.Maxtotallossper, acc.Profittargetamt,
                                        acc.Profittargetper, acc.Trader, acc.Challengefee, acc.Details, acc.Currencypair, acc.Tradepattern, acc.Totaltradingdays, acc.Mintradingdays,
                                        acc.Weekenedtrade, acc.Stoporders, acc.Newstrading, acc.Minpositionduration, acc.Closingopenpositions, acc.Lotsizerange, acc.Actuallotsize,
                                        acc.Platform, acc.Status, acc.Website, acc.ID) :
                                        string.Format(DBSQL.sqlAddNewAccount, acc.AccountType, acc.ChallengeType, acc.CurrencyType, acc.Fundingfirm, acc.Accountno,
                                        acc.Capital, acc.UserName, acc.Password, acc.ProfitShare, acc.Accopendate, acc.Accclosedate, acc.Tradestartdate, acc.Tradeenddate,
                                        acc.Maxdailylossamt, acc.Maxdailylossper, acc.Maxtotallossamt, acc.Maxtotallossper, acc.Profittargetamt,
                                        acc.Profittargetper, acc.Trader, acc.Challengefee, acc.Details, acc.Currencypair, acc.Tradepattern, acc.Totaltradingdays, acc.Mintradingdays,
                                        acc.Weekenedtrade, acc.Stoporders, acc.Newstrading, acc.Minpositionduration, acc.Closingopenpositions, acc.Lotsizerange, acc.Actuallotsize,
                                        acc.Platform, acc.Status, acc.Website) ;
            using var cmd = new SQLiteCommand(mainsql, GetConnection());
            cmd.ExecuteNonQuery();
        }
    }
    public class DBSQL
    {
        public const string conStr = @"URI=file:{0}";
        public const string sqlTickByDate = "SELECT * FROM tblTickOption WHERE CurDate = '{0}'";
        public const string sqlQuotesById = "SELECT * FROM tblQuotesOfDay WHERE isdisplay = 0 limit 1";
        public const string sqlQuotesUpdateById = "UPDATE tblQuotesOfDay SET isdisplay = 1 WHERE ID = {0}";
        public const string sqlQuotesUpdateAll = "UPDATE tblQuotesOfDay SET isdisplay = 0";
        public const string sqlWebSitesAll = "SELECT link FROM tblWebsites WHERE type ='Website'";
        public const string sqlWSYouTubeAll = "SELECT * FROM tblWebsites WHERE type in ('Trading', 'Psychology', 'Motivational') ORDER BY type";
        public const string sqlWebSitesByType = "SELECT * FROM tblWebsites WHERE Type='{0}'";
        public const string sqlENewsAll = "SELECT * FROM tblEconomicNews where 1=1";
        public const string sqlENewsCount = "SELECT cc.Country, " +
                    "ifnull((SELECT count(*) FROM tblEconomicNews c WHERE Priority = 'HIGH' AND c.country= cc.country GROUP BY country), 0) AS High, " +
                    "ifnull((SELECT count(*) FROM tblEconomicNews c WHERE Priority = 'MEDIUM' AND c.country= cc.country GROUP BY country), 0) AS Medium " +
                    "FROM tblEconomicNews cc GROUP BY CC.country " +
                    "UNION ALL " +
                    "SELECT 'Total', (SELECT count(*) FROM tbleconomicnews WHERE priority='HIGH'), (SELECT count(*) FROM tbleconomicnews WHERE priority='MEDIUM')";

        public const string sqlENewsByCondition = "SELECT * FROM tblEconomicNews WHERE Priority IN ({0}) AND Country IN ({1})";
        public const string sqlENewsByDay = "SELECT * FROM tblEconomicNews WHERE substr(newsdate,4,2)='{0}'";
        public const string sqlENewsInsert = "INSERT INTO tblEconomicNews(NewsDate, Country, Priority, Details) VALUES ('{0}','{1}','{2}','{3}')";
        public const string sqlENewsDelete = "DELETE FROM tblEconomicNews";
        public const string sqlLiveTradesMaster = "SELECT av.*, la.username fROM tblAccountValue av inner join tblliveaccounts la on la.ID = av.AccID WHERE av.AccountName='{0}' and av.MonthName='{1}' ";
        public const string sqlLiveValTradeAll = "SELECT * FROM tblLiveTrades WHERE lower(Account)=lower('{0}') ORDER BY ID ";
        public const string sqlLiveTradesByID = "SELECT * FROM tblLiveTrades WHERE ID={0} ";
        public const string sqlLiveTradesAll = "SELECT * FROM tblLiveTrades WHERE Account='{0}' and TradeMonth='{1}' and TradeYear='{2}' ORDER BY TradeDay ";
        public const string sqlGroupByDate = "SELECT pair, TradeDay || '-' || substr(TradeMonth,1,3) as Date, count(*) as 'Count', printf('%.2f',sum(units)) Units FROM tblLiveTrades WHERE lower(account) = lower('{0}') and TradeMonth='{1}' GROUP BY TradeDay, TradeMonth ORDER BY trademonth ";
        public const string sqlGroupByPair = "SELECT pair, count(*) as'Count', printf('%.2f',sum(units)) Units FROM tblLiveTrades WHERE lower(account) = lower('{0}') and TradeMonth='{1}' GROUP BY pair";
        public const string sqlLiveTradesMasterVal = "SELECT av.*, la.username fROM tblAccountValue av inner join tblliveaccounts la on la.ID = av.AccID WHERE av.AccountName='{0}'";
        public const string sqlGroupByDateVal = "SELECT pair, TradeDay || '-' || substr(TradeMonth,1,3) as Date,count(*) as 'Count', printf('%.2f',sum(units)) Units FROM tblLiveTrades WHERE lower(account) = lower('{0}') GROUP BY TradeDay, TradeMonth ORDER BY trademonth ";
        public const string sqlGroupByPairVal = "SELECT pair, count(*) as'Count', printf('%.2f',sum(units)) as Units FROM tblLiveTrades WHERE lower(account) = lower('{0}') GROUP BY pair";
        public const string sqlUpdateLiveTradesByID = "UPDATE tblLiveTrades SET Desc='{0}' WHERE ID = '{1}'";
        public const string sqlInsertLiveTrades = "INSERT INTO tblLiveTrades(Account, Pair, Action, TradeDay, TradeMonth, Units, Desc,TradeSize) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
        public const string sqlUpdateTrade = "UPDATE tblLiveTrades SET Account='{0}', Pair='{1}', Action='{2}', TradeDay='{3}', TradeMonth='{4}', Units='{5}', Desc='{6}',tradesize='{8}' WHERE id='{7}'";
        public const string sqlDeleteTrade = "DELETE FROM tblLiveTrades WHERE id = {0}";
        public const string sqlChartData1 = "SELECT round(Units) as Units,TradeDay, TradeMonth FROM tblLiveTrades WHERE Account='{0}' ORDER BY TradeDay ";
        public const string sqlChartData2 = "SELECT Units FROM tbllivetrades WHERE Account = '{0}' ORDER BY ID";
        public const string sqlUpdateLT = "UPDATE tblLiveTrades SET {0}='{1}' WHERE ID = '{2}' ";
        public const string sqlUpdateMLT = "UPDATE tblAccountValue SET CloseBalance='{0}' WHERE AccountName ='{1}' AND MonthName= '{2}' ";
        public const string sqlSeasonalAll = "SELECT id, pair, {0}, {1}, {2}, IsCurrency FROM tblSeasonalData";
        public const string sqlNfpDateToday = "SELECT * FROM tblNFPDates WHERE nfpDate='{0}'";
        public const string sqlPosSignalAll = "SELECT * FROM tblPossibleSignal ORDER BY [Action], [IsActive]";
        public const string sqlInsertPS = "INSERT INTO tblPossibleSignal(TimeType, Pair, Pattern, Action, PatDate," +
                            " IsActive, CreatedBy, WithTrend, Notes) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
        public const string sqlUpdatePS = "UPDATE tblPossibleSignal SET [IsActive]='{0}' WHERE ID={1}";
        public const string sqlUserByName = "SELECT * FROM tblAppUsers WHERE UserName='{0}'";
        public const string sqlUserValid = "SELECT * FROM tblAppUsers WHERE UserName='{0}' AND Password='{1}'";
        public const string sqlUserIsActive = "SELECT * FROM tblAppUsers WHERE UserName='{0}' AND IsActive='Yes'";
        public const string sqlInsertLoginEvent = "INSERT INTO tblLoginEvents(Date,Action,LoggedInBy) VALUES('{0}','{1}','{2}')";
        public const string sqlTimesheetAll = "SELECT * FROM TimesheetView";
        public const string sqlTimeSheetUpdate = "UPDATE tblTimeSheet SET [{0}]='{1}' WHERE ID = '{2}' AND IsActive=1";
        public const string sqlNewsUpdate = "UPDATE tblEconomicNews SET [{0}]='{1}' WHERE ID = '{2}' ";
        public const string sqlMarketDataActive = "SELECT * FROM {0} WHERE IsActive='1' AND lower(TimeType)=lower('{1}')";
        public const string sqlMarketDataTotalMaj = "SELECT 'Total'," +
                    "sum(EURGBP), sum(EURAUD), sum(EURNZD), sum(EURCAD), sum(EURUSD), sum(EURJPY), " +
                    "sum(GBPAUD), sum(GBPNZD), sum(GBPCAD), sum(GBPUSD), sum(GBPJPY), sum(AUDUSD), " +
                    "sum(AUDJPY), sum(AUDCAD), sum(NZDUSD), sum(NZDJPY), sum(NZDCAD), sum(USDCAD), sum(CADJPY), sum(USDCHF) FROM {0} WHERE IsActive='1' AND lower(TimeType)=lower('{1}')";
        public const string sqlMarketDataTotalMin = "SELECT 'Total', " +
                    "sum(USDJPY), sum(AUDNZD), sum(EURCHF), sum(GBPCHF), sum(AUDCHF), sum(NZDCHF), sum(CADCHF), sum(CHFJPY), sum(EURSGD), sum(GBPSGD), " +
                    "sum(AUDSGD), sum(NZDSGD), sum(CADSGD), sum(USDSGD), sum(EURMXN), sum(GBPMXN), sum(SPX500), sum(USDWTI), sum(SILVER), sum(USGOLD) " +
                    "FROM {0} WHERE IsActive= '1' AND lower(TimeType) = lower('{1}')";
        public const string sqlMDataUpdate = "UPDATE {0} SET [{1}]='{2}' WHERE [{3}] = '{4}' AND lower(TimeType)=lower('{5}')";
        public const string sqlInsertMDEmpty = "INSERT INTO {0} ([{1}] ,TimeType, CreatedBy) VALUES('{2}','{3}','{4}')";
        public const string sqlGetLastTraDate = "SELECT {0} FROM {1} WHERE id = (SELECT MAX(id) FROM {1} WHERE TimeType = '{2}')";
        public const string sqlGetHDs = "SELECT * FROM tblHolidays WHERE isValid={0}";
        public const string sqlHDUpdate = "UPDATE tblHolidays SET [{0}]='{1}' WHERE ID='{2}'";
        public const string sqlHDInsert = "INSERT INTO tblHolidays(id) VALUES(null)";
        public const string sqlLiveAccAll = "SELECT ID, ID || '-' || AccountName || '-' || AccountNo AS TradeAccount, commType Commission, case Isactive when 1 then 'Closed' when 2 then 'Running' end as Status FROM tblLiveAccounts WHERE isActive <> 0";
        public const string sqlLiveFormatName = "SELECT id, substr(AccountName,1,4) || ' - ' || substr(accountNo, length(accountNo)-3,3) " +
                    " || ' - ' || substr(Broker,1,3) AS DsipName FROM tblLiveAccounts WHERE IsActive = 1";
        public const string sqlTrendsGetAll = "SELECT * FROM tblTrend WHERE IsActive=1";
        public const string sqlTrendsGetAllMatch = "SELECT * FROM tblTrend WHERE IsActive=1 and ((lower(week)='s' and lower(day)='s') or (lower(week)='l' and lower(day)='l'))";
        public const string sqlTrendCross = "SELECT * FROM tblTrend WHERE IsActive=1 AND Red='y' AND Blue='y' ";
        public const string sqlTrendCrossBlue = "SELECT * FROM tblTrend WHERE IsActive=1 AND Blue='y' ";
        public const string sqlTrendUpdate = "UPDATE tblTrend SET {0} = '{1}' WHERE ID = {2}";
        public const string sqlCheckListUpdate = "UPDATE tblCheckList SET {0} = '{1}' WHERE ID = {2}";
        public const string sqlSingleBar = "SELECT * FROM tblMajorCurrencyPair WHERE timetype = 'MajWeek' AND isactive = 1 ORDER BY id DESC LIMIT 1";
        
        public const string sqlPayDisbursementAll = "SELECT id, ItemName, Percentage,'' ActualValue, '' INR FROM tblPayDisbursments WHERE accid={0} ORDER BY sortorder";
        public const string sqlInsertInvoice = "INSERT INTO tblPayInvoice(InvoiceCode, InvDate, TotalAmt, Accid, Type, CapitalInterest, NetAmount, ExchangeRate) VALUES " +
                                                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
        public const string sqlInsertInvItem = "INSERT INTO tblPayInvoiceItem(InvID,DisID,Amount,AmountINR) VALUES('{0}','{1}','{2}','{3}')";
        public const string sqlPHheader = "SELECT ti.ID, ti.ID || ti.invoiceCode as InvoiceCode, ti.Type," +
                    " substr(invdate,0,7) || ' ' || substr(invdate, length(invdate)-1, 2) as InvDate," +
                    " printf('%.2f', ti.totalAmt) AS InvAmount" +
                    " FROM tblPayInvoice ti INNER JOIN tblLiveAccounts la ON ti.AccId = la.ID" +
                    " WHERE ti.IsActive= '1'";
        public const string sqlPHdetails = "SELECT pi.DisID, pd.ItemName, pd.percentage,  printf('%.2f', pi.Amount) AS Amount, pi.AmountINR FROM tblPayInvoiceitem pi " +
                    " INNER JOIN tblPayDisbursments pd ON pd.ID = pi.DisID WHERE pi.InvID={0} ";
        public const string sqlPHItem = "SELECT Distinct ItemName FROM tblPayDisbursments WHERE IsActive=1";
        public const string sqlPHItemDetail = "SELECT pi.DisID,pn.InvDate AS InvoiceDate, pn.InvoiceCode As Code,  pd.percentage,  printf('%.2f', pi.Amount) AS Amount, pi.AmountINR FROM tblPayInvoiceitem pi " +
                    " INNER JOIN tblPayDisbursments pd ON pd.ID = pi.DisID " +
                    " INNER JOIN tblPayInvoice pn ON pn.ID = pi.InvID " +
                    " WHERE pi.DisID in (SELECT ID FROM tblPayDisbursments WHERE lower(Itemname)= '{0}') ";
        public const string sqlCLGetAll = "SELECT ID, Desc, Responsible, Priority, Details FROM tblCheckList WHERE IsActive = 1 AND TimeFrame='{0}' ORDER BY Priority";
        public const string sqlTradePlanByAccID = "SELECT * FROM tblPlan WHERE AccID = '{0}' AND MonthName = '{1}'";
        public const string sqlTradingImageAll = "SELECT * FROM tblTradingImages WHERE IsActive='1'";
        public const string sqlImageTypeAll = "SELECT imagetype FROM tblTradingImages GROUP BY imagetype";
        public const string sqlGetImageDetail = "SELECT * FROM tblTradingImages WHERE ID = '{0}'";
        public const string sqlImageInsert = "INSERT INTO tblTradingImages(Filename, ImageType, source, Description) VALUES ('{0}','{1}','{2}','{3}')";
        public const string sqlImageUpdate = "UPDATE tblTradingImages SET ImageType = '{1}', source = '{2}', Description = '{3}' WHERE Id = '{0}'";
        public const string sqlPatternAll = "SELECT * FROM tblpattern WHERE IsActive=1 and currency='Major' Order By Id";
        public const string sqlPatternSarch = "SELECT * FROM tblpattern WHERE timeframe in ({0}) AND currency in ({1}) AND IsActive=1 ORDER BY Id";
        public const string sqlPatternInsert = "INSERT INTO tblpattern (Date, TT, DD, CBR, S3, Timeframe, Currency) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        public const string sqlPatternFind = "SELECT * FROM tblpattern WHERE Date = '{0}' and Timeframe = '{1}' AND Currency = '{2}'";
        public const string sqlPatternUpdate = "UPDATE tblpattern SET {0} = '{1}' WHERE ID = {2}";
        public const string sqlChartMonth = "SELECT substr(p.Trademonth,0,4) Month, Round(sum(p.units)) Win, " +
                    "ifnull(Round(-1 * (SELECT sum(units) FROM tblLiveTrades p1 WHERE p1.Trademonth = p.trademonth AND units< 0 AND p1.account='{0}' GROUP BY p1.Trademonth)), 0) Loss, " +
                    "Round(sum(p.units) + ifnull((SELECT sum(units) FROM tblLiveTrades p1 WHERE p1.Trademonth = p.trademonth AND units< 0 AND p1.account='{0}' GROUP BY p1.Trademonth),0)) Profit " +
                    "FROM tblLiveTrades p WHERE units > 0 AND p.account = '{0}' GROUP BY p.Trademonth ORDER BY p.id";
        public const string sqlChartCount = "SELECT substr(Trademonth,0,4) Month," +
            "SUM(CASE WHEN units >=0 THEN 1 ELSE 0 END) as Win," +
            "SUM(CASE WHEN units < 0 THEN 1 ELSE 0 END) as Loss, count(*) as Total " +
            "FROM " +
            "tblLiveTrades where account='{0}' group by trademonth order by id";
        public const string sqlGetTypes = "SELECT * FROM tblTypes WHERE IsActive = '1'";
        public const string sqlPaymentDelete = "DELETE FROM tblPayInvoice WHERE ID = '{0}'";
        public const string sqlPaymentItemDelete = "DELETE FROM tblPayInvoiceItem WHERE InvId = '{0}'";

        public const string sqlQQEUpdate = "UPDATE tblQQE SET [{0}]='{1}' WHERE ID = '{2}'";
        public const string sqlQQESelect = "SELECT * FROM tblQQE WHERE IsActive = '1'";
        public const string sqlQQEInsert = "INSERT INTO tblQQE(date, Timeframe) VALUES('{0}','Day')";

        public const string sqlTradeOptionUpdate = "UPDATE tblTradeIdeas SET [{0}]='{1}' WHERE ID = '{2}'";
        public const string sqlTradeOptionInsert = "INSERT INTO tblTradeIdeas({0}) VALUES('{1}')";
        public const string sqlTradeIdeasAll = "SELECT * FROM tblTradeIdeas WHERE IsActive = '1'";
        public const string sqlpairreportInsert = "INSERT INTO tblPairreport (Currencypair,Trader,WQQE,DQQE,H4QQE,WTrend,DTrend,H4Trend,WCrossover,DCrossover,H4Crossover,Pattern,Details) VALUES { '{0}','{1}','{2}',{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',' {11}','{12}','{13}')";
        public const string sqlpairreportSelect = "SELECT * FROM tblPairreport";
        public const string sqlpairreportupdate = "UPDATE tblpairreport SET [{0}]='{1}' WHERE ID = '{13}'";

        public const string sqlAddNewAccount = "INSERT INTO tblLiveAccountsNew(AccountType, challengetype,currencytype,Fundingfirm, AccountNo, capital," +
           " Username, Password, profitshare, Accopendate,Accclosedate,tradestartdate,tradeenddate, Maxdailylossamt,Maxdailylossper,Maxtotallossamt,Maxtotallossper,Maxprofittargetamt,Maxprofittargetper," +
           "Trader,Challengefee,details,currencypair,tradepattern,Totaltradingdays,Mintradingdays,weekendtrade,Stoporders,newstrade,Minpositionduration," +
           " closingopenposition,lotsizerange, Actualotsize,platform,status,website) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
           "'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}')";
        
        internal static string sqlGetScrollText = "Select * From tblDailyTask WHERE Day = '" + DateTime.Now.ToString("dddd") + "'";

        public const string GetAccountNewAll = "select accountno, Capital, status from tblLiveAccountsNew";
        public const string Getpairreport = "select currencypair from tblpairreport";
        public const string sqlGetAccountNewDetails = "SELECT * FROM tblLiveAccountsNew WHERE accountno = '{0}'";

        public const string sqlUpdateAccountNew = "UPDATE tblLiveAccountsNew SET AccountType='{0}', ChallengeType='{1}', currencytype= '{2}',Fundingfirm='{3}', AccountNo='{4}', capital= '{5}', Username='{6}',Password='{7}', Profitshare='{8}', " +
                            " Accopendate='{9}', Accclosedate='{10}', Tradestartdate='{11}',Tradeenddate='{12}', Maxdailylossamt='{13}', " +
                            " Maxdailylossper='{14}', Maxtotallossamt='{15}', Maxtotallossper='{16}',Maxprofittargetamt='{17}', Maxprofittargetper='{18}',Trader='{19}', Challengefee='{20}', " +
                            "  Details='{21}', Currencypair='{22}', Tradepattern='{23}',Totaltradingdays='{24}', Mintradingdays='{25}',Weekendtrade='{26}', Stoporders='{27}',Newstrade='{28}', " +
                            "  Minpositionduration='{29}', Closingopenposition='{30}', lotsizerange='{31}', Actualotsize='{32}', platform='{33}', status='{34}',Website='{35}' " +
                            "WHERE AccountNo = '{36}' " ;

    }
}