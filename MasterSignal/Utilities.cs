using System.Diagnostics;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MasterSignal
{
    public class Utilities
    {
        public const string AppName = "Smart Forex App";
        public const string DateFormat = "dd-MMM-yyyy";
        public Utilities() { }
        public string GetConfigValue(string v)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            return appSettings[v].ToString();
        }
        public void ShowMessage(string v, string type = "i")
        {
            MessageBoxIcon mi = (type == "i") ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(v, AppName, MessageBoxButtons.OK, mi);
        }
        public DialogResult ShowQuestion(string v)
        {
            return MessageBox.Show(v, AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        public void ColorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => HeaderDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(BodyDraw);
        }
        private static void HeaderDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }
        private static void BodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        public ChartPattern CovertPattern(string pPattern)
        {
            return pPattern == "CBR" ? ChartPattern.ContinousBar :
                    pPattern == "TT" ? ChartPattern.TrainTrack :
                    pPattern == "DD" ? ChartPattern.DoubleDay :
                    ChartPattern.Stack3;
        }
        public string MonthName(int count = 0)
        {
            return DateTime.Now.AddMonths(count).ToString("MMM");
        }
        public string Getime(TimeZone ptimeZone)
        {
            var tiZone = TimeZoneInfo.FindSystemTimeZoneById(ptimeZone.ToString().Replace('_', ' '));
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, tiZone).ToString("HH:mm:ss");
        }
        public Color GetColor(ForexAction fa)
        {
            return fa == ForexAction.Sell ? Color.LightSalmon : Color.LightGreen;
        }
        public string Rcomma(string val)
        {
            return Regex.Replace(val, "-+", "-").Trim('-');
        }
        public Font GetFont(int size)
        {
            return new Font("Arial", size, FontStyle.Bold);
        }
        public Font GetFontRegular(int size)
        {
            return new Font("Arial", size, FontStyle.Regular);
        }
        public Bitmap GetPicture(TradePicture tp)
        {
            return new Bitmap(GetConfigValue("ImagePath") + tp.ToString() + ".png");
        }
        public void SaveToRepository()
        {
            var ps1File = @"C:\SmartForexApp\Github_CheckIn.ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy unrestricted \"{ps1File}\"",
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(startInfo);
        }
        public decimal GetVal(DataGridViewCell cell)
        {
            return Convert.ToDecimal(cell.Value);
        }
        public Color GetColor(string value)
        {
            Color c = Color.White;
            switch (Convert.ToInt32(value))
            {
                case int n when n > 100:
                    c = Color.DarkGreen;
                    break;
                case int n when n >= 50 && n <= 100:
                    c = Color.MediumSeaGreen;
                    break;
                case int n when n >= 10 && n <= 50:
                    c = Color.LightGreen;
                    break;
                case int n when (n >= 1 && n <= 10) || (n <= 0 && n >= -10):
                    c = Color.DarkGray;
                    break;
                case int n when n >= -50 && n <= -10:
                    c = Color.LightSalmon;
                    break;
                case int n when n >= -100 && n <= -50:
                    c = Color.OrangeRed;
                    break;
                case int n when n < -100:
                    c = Color.Red;
                    break;
            }
            return c;
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
    public enum RoleType
    {
        Admin = 1,
        User = 2,
        Customer = 3
    }
    public enum ForexAction
    {
        Buy = 1,
        Sell = 2,
        Cancel = 3,
        Default = 4
    }
    public enum TimeFrame
    {
        Week = 1,
        Day = 2,
        Hour4 = 3,
        Hour1 = 4,
        Minute15 = 5
    }
    public enum ChartPattern
    {
        DoubleDay = 1,
        TrainTrack = 2,
        ContinousBar = 3,
        Stack3 = 4,
        SingleTestBar = 5,
        Trend = 6,
        DeadCat = 7
    }
    public enum VideoType
    {
        Motivational = 1,
        Psychology = 2,
        Trading = 3,
        All = 4
    }
    public enum ENewsPriority
    {
        HIGH = 1,
        MEDIUM = 2,
        LOW = 3,
        ALL = 4
    }
    public enum TradeResult
    {
        Win = 1,
        Loss = 2,
        Breakeven = 3
    }
    public enum MarketData
    {
        MajDay = 1,
        MajWeek = 2,
        MinDay = 3,
        MinWeek = 4
    }
    public enum FXTrend
    {
        Up = 1,
        Down = 2,
        NoTrend = 5
    }
    public enum TimeZone
    {
        GMT_Standard_Time,
        US_Eastern_Standard_Time,
        India_Standard_Time
    }
    public enum TradePicture
    {
        Bars,
        Pattern,
        TradingFlowChart,
        NFPDates_2021,
        MeetingDetails,
        LogoDetail,
        Con_pattern,
        Rev_pattern,
        SFA_Logo,
        Youtube,
        FinNews,
        CL,
        Clock,
        TradeGoal01,
        Refresh,
        BreakOut,
        Seasonal,
        FxData
    }

    public enum InvoiceType
    {
        FTMOcharges = 1,
        MonthlyProfitSplit = 2
    }
}
public class ListViewItemComparer : System.Collections.IComparer
{
    private int col;
    public ListViewItemComparer()
    {
        col = 0;
    }
    public ListViewItemComparer(int column)
    {
        col = column;
    }
    public int Compare(object x, object y)
    {
        return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
    }
}