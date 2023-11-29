using System;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace MasterSignal
{
    public partial class frmDashBoard : Form
    {
        public Login loginDetail;
        private Utilities util;
        private DataObject db;
        private List<PossibleSignal> posSignal;
        private static readonly Chart c1 = new Chart();
        private bool IsNFPToday;
        public frmDashBoard()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeObjects();
                GetLoginDetails();
                ResetForm();
                LoadListHeader();
                SetNFPandQuote();
                SetSingleTB();
                grpChart.Visible = false;
                ShowTradeIdeas();
                SetScrollValue();
            }
            catch (Exception exce)
            {
                util.ShowMessage(exce.InnerException.Message);
            }
        }
        private void ShowTradeIdeas()
        {
            var q = dgTradeOption;
            q.RowTemplate.Resizable = DataGridViewTriState.True;
            q.AllowUserToAddRows = q.RowHeadersVisible = q.EnableHeadersVisualStyles = false;
            q.RowTemplate.MinimumHeight = 35;
            q.Font = new Font("Tahoma", 12);
            q.DataSource = db.GetTradeOption();
            q.Columns[0].Visible = q.Columns[7].Visible = q.Columns[6].Visible = false;
            q.Columns[5].Width = 500;
            q.Columns[1].Width = q.Columns[2].Width = q.Columns[3].Width = q.Columns[4].Width = 75;
            q.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            q.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            q.Columns[5].DefaultCellStyle.Font = new Font("Tahoma", 9);

            foreach (DataGridViewRow item in q.Rows)
                item.DefaultCellStyle.ForeColor = item.Cells[4].Value.ToString().ToLower() == "sell" ? Color.Red : Color.Green;
        }
        private void SetSingleTB()
        {
            DataTable dt = db.GetSingleBar();
            ListViewItem lv1;
            lstSingleBar.Items.Clear();
            string[] popCurrency = { "EURUSD", "GBPUSD", "EURJPY", "GBPJPY", "EURGBP" };
            List<string> popList = new List<string>(popCurrency);
            for (int rcount = 0; rcount < dt.Rows.Count; rcount++)
            {
                DataRow dr = dt.Rows[rcount];
                int totLen = dr.ItemArray.Length - 3;
                string flag = dr.ItemArray[totLen].ToString().Remove(0, 3);
                int chkValue = flag == "Week" ? 40 : 15;
                for (int ia = 2; ia < totLen; ia++)
                {
                    if (Math.Abs(Convert.ToInt32(dr.ItemArray[ia])) <= chkValue)
                    {
                        if (popList.Exists(t => t == dt.Columns[ia].ColumnName))
                        {
                            lv1 = new ListViewItem(dt.Columns[ia].ColumnName);
                            lv1.SubItems.Add(flag);
                            lstSingleBar.Items.Add(lv1);
                        }
                    }
                }
            }
            lblsingleBar.Text = "Single Test Bar (" + lstSingleBar.Items.Count.ToString() + ")";

        }
        private void InitializeObjects()
        {
            util = new Utilities();
            db = new DataObject();
            posSignal = new List<PossibleSignal>();
            IsNFPToday = false;
        }
        private void SetNFPandQuote()
        {
            if (db.IsNFPToday())
            {
                IsNFPToday = true;
                lbl_HighNewslist.Text += " NFP NEWS TODAY - Check USD Trades";
            }
            grp_quote.Top = grp_Signal.Top + grp_Signal.Height + 10;
            grp_quote.Left = grp_Signal.Left;
            lbl_quote.Text = db.GetQuoteByID();
            if (lbl_quote.Text.Length >= 75)
                lbl_quote.Font = util.GetFont(14);

            LoadTodayNews(ENewsPriority.HIGH);
            LoadSeasonal();
        }
        private void SetupAppforUserRole()
        {
            if (loginDetail.RoleType == RoleType.Customer)
            {
                dg_pattern.Enabled = false;
                mi_addTrade.Enabled = false;
                lnkTick.Visible = false;
            }
        }
        private void LoadSeasonal(bool showAll = false)
        {
            List<SeasonalData> lstdata = db.GetSeasonalDataAll();
            List<SeasonalData> filtered = lstdata.FindAll(t => Convert.ToSingle(t.CurMonth) >= 0 && Convert.ToSingle(t.NextMonth) >= 0);
            filtered.AddRange(lstdata.FindAll(t => Convert.ToSingle(t.CurMonth) <= 0 && Convert.ToSingle(t.NextMonth) <= 0));
            lstSeasonal.Items.Clear();
            List<SeasonalData> disData = showAll ? lstdata : filtered;
            foreach (SeasonalData sData in disData)
            {
                ListViewItem lv1 = new ListViewItem(sData.Pair);
                var s = lv1.SubItems;
                s.Add(sData.CurMonth);
                s.Add(sData.NextMonth);
                s.Add(sData.ToNextMonth);
                s[0].Font = util.GetFont(13);
                s[1].BackColor = util.GetColor(sData.CurMonth);
                s[2].BackColor = util.GetColor(sData.NextMonth);
                s[3].BackColor = util.GetColor(sData.ToNextMonth);
                s[1].ForeColor = s[2].ForeColor = s[3].ForeColor = Color.White;

                lv1.UseItemStyleForSubItems = false;
                lstSeasonal.Items.Add(lv1);
            }
            lstSeasonal.Columns[1].TextAlign = lstSeasonal.Columns[2].TextAlign = lstSeasonal.Columns[3].TextAlign = HorizontalAlignment.Center;
        }
        private void LoadTodayNews(ENewsPriority priority)
        {
            lstNews.Items.Clear();
            ListViewItem lv1;
            List<EconomicNews> lstEc = db.GetENewsByToday();
            foreach (EconomicNews tempNews in lstEc)
            {
                if (tempNews.Priority == priority.ToString() || priority == ENewsPriority.ALL)
                {
                    lv1 = new ListViewItem(tempNews.NewsDate.Substring(11, 5));
                    lv1.SubItems.Add(tempNews.Priority);
                    lv1.SubItems.Add(tempNews.Country);
                    lv1.SubItems.Add(tempNews.ShortDetails);
                    lstNews.Items.Add(lv1);
                    lv1.ForeColor = tempNews.Priority == "HIGH" ? Color.Red : Color.Black;
                }
            }
            lblNewsCount.Text = "High: " + lstEc.FindAll(t => t.Priority == ENewsPriority.HIGH.ToString()).Count.ToString()
                                + "  Medium: " + lstEc.FindAll(t => t.Priority == ENewsPriority.MEDIUM.ToString()).Count.ToString();
        }
        private void GetLoginDetails()
        {
            lblName.Text = loginDetail.DisplayName + " (" + loginDetail.RoleType.ToString().Substring(0, 1) + ") - " + DateTime.Now.ToString("dd/MMM");
            timeUK.Interval = timeScrollText.Interval = 100;
            timeUK.Start();
            timeScrollText.Start();
            SetupAppforUserRole();
        }
        private void ResetForm()
        {
            pic_education.Visible = false;
            pic_education.Width = 700;
            pic_education.Height = dg_pattern.Width = 600;
            pic_education.Top = 70;
            pic_education.Left = 100;

            int topPos = 60;
            dg_majorData.Top = topPos;
            dg_majorData.Width = dg_majorDataTotal.Width = 1220;
            dg_majorData.Height = 300;
            dg_majorDataTotal.Height = 30;
            dg_majorDataTotal.Top = dg_majorData.Height + topPos;
            dg_majorDataTotal.Left = dg_majorData.Left;

            txtCountDays.Top = lblSummary.Top = lblPatternGrid.Top = grpMonth.Top =
                dg_majorData.Height + topPos + dg_majorDataTotal.Height + 5;

            dg_summeryData.Top = dg_pattern.Top =
                dg_majorData.Height + topPos + dg_majorDataTotal.Height + lblSummary.Height + 5 + 5;
            dg_summeryData.Left = lblSummary.Left = 30;
            dg_summeryData.Width = 460;
            dg_summeryData.Height = dg_pattern.Height = 230;

            lnkFilter.Left = dg_summeryData.Right - lnkFilter.Width;
            txtCountDays.Left = dg_summeryData.Right - lnkFilter.Width - txtCountDays.Width - 5;

            lnkFilter.Top = txtCountDays.Top + 5;
            lblSummary.BackColor = lblPatternGrid.BackColor = btn_SaveCalculate.BackColor;
            dg_summeryData.AllowUserToAddRows = dg_summeryData.RowHeadersVisible =
                dg_majorDataTotal.AllowUserToAddRows = grp_grid.Visible = grp_Youtube.Visible = false;

            dg_pattern.Left = lblPatternGrid.Left = 650;
            lblPatternGrid.Text = "Pattern";

            grp_grid.Left = 30;
            grp_grid.Top = 70;
            grp_grid.Width = 1300;
            grp_grid.Height = 1200;

            dg_pattern.Font = label2.Font;
            dg_pattern.RowTemplate.Height = 45;

            btn_SaveCalculate.Top = 450;
            btn_SaveCalculate.Left = lblSelTotal.Left = 510;
            lblSelTotal.Top = btn_SaveCalculate.Top - 25;
            rad_MinDay.Left += 500;
            rad_MinWeek.Left = rad_MinDay.Left + 75;

            lblGeneral.Left += 100;
            lblGeneral.Text = "Major Day Movements";
            btn_SaveCalculate.Text = "Show Pattern";
            rad_MinDay.Top = rad_MinWeek.Top;

            pic_logo.SizeMode = pic_youTube.SizeMode = pic_finnews.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.Image = util.GetPicture(TradePicture.FxData);
            pic_youTube.Image = util.GetPicture(TradePicture.Youtube);
            pic_finnews.Image = util.GetPicture(TradePicture.FinNews);
            pic_CL.Image = util.GetPicture(TradePicture.CL);
            pic_TimeSheet.Image = util.GetPicture(TradePicture.Clock);
            pic_Refresh.Image = util.GetPicture(TradePicture.Refresh);

            grp_Signal.Top = grp_Youtube.Top = grpSeasonal.Top;
            grp_Signal.Left = grp_Youtube.Left;
            grpSeasonal.Height = grp_Signal.Height;
            grp_quote.Width = grp_Signal.Width + grpSeasonal.Width;

            ToolTip tTip = new ToolTip();
            tTip.SetToolTip(lblHeading, "Click here to go DashBoard Page.");
            tTip.SetToolTip(pic_logo, "Click here to view Day/Week Date.");
            tTip.SetToolTip(pic_youTube, "Click here to view YouTube Trading Video.");
            tTip.SetToolTip(pic_finnews, "Click here to view Financial news.");
            tTip.SetToolTip(lbl_youtubeHeader, "Double Click the link to open YouTube video.");
            tTip.SetToolTip(pic_CL, "Click the check List will show.");
            tTip.SetToolTip(pic_Refresh, "Click here to Refresh Dashboard.");
            tTip.SetToolTip(pic_TimeSheet, "Click here to enter the IN/OUT time.");

            lblHeading.Cursor = pic_CL.Cursor = pic_logo.Cursor = pic_youTube.Cursor = pic_finnews.Cursor = Cursors.Hand;

            lbl_HighNewslist.Text = DateTime.Now.ToString("dd-MMM") + " " + lbl_HighNewslist.Text;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            Text = Utilities.AppName;
            lnkTick.Left = btn_SaveCalculate.Left;
            lnkTick.Top = btn_SaveCalculate.Top + 150;
        }
        private void SetupView()
        {
            grp_Signal.Visible = false;
            pic_education.Visible = false;
            grp_grid.Visible = false;
            grp_quote.Visible = true;
            grpSeasonal.Visible = true;
            grp_Youtube.Visible = false;
            pic_education.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ForexOptionItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string clickName = e.ClickedItem.Name.ToLower();
            SetupView();
            switch (clickName)
            {
                case "mi_signal":
                    grp_Signal.Visible = true;
                    break;
                case "mi_major":
                case "mi_signal1":
                    Pic_logo_Click(sender, e);
                    break;
                case "mi_news":
                    frmNews frm9 = new frmNews();
                    frm9.ShowDialog();
                    break;
                case "mi_exit":
                    ExitApp();
                    break;
                case "mi_bar":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.Bars);
                    break;
                case "mi_pattern":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.Pattern);
                    break;
                case "mi_flowchart":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.TradingFlowChart);
                    break;
                case "mi_nfpdate":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.NFPDates_2021);
                    break;
                case "mi_meeting":
                    frmTradingImages frmImage = new frmTradingImages();
                    frmImage.ShowDialog();
                    break;
                case "mi_about":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.LogoDetail);
                    break;
                case "mi_breakout":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.BreakOut);
                    break;
                case "mi_seasonal":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.Seasonal);
                    break;
                case "mi_holiday":
                    grp_Signal.Visible = true;
                    frmHoliday frm = new frmHoliday();
                    frm.ShowDialog();
                    break;
                case "mi_trend":
                    grp_Signal.Visible = true;
                    frmTrend frm1 = new frmTrend();
                    frm1.ShowDialog();
                    break;
                case "mi_qqe":
                    grp_Signal.Visible = true;
                    frmQQE frm10 = new frmQQE();
                    frm10.ShowDialog();
                    break;
                case "mi_paysumreport":
                    grp_Signal.Visible = true;
                    frmChart frm2 = new frmChart();
                    frm2.ShowDialog();
                    break;
                case "mi_withdraw":
                    grp_Signal.Visible = true;
                    frmPayment frm3 = new frmPayment();
                    frm3.ShowDialog();
                    break;
                case "mi_payhistory":
                    grp_Signal.Visible = true;
                    frmPaymentHistory frm4 = new frmPaymentHistory();
                    frm4.ShowDialog();
                    break;
               // case "mi_showpattern":
                  //  grp_Signal.Visible = true;
                  //  frmPattern frm5 = new frmPattern();
                  //  frm5.ShowDialog();
                   // break;
                case "mi_newaccount":
                    grp_Signal.Visible = true;
                    frmNewAccount frm6 = new frmNewAccount();
                    frm6.ShowDialog();
                    break;
                case "mi_conpat":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.Con_pattern);
                    break;
                case "mi_revpat":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.Rev_pattern);
                    break;
                case "mi_mionr":
                    break;
                case "mi_tradingvideo":
                    grp_Youtube.Visible = true;
                    LoadYoutubeVideos(VideoType.All);
                    break;
                case "mi_tradingtarget":
                    pic_education.Visible = true;
                    pic_education.Image = util.GetPicture(TradePicture.TradeGoal01);
                    break;
            }
        }
        private void ExitApp()
        {
            if (util.ShowQuestion("Are you sure, you want to exit the APP without saving?") == DialogResult.OK)
                Application.Exit();
        }
        private void LoadYoutubeVideos(VideoType type)
        {
            lst_youtube.Items.Clear();
            ListViewItem lv1;
            foreach (Website ts in db.GetWSYoutubeAll(type))
            {
                lv1 = new ListViewItem(ts.Type);
                lv1.SubItems.Add(ts.Title);
                lv1.SubItems.Add(ts.Link);
                lv1.ForeColor = ts.Type == "Motivational" ? Color.DarkBlue : ts.Type == "Psychology" ? Color.Coral : Color.DarkGreen;
                lst_youtube.Items.Add(lv1);
            }
        }
        private void SetupMarketDate()
        {
            grp_quote.Visible = grpSeasonal.Visible =
            dg_majorData.RowHeadersVisible =
            dg_majorDataTotal.RowHeadersVisible = false;
            grp_grid.Visible = rdo_DayData.Checked = true;
            SetColorandLabel(MarketData.MajDay);
        }
        private void LoadMarketDataDB(MarketData md)
        {
            var q = dg_majorData;
            q.DataSource = db.GetMarketData(md);

            q.Columns.Remove("ID");
            q.Columns.Remove("TimeType");
            q.Columns.Remove("IsActive");
            q.Columns.Remove("CreatedBy");
            q.Columns[0].ReadOnly = true;
            q.AllowUserToAddRows = false;
            q.Columns[0].Width = 65;

            for (int i = 1; i <= 20; i++)
                q.Columns[i].Width = 56;

            q.FirstDisplayedScrollingRowIndex = q.RowCount - 1;
            CalculateMajorTotal();
        }
        private void SetPatterColHeader(int rowid, string txt, ChartPattern tooltxt)
        {
            var s = dg_pattern.Rows[rowid].Cells[0];
            s.Value = txt;
            s.ToolTipText = tooltxt.ToString();
        }
        private void IdentifyPattern()
        {
            var p = dg_pattern;
            var q = dg_majorData;
            DataTable result = new DataTable();
            for (int i = 0; i <= 4; i++)
            {
                if (i <= 4) result.Rows.Add();
                result.Columns.Add();
            }
            p.DataSource = result;
            SetPatterColHeader(0, "TT", ChartPattern.TrainTrack);
            SetPatterColHeader(1, "DD", ChartPattern.DoubleDay);
            SetPatterColHeader(2, "CBR", ChartPattern.ContinousBar);
            SetPatterColHeader(3, "S3", ChartPattern.Stack3);
            SetPatterColHeader(4, "DC", ChartPattern.DeadCat);
            for (int i = 1; i <= 4; i++)
                p.Columns[i].Width = 120;

            int TotalRowCount = q.Rows.Count;
            int lastRow = TotalRowCount - 1;
            int PreviousRow = lastRow - 1;
            int col = 1;
            //TT
            for (int colCount = 1; colCount <= 20; colCount++)
            {
                int lastValue = Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value);
                int previousValue = Convert.ToInt32(q.Rows[PreviousRow].Cells[colCount].Value);
                if ((lastValue > 0 && previousValue < 0) || (lastValue < 0 && previousValue > 0))
                {
                    if (Math.Abs(lastValue) > Math.Abs(previousValue) * 0.90)
                    // (Math.Abs(lastValue) < Math.Abs(previousValue) * 1.10))
                    {
                        p.Rows[0].Cells[col].Value = q.Columns[colCount].HeaderText;
                        p.Rows[0].Cells[col].Style.BackColor = (lastValue < previousValue) ? Color.OrangeRed : Color.LightGreen;
                        col++;
                    }
                }
                if (col == 5) { break; }
            }

            //Double DD
            col = 1;
            for (int colCount = 1; colCount <= 20; colCount++)
            {
                int lastValue = Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value);
                int previousValue = Convert.ToInt32(q.Rows[PreviousRow].Cells[colCount].Value);
                if ((Math.Abs(lastValue) < 15 && Math.Abs(previousValue) < 15))
                {
                    p.Rows[1].Cells[col].Value = q.Columns[colCount].HeaderText;
                    col++;
                }
                if (col == 5) { break; }
            }

            //CB continues bar
            col = 1;
            if (rdo_DayData.Checked == true || rad_MinDay.Checked == true)
            {
                if (TotalRowCount >= 7)
                {
                    for (int colCount = 1; colCount <= 20; colCount++)
                    {
                        int val1 = Convert.ToInt32(q.Rows[lastRow - 1].Cells[colCount].Value);
                        int val2 = Convert.ToInt32(q.Rows[lastRow - 2].Cells[colCount].Value);
                        int val3 = Convert.ToInt32(q.Rows[lastRow - 3].Cells[colCount].Value);
                        int val4 = Convert.ToInt32(q.Rows[lastRow - 4].Cells[colCount].Value);
                        int val5 = Convert.ToInt32(q.Rows[lastRow - 5].Cells[colCount].Value);
                        int val6 = Convert.ToInt32(q.Rows[lastRow - 6].Cells[colCount].Value);
                        int CheckValue = Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value);
                        int cbCount = 5;
                        if ((val1 >= 0 && val2 >= 0 && val3 >= 0 && val4 >= 0 && val5 >= 0 && val6 >= 0) ||
                            (val1 <= 0 && val2 <= 0 && val3 <= 0 && val4 <= 0 && val5 <= 0 && val6 <= 0))
                        {
                            int Total = val1 + val2 + val3 + val4 + val5;
                            for (int i = 6; i <= lastRow; i++)
                            {
                                if ((val1 >= 0 && val2 > 0) && Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value) > 0)
                                {
                                    cbCount++;
                                    Total += Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value);
                                }
                                else { break; }
                            }

                            for (int i = 6; i <= lastRow; i++)
                            {
                                if ((val1 <= 0 && val2 < 0) && Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value) < 0)
                                {
                                    cbCount++;
                                    Total += Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value);
                                }
                                else { break; }
                            }
                            if ((val1 > 0 && CheckValue < 0) || (val1 < 0 && CheckValue > 0))
                            {
                                p.Rows[2].Cells[col].Value = q.Columns[colCount].HeaderText + "(" + cbCount + ")";
                                p.Rows[2].Cells[col].ToolTipText = Total.ToString();
                                p.Rows[2].Cells[col].Style.BackColor = (val1 >= 0 && val2 > 0) ? Color.OrangeRed : Color.LightGreen;
                                col++;
                            }
                        }
                        if (col == 5) { break; }
                    }
                }
            }
            else
            {
                if (TotalRowCount >= 5)
                {
                    for (int colCount = 1; colCount <= 20; colCount++)
                    {
                        int val1 = Convert.ToInt32(q.Rows[lastRow - 1].Cells[colCount].Value);
                        int val2 = Convert.ToInt32(q.Rows[lastRow - 2].Cells[colCount].Value);
                        int val3 = Convert.ToInt32(q.Rows[lastRow - 3].Cells[colCount].Value);
                        int val4 = Convert.ToInt32(q.Rows[lastRow - 4].Cells[colCount].Value);
                        int CheckValue = Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value);
                        int cbCount = 3;
                        if ((val1 >= 0 && val2 >= 0 && val3 >= 0 && val4 >= 0) ||
                            (val1 <= 0 && val2 <= 0 && val3 <= 0 && val4 <= 0))
                        {
                            int Total = val1 + val2 + val3;

                            for (int i = 4; i <= lastRow; i++)
                            {
                                if ((val1 >= 0 && val2 > 0) && Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value) > 0)
                                {
                                    cbCount++;
                                    Total += Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value);
                                }
                                else { break; }
                            }

                            for (int i = 4; i <= lastRow; i++)
                            {
                                if ((val1 <= 0 && val2 < 0) && Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value) < 0)
                                {
                                    cbCount++;
                                    Total += Convert.ToInt32(q.Rows[lastRow - i].Cells[colCount].Value);
                                }
                                else { break; }
                            }
                            if ((val1 > 0 && CheckValue < 0) || (val1 < 0 && CheckValue > 0))
                            {
                                p.Rows[2].Cells[col].Value = dg_majorData.Columns[colCount].HeaderText + "(" + cbCount + ")";
                                p.Rows[2].Cells[col].ToolTipText = Total.ToString();
                                p.Rows[2].Cells[col].Style.BackColor = (val1 >= 0 && val2 > 0) ? Color.OrangeRed : Color.LightGreen;
                                col++;
                            }
                        }
                        if (col == 5) { break; }
                    }
                }
            }

            //S3
            col = 1;
            if (TotalRowCount >= 4)
            {
                for (int colCount = 1; colCount <= 20; colCount++)
                {
                    int val1 = Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value);
                    int val2 = Convert.ToInt32(q.Rows[lastRow - 1].Cells[colCount].Value);
                    int val3 = Convert.ToInt32(q.Rows[lastRow - 2].Cells[colCount].Value);
                    int valMain = Convert.ToInt32(q.Rows[lastRow - 3].Cells[colCount].Value);
                    int valMain2 = 0;
                    if (TotalRowCount >= 6)
                    {
                        valMain2 = Convert.ToInt32(q.Rows[lastRow - 4].Cells[colCount].Value);
                    }

                    if ((valMain > 0 && (val1 <= 0 && val2 <= 0 && val3 <= 0)) ||
                         (valMain < 0 && (val1 >= 0 && val2 >= 0 && val3 >= 0)))
                    {
                        q.Rows[lastRow].Cells[colCount].Style.Font = util.GetFont(10);
                        q.Rows[lastRow - 1].Cells[colCount].Style.Font = util.GetFont(10);
                        q.Rows[lastRow - 2].Cells[colCount].Style.Font = util.GetFont(10);
                        q.Rows[lastRow - 3].Cells[colCount].Style.Font = util.GetFont(10);

                        q.Columns[colCount].HeaderCell.Style.Font = util.GetFont(9);
                        q.Columns[colCount].HeaderCell.ToolTipText = "Check chart Possible S3";

                        int aval1 = Math.Abs(val1);
                        int aval2 = Math.Abs(val2);
                        int aval3 = Math.Abs(val3);
                        int avalMain = Math.Abs(valMain);
                        int avalMain2 = Math.Abs(valMain2);

                        if ((avalMain < (aval1 + aval2 + aval3 + (avalMain / 10)) && avalMain > (aval1 + aval2 + aval3 - (avalMain / 10)))
                            || (((valMain > 0 && valMain2 > 0) || (valMain < 0 && valMain2 < 0)) &&
                                (avalMain + avalMain2) < (aval1 + aval2 + aval3 + (avalMain / 10)) && (avalMain + avalMain2) > (aval1 + aval2 + aval3 - (avalMain / 10))))
                        {
                            p.Rows[3].Cells[col].Value = q.Columns[colCount].HeaderText;
                            p.Rows[3].Cells[col].Style.BackColor = (valMain < 0) ? Color.OrangeRed : Color.LightGreen;
                            col++;
                        }
                    }
                    if (col == 5) { break; }
                }
            }
            for (int i = 0; i <= dg_pattern.RowCount - 1; i++)
            {
                p.Rows[i].Cells[0].Style.Font = util.GetFont(17);
                p.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
            }

            //DeadCat
            col = 1;
            for (int colCount = 1; colCount <= 20; colCount++)
            {
                int lastValue = Math.Abs(Convert.ToInt32(q.Rows[lastRow].Cells[colCount].Value));
                int previousValue = Convert.ToInt32(q.Rows[PreviousRow].Cells[colCount].Value);
                if (lastValue <= 20 && Math.Abs(previousValue) >= 80)
                {
                    p.Rows[4].Cells[col].Value = q.Columns[colCount].HeaderText;
                    p.Rows[4].Cells[col].Style.BackColor = previousValue < 0 ? Color.OrangeRed : Color.LightGreen;
                    col++;
                }
                if (col == 5) { break; }
            }

            //Align center
            for (int row = 0; row < dg_pattern.Rows.Count; row++)
                for (int col1 = 1; col1 < dg_pattern.Columns.Count; col1++)
                    dg_pattern.Rows[row].Cells[col1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            p.Columns[0].Width = 70;
            p.ReadOnly = true;
        }
        private void CalculateSummeryTableMinor(int showCount = 0)
        {
            DataTable dt = new DataTable();
            var s = dg_summeryData;
            dt.Columns.Add("Date");
            dt.Columns.Add("CHF");
            dt.Columns.Add("SGD");
            dt.Columns.Add("SPX");
            dt.Columns.Add("WTI");
            dt.Columns.Add("GLD");
            s.ReadOnly = true;
            int startvalue = showCount == 0 ? 0 : dg_majorData.Rows.Count - showCount;
            for (int row = startvalue; row < dg_majorData.Rows.Count; row++)
            {
                DataGridViewRow dvRow = dg_majorData.Rows[row];
                string headerText = dvRow.Cells[0].Value.ToString();
                if (headerText != "")
                {
                    int CHF = 0, SGD = 0;
                    for (int col = 3; col <= 7; col++)
                        CHF += GetVal(dvRow, col);
                    CHF -= GetVal(dvRow, 8);

                    for (int col = 9; col <= 14; col++)
                        SGD += GetVal(dvRow, col);

                    dt.Rows.Add(headerText, CHF * -1, SGD * -1, GetVal(dvRow, 17), GetVal(dvRow, 18), GetVal(dvRow, 20));
                }
            }
            string sumAll = "Total,";
            for (int i = 1; i <= dt.Columns.Count - 1; i++)
            {
                int sumValue = 0;
                for (int row = 0; row <= dt.Rows.Count - 1; row++)
                    sumValue += Convert.ToInt32(dt.Rows[row][i]);
                sumAll += sumValue + ",";
            }
            dt.Rows.Add(sumAll.Trim(',').Split(','));

            s.DataSource = dt;
            s.Columns[0].Width = 65;
            int rowTot = s.RowCount - 1;
            s.Rows[rowTot].Cells[0].Style.Font = util.GetFont(11);

            for (int i = 1; i <= dt.Columns.Count - 1; i++)
            {
                s.Columns[i].Width = 54;
                s.Rows[rowTot].Cells[i].Style.Font = util.GetFont(11);
            }

            s.FirstDisplayedScrollingRowIndex = rowTot;
            lblSummary.Text = "Summery(" + dg_majorData.Rows.Count.ToString() + ")";
            txtCountDays.Text = rowTot.ToString();
            PaintColor(dg_summeryData);
        }
        private void CalculateSummeryTable(int showCount = 0)
        {
            DataTable result = new DataTable();
            var s = dg_summeryData;
            string[] cur = { "Date", "EUR", "GBP", "AUD", "NZD", "USD", "CAD", "JPY" };
            for (int ic = 0; ic < cur.Length; ic++)
                result.Columns.Add(cur[ic]);
            s.ReadOnly = true;
            int startvalue = (showCount == 0 || dg_majorData.Rows.Count <= showCount) ? 0 : dg_majorData.Rows.Count - showCount;
            for (int row = startvalue; row < dg_majorData.Rows.Count; row++)
            {
                DataGridViewRow dr = dg_majorData.Rows[row];
                string headerText = dr.Cells[0].Value.ToString();
                if (headerText != "")
                {
                    int eur = 0, gbp = 0, aud, nzd, usd, cad, jpy;
                    for (int col = 1; col <= 6; col++)
                        eur += GetVal(dr, col);

                    for (int col = 7; col <= 11; col++)
                        gbp += GetVal(dr, col);

                    gbp -= GetVal(dr, 1);
                    aud = GetVal(dr, 12) + GetVal(dr, 13) + GetVal(dr, 14) - GetVal(dr, 2) - GetVal(dr, 7);
                    nzd = GetVal(dr, 15) + GetVal(dr, 16) + GetVal(dr, 17) - GetVal(dr, 3) - GetVal(dr, 8);
                    usd = GetVal(dr, 18) + GetVal(dr, 20) - GetVal(dr, 5) - GetVal(dr, 10) - GetVal(dr, 12) - GetVal(dr, 15);
                    cad = GetVal(dr, 19) - GetVal(dr, 18) - GetVal(dr, 17) - GetVal(dr, 9) - GetVal(dr, 4) - GetVal(dr, 14);
                    jpy = -GetVal(dr, 19) - GetVal(dr, 6) - GetVal(dr, 11) - GetVal(dr, 13) - GetVal(dr, 16);

                    result.Rows.Add(headerText, eur, gbp, aud, nzd, usd, cad, jpy);
                }
            }

            string sumAll = "Total,";
            for (int i = 1; i <= 7; i++)
            {
                int sumValue = 0;
                for (int row = 0; row <= result.Rows.Count - 1; row++)
                    sumValue += Convert.ToInt32(result.Rows[row][i]);
                sumAll += sumValue + ",";
            }
            result.Rows.Add(sumAll.Trim(',').Split(','));

            s.DataSource = result;
            int rowTot = s.RowCount - 1;
            s.Columns[0].Width = 60;
            s.Rows[rowTot].Cells[0].Style.Font = util.GetFont(11);

            for (int i = 1; i <= 7; i++)
            {
                s.Columns[i].Width = 54;
                s.Rows[rowTot].Cells[i].Style.Font = util.GetFont(11);
            }
            s.FirstDisplayedScrollingRowIndex = rowTot;
            lblSummary.Text = "Summery(" + dg_majorData.Rows.Count.ToString() + ")";
            txtCountDays.Text = rowTot.ToString();

            PaintColor(dg_summeryData);
            if (rdo_WeekData.Checked)
            {
                HighlightLowandHigh(dg_summeryData, true);
                HighlightLowandHigh(dg_majorDataTotal, false);
            }
        }
        private void HighlightLowandHigh(DataGridView dg, bool isSummery)
        {
            DataGridViewRow dr = dg.Rows[dg.RowCount - 1];
            int[] values = new int[dr.Cells.Count - 1];
            for (int i = 1; i < dr.Cells.Count; i++)
                values[i - 1] = Convert.ToInt16(dr.Cells[i].Value);
            if (!isSummery)
                dg = dg_majorData;

            for (int i = 0; i < dg.Columns.Count - 1; i++)
                dg.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;

            dg.EnableHeadersVisualStyles = false;
            var cBack = dg.Columns[values.ToList().IndexOf(values.Max()) + 1].HeaderCell.Style;
            cBack.BackColor = Color.Red;
            cBack.ForeColor = Color.White;
            var cBack2 = dg.Columns[values.ToList().IndexOf(values.Min()) + 1].HeaderCell.Style;
            cBack2.BackColor = Color.Green;
            cBack2.ForeColor = Color.White;
        }
        private int GetVal(DataGridViewRow dv, int id)
        {
            return Convert.ToInt16(dv.Cells[id].Value);
        }
        private List<PossibleSignal> GetActivePS(TimeFrame tf)
        {
            return posSignal.FindAll(t => t.TimeFrame == tf && t.IsActive == "1");
        }
        private void HighlightWeekleyOption()
        {
            dg_majorData.EnableHeadersVisualStyles = false;
            foreach (PossibleSignal ts in GetActivePS(TimeFrame.Week))
            {
                for (int colCount = 1; colCount <= dg_majorData.Columns.Count - 1; colCount++)
                {
                    var dg = dg_majorData.Columns[colCount];
                    if (dg.HeaderText == ts.Pair.Substring(0, 6))
                    {
                        dg.HeaderCell.Style.BackColor = ts.Action == ForexAction.Sell ? Color.Red : Color.Green;
                        break;
                    }
                }
            }
        }
        private void PaintColor(DataGridView dg)
        {
            for (int row = 0; row < dg.Rows.Count; row++)
                for (int col = 1; col < dg.Columns.Count; col++)
                    if (dg.Rows[row].Cells[col].Value != null)
                    {
                        dg.Rows[row].Cells[col].Style.BackColor = GetVal(dg.Rows[row], col) < 0 ? Color.LightSalmon : Color.LightGreen;
                        dg.Rows[row].Cells[col].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
        }
        private void LoadListHeader()
        {
            Text = Utilities.AppName;
            var w = lstNews.Columns;
            w.Add("UK-Time", 80, HorizontalAlignment.Left);
            w.Add("Priority", 80, HorizontalAlignment.Left);
            w.Add("Country", 80, HorizontalAlignment.Left);
            w.Add("Short Details", 400, HorizontalAlignment.Left);
            SetGridProperty(lstNews);

            w = lstSingleBar.Columns;
            w.Add("Pair", 100, HorizontalAlignment.Left);
            w.Add("TimeFrame", 100, HorizontalAlignment.Left);
            SetGridProperty(lstSingleBar);

            w = lstSeasonal.Columns;
            w.Add("Pair", 65, HorizontalAlignment.Left);
            w.Add(util.MonthName(), 50, HorizontalAlignment.Left);
            w.Add(util.MonthName(1), 50, HorizontalAlignment.Left);
            w.Add(util.MonthName(2), 50, HorizontalAlignment.Left);
            lstSeasonal.View = View.Details;
            lstSeasonal.FullRowSelect = false;
            lstSeasonal.GridLines = true;

            w = lst_youtube.Columns;
            w.Add("Type", 90, HorizontalAlignment.Left);
            w.Add("Title", 200, HorizontalAlignment.Left);
            w.Add("Video Link", 400, HorizontalAlignment.Left);
            SetGridProperty(lst_youtube);

            grp_Signal.Visible = true;
        }
        private void SetGridProperty(ListView lv)
        {
            lv.View = View.Details;
            util.ColorListViewHeader(ref lv, Color.LightGray, Color.Black);
            lv.FullRowSelect = true;
            lv.GridLines = true;
        }
        private void TimeUK_Tick(object sender, EventArgs e)
        {
            lblTime2.Text = "UK - " + util.Getime(TimeZone.GMT_Standard_Time)
                            + "  US - " + util.Getime(TimeZone.US_Eastern_Standard_Time)
                            + "  IND - " + util.Getime(TimeZone.India_Standard_Time);
            lbl_HighNewslist.Visible = !(lbl_HighNewslist.Visible && IsNFPToday);
        }
        private void SetFirstHeaderColor(MarketData md)
        {
            Color col = md.ToString().Contains('D') ? Color.Magenta : Color.Yellow;
            for (int rowcount = 0; rowcount <= dg_majorData.RowCount - 1; rowcount++)
                dg_majorData.Rows[rowcount].Cells[0].Style.BackColor = col;

            for (int rowcount = 0; rowcount <= dg_summeryData.RowCount - 1; rowcount++)
                dg_summeryData.Rows[rowcount].Cells[0].Style.BackColor = col;
        }
        private void Btn_SaveCalculate_Click(object sender, EventArgs e)
        {
            if (rdo_DayData.Checked || rdo_WeekData.Checked)
                CalculateSummeryTable();
            else
                CalculateSummeryTableMinor();
            IdentifyPattern();
            PaintGrid();
            SavePattern();
            CalculateMajorTotal();
        }
        private void CalculateMajorTotal()
        {
            var q = dg_majorDataTotal;
            q.DataSource = db.GetMarketDataTotal(GetMD());
            q.Columns[0].Width = 65;
            q.Rows[0].Cells[0].Style.Font = util.GetFont(11);
            for (int i = 1; i <= 20; i++)
            {
                q.Rows[0].Cells[i].Style.Font = util.GetFont(11);
                q.Columns[i].Width = 56;
            }
            PaintColor(q);
            q.ReadOnly = true;
            q.AllowUserToResizeColumns = false;
        }
        private void SavePattern()
        {
            string curType = (rdo_DayData.Checked || rdo_WeekData.Checked) ? "Major" : "Minor";
            string tframe = (rdo_DayData.Checked || rad_MinDay.Checked) ? "d" : (rdo_WeekData.Checked || rad_MinWeek.Checked) ? "w" : "";

            string[] patterns = new string[] { "", "", "", "" };
            for (int col1 = 1; col1 < dg_pattern.Columns.Count; col1++)
            {
                for (int pid = 0; pid <= 3; pid++)
                {
                    var tval = dg_pattern.Rows[pid].Cells[col1];
                    if (tval.Value.ToString() != "")
                    {
                        patterns[pid] += (tval.Style.BackColor == Color.LightGreen) ?
                           "(b)" : (tval.Style.BackColor == Color.OrangeRed) ? "(s)" : "";
                        patterns[pid] += dg_pattern.Rows[pid].Cells[col1].Value.ToString() + "-";
                    }
                }
            }
            string date = dg_summeryData.Rows[dg_summeryData.Rows.Count - 2].Cells[0].Value.ToString();
            if (db.InsertPattern(date, patterns, tframe, curType) == false)
            {
                util.ShowMessage("Already Pattern exists please change in Day Pattern screen.");
            }
            else
            {
                util.ShowMessage("Pattern Saved.");
            }
        }
        private void Dg_pattern_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_pattern.CurrentCell != null)
            {
                string curPair = dg_pattern.CurrentCell.Value.ToString();
                if (curPair.Length >= 4)
                {
                    string color = dg_pattern.CurrentCell.Style.BackColor.Name.ToString();
                    ForexAction strAction = (color == "LightGreen") ? ForexAction.Buy : ForexAction.Sell;
                    TimeFrame tFrame = (rdo_DayData.Checked == true || rad_MinDay.Checked == true) ? TimeFrame.Day : TimeFrame.Week;
                    ChartPattern pattern = util.CovertPattern(dg_pattern.Rows[dg_pattern.CurrentCell.RowIndex].Cells[0].Value.ToString());

                    frmConfimDialog frm = new frmConfimDialog
                    {
                        newPOS = new PossibleSignal(tFrame, curPair, pattern, strAction, DateTime.Now.ToString("dd-MMM"), "1", loginDetail.DisplayName)
                    };
                    frm.ShowDialog();
                }
            }
        }
        private void Dg_majorData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dg_majorData.CurrentCell.ColumnIndex != 1) //Desired Column
            {
                if (e.Control is TextBox tb)
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ln = (LinkLabel)sender;
            OpenLink(Convert.ToInt16(ln.Text.Substring(0, 1)));
        }
        private void OpenLink(int lineID)
        {
            string[] lines = db.GetWebSitesAll().Split(',');
            Process.Start(new ProcessStartInfo(lines[lineID - 1]) { UseShellExecute = true });
        }
        private void LblHeading_Click(object sender, EventArgs e)
        {
            SetupView();
            grp_Signal.Visible = true;
            SetSingleTB();
        }
        private void Pic_logo_Click(object sender, EventArgs e)
        {
            SetupView();
            SetupMarketDate();
        }
        private void Lst_youtube_DoubleClick(object sender, EventArgs e)
        {
            string url = lst_youtube.SelectedItems[0].SubItems[2].Text;
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        private void Rad_YouTubeClick(object sender, EventArgs e)
        {
            
            LoadYoutubeVideos(VideoType.All);
        }
        private void ChkNewsAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadTodayNews(chkNewsAll.Checked ? ENewsPriority.ALL : ENewsPriority.HIGH);
        }
        private void LnkTick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTickList frmtick = new frmTickList();
            frmtick.ShowDialog();
        }
        private void FrmDashboard_Closing(object sender, FormClosingEventArgs e)
        {
            if (db.AnyTickNotComplete(DateTime.Now.ToString(Utilities.DateFormat)) == true)
            {
                if (util.ShowQuestion("All the option not Ticked, Do you want Quit Application?") == DialogResult.OK)
                    db.InsertEvents(new LoginEvents(DateTime.Now.ToString(), "Logged Out User", loginDetail.DisplayName));
                else
                    e.Cancel = true;
            }
        }
        private void Dg_majorData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dg_majorData;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdateMData(GetMD(), rowHeader, colHeader, val);
                }
            }
        }
        private MarketData GetMD()
        {
            return rdo_WeekData.Checked ? MarketData.MajWeek :
                 rdo_DayData.Checked ? MarketData.MajDay :
                rad_MinDay.Checked ? MarketData.MinDay : MarketData.MinWeek;
        }
        private void RadMajorDay(object sender, EventArgs e)
        {
            if (rdo_DayData.Checked == true)
            {
                SetColorandLabel(MarketData.MajDay);
                lblGeneral.Text = "Major Day Movements";
                showResults(20);
                radOne.Checked = true;
            }
        }
        private void RdoMajorWeek(object sender, EventArgs e)
        {
            if (rdo_WeekData.Checked == true)
            {
                SetColorandLabel(MarketData.MajWeek);
                lblGeneral.Text = "Major Week Movements";
                showResults(8);
                rad2M.Checked = true;
            }
        }
        private void RdoMinorDay(object sender, EventArgs e)
        {
            if (rad_MinDay.Checked == true)
            {
                SetColorandLabel(MarketData.MinDay);
                lblGeneral.Text = "Minor Day Movements";
            }
        }
        private void RadMinorWeek(object sender, EventArgs e)
        {
            if (rad_MinWeek.Checked == true)
            {
                SetColorandLabel(MarketData.MinWeek);
                lblGeneral.Text = "Minor Week Movements";
            }
        }
        private void SetColorandLabel(MarketData md)
        {
            LoadMarketDataDB(md);
            lblGeneral.ForeColor = btn_SaveCalculate.BackColor = Color.DarkCyan;

            if (md == MarketData.MajWeek || md == MarketData.MajDay)
                CalculateSummeryTable();
            else
                CalculateSummeryTableMinor();

            PaintGrid();
            HighlightWeekleyOption();
            btn_SaveCalculate.Text = "Show Pattern";
            dg_summeryData.Visible = true;
            lblPatternGrid.BackColor = lblSummary.BackColor = btn_SaveCalculate.BackColor;
            IdentifyPattern();
        }
        private void PaintGrid()
        {
            PaintColor(dg_majorData);
            SetFirstHeaderColor(GetMD());
        }
        private void Pic_YoutubeClick(object sender, EventArgs e)
        {
            SetupView();
            grp_Youtube.Visible = true;
            LoadYoutubeVideos(VideoType.All);
        
        }
        private void Pic_NewsClick(object sender, EventArgs e)
        {
            frmNews frm9 = new frmNews();
            frm9.ShowDialog();
        }

        private void Pic_CLclick(object sender, EventArgs e)
        {
            SetupView();
            grp_Signal.Visible = true;
            frmCheckList frm = new frmCheckList();
            frm.ShowDialog();
        }
        private void Pic_ClockClick(object sender, EventArgs e)
        {
            Form fpopup = new frmTimesheet();
            fpopup.ShowDialog();
        }
        private void Pic_RefreshClick(object sender, EventArgs e)
        {
            ShowTradeIdeas();
        }
        private void LstSingleBar_MouseClick(object sender, MouseEventArgs e)
        {
            frmConfimDialog frm = new frmConfimDialog();
            var si = lstSingleBar.FocusedItem.SubItems;
            frm.newPOS = new PossibleSignal(TimeFrame.Week, si[0].Text, ChartPattern.SingleTestBar, ForexAction.Buy, DateTime.Now.ToString("dd-MMM"), "1", loginDetail.DisplayName);
            frm.ShowDialog();
        }
        private void Dg_majorData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSum(dg_majorData);
        }
        private void GetSum(DataGridView dg)
        {
            try
            {
                float sumNumbers = 0;
                for (int i = 0; i < dg.SelectedCells.Count; i++)
                {
                    if (float.TryParse(dg.SelectedCells[i].FormattedValue.ToString(), out float nextNumber))
                        sumNumbers += nextNumber;
                }
                lblSelTotal.Text = "Total: " + sumNumbers.ToString() + "(" + dg.SelectedCells.Count.ToString() + ")";
                lblSelTotal.ForeColor = sumNumbers <= 0 ? Color.Red : Color.Green;
            }
            catch (Exception) { util.ShowMessage("select single Row or Column"); }
        }
        private void Dg_summeryData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSum(dg_summeryData);
        }
        private void LnkFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpChart.Visible = true;
            ShowChart("EUR", false);
        }
        private void TxtCountDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtCountDays.Text, out int showCount) == true)
                {
                    showResults(showCount);
                }
                else
                {
                    txtCountDays.Text = dg_summeryData.Rows.Count.ToString();
                }
            }
        }
        private void showResults(int showCount)
        {
            if (rdo_DayData.Checked || rdo_WeekData.Checked)
                CalculateSummeryTable(showCount);
            else
                CalculateSummeryTableMinor(showCount);
        }
        private void ShowChart(string currencyCode, bool isPair)
        {
            grpChart.Visible = true;
            c1.ChartAreas.Clear();
            c1.Series.Clear();
            WindowState = FormWindowState.Maximized;
            Controls.Remove(c1);
            c1.Size = new Size(1300, 900);
            grpChart.Size = new Size(1350, 950);
            grpChart.Left = grpChart.Top = c1.Left = 10;
            c1.Top = 50;
            lblChartTitle.Text = (rdo_DayData.Checked ? "Day" : "Week") + " - " + currencyCode;
            //Series 1
            c1.ChartAreas.Add(new ChartArea("First"));
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Count");
            DataRow dr;
            var dgrid = isPair ? dg_majorData : dg_summeryData;
            int recordCount = isPair ? dg_majorData.Rows.Count : dg_summeryData.Rows.Count - 1;
            for (int i = 0; i < recordCount; i++)
            {
                dr = dt1.NewRow();
                dr["Count"] = dgrid.Rows[i].Cells[currencyCode].Value.ToString();
                dt1.Rows.Add(dr);
            }
            c1.DataBindTable(dt1.DefaultView, "Count");
            c1.Series[0].ChartType = SeriesChartType.RangeColumn;
            c1.Series[0].IsValueShownAsLabel = true;
            c1.Series[0].LabelForeColor = Color.Yellow;

            foreach (DataPoint pt in c1.Series[0].Points)
                pt.Color = (pt.YValues[0] >= 0) ? Color.Green : Color.Red;

            c1.ChartAreas[0].AxisX.MajorGrid.LineWidth = c1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            grpChart.Controls.Add(c1);
        }
        private void LnkCharClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpChart.Visible = false;
        }
        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            ShowChart((sender as RadioButton).Text, false);
        }
        private void TxtChartPair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ShowChart(txtChartPair.Text, true);
        }
        private void chkSesonalAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadSeasonal(chkSesonalAll.Checked);
        }
        private void radCount_CheckedChanged(object sender, EventArgs e)
        {
            int showCount = 0;
            if (rdo_DayData.Checked == true || rad_MinDay.Checked == true)
                showCount = radOne.Checked ? 20 : rad2M.Checked ? 40 : dg_summeryData.RowCount;

            if (rdo_WeekData.Checked == true || rad_MinWeek.Checked == true)
                showCount = radOne.Checked ? 4 : rad2M.Checked ? 8 : dg_summeryData.RowCount;

            showResults(showCount);
        }

        private void dgTradeOption_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dgTradeOption;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    val = colHeader != "Technical" ? val.ToUpper() : val;
                    db.UpdateTradeOption(rowHeader, colHeader, val);
                }
            }
        }
        private void SetScrollValue()
        {
            lblWeekList.Text = db.GetScrollValue() + "                         ";
        }
        private void timeScrollText_Tick(object sender, EventArgs e)
        {
            lblWeekList.Text = lblWeekList.Text.Substring(1, lblWeekList.Text.Length - 1) + lblWeekList.Text.Substring(0, 1);
        }

        private void cmbVideos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkAddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            }
    }
}


