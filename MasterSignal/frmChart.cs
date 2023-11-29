using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterSignal
{
    public partial class frmChart : Form
    {
        public bool isCommAccount = false;
        public bool isNewTrade = false;
        public frmChart()
        {
            InitializeComponent();
        }
        private static readonly DataObject db = new DataObject();
        private static readonly Utilities util = new Utilities();
        private static readonly Chart c1 = new Chart();
        private double valMaster;
        private void frmChart_Load(object sender, EventArgs e)
        {
            dgAccounts.SelectionChanged -= new EventHandler(DgAccounts_SelectionChanged);
            LoadMasterGrid(false);
            SetupGrid();
            LoadComboValues();
            grpTradeDetails.Visible = false;
            Text = Utilities.AppName;
            valMaster = 0;
            dgAccounts.SelectionChanged += new EventHandler(DgAccounts_SelectionChanged);
        }
        private void LoadMasterGrid(bool allAccount)
        {
            //grid Accounts
            DataTable dt = db.GetLiveAccounts();
            var dg = dgAccounts;
            dg.DataSource = allAccount ? dt : dt.Select("Status = 'Running'").CopyToDataTable();
            dg.Columns[0].Visible = false;
            dg.ReadOnly = true;
            dg.EnableHeadersVisualStyles = dg.AllowUserToAddRows = dg.RowHeadersVisible = false;
            dg.Columns[1].Width = 150;
            dg.Columns[2].Width = 50;
            dg.Font = util.GetFont(9);
        }
        private void SetupGrid()
        {
            //Trade summery
            var dg = dgTradeSummery;
            dg.Font = util.GetFontRegular(8);
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dg.EnableHeadersVisualStyles = dg.AllowUserToAddRows = MaximizeBox = MinimizeBox = false;
            //Grid group by date
            dg = dgTradeByDate;
            dg.EnableHeadersVisualStyles = dg.RowHeadersVisible = dg.AllowUserToAddRows = false;
            dg.Font = util.GetFontRegular(8);
            dg.ReadOnly = true;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Grid group by pair
            dg = dgTradeByCurrency;
            dg.EnableHeadersVisualStyles = dg.RowHeadersVisible = dg.AllowUserToAddRows = false;
            dg.Font = util.GetFontRegular(8);
            dg.ReadOnly = true;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadComboValues()
        {
            for (int i = 0; i >= -11; i--)
            {
                comMonth.Items.Add(DateTime.Now.AddMonths(i).ToString("MMMM"));
                cmoNewMonth.Items.Add(DateTime.Now.AddMonths(i).ToString("MMMM"));
            }
            for (int i = 1; i <= 31; i++)
                cmoDate.Items.Add(i);

            foreach (DataRow row in db.GetLiveAccounts().Rows)
                cmoNewAccount.Items.Add(row["TradeAccount"].ToString());

            comMonth.SelectedIndex = cmoNewMonth.SelectedIndex = cmoDate.SelectedIndex = 0;
        }
        private void ShowChart(string accCode, bool isComm)
        {
            c1.ChartAreas.Clear();
            c1.Series.Clear(); 
            c1.Legends.Clear();
            c1.Titles.Clear();
            WindowState = FormWindowState.Maximized;
            Controls.Remove(c1);
            c1.Size = new Size(740, 600);
            c1.Left = 650;
            c1.Top = 110;

            //Series 1
            c1.ChartAreas.Add(new ChartArea("First"));
            DataTable dt1 = new DataTable();
            if (isCommAccount == true)
            {
                DataRow[] dr = db.GetChartData(accCode, "1").Select("TradeMonth ='" + comMonth.Text + "'");
                if (dr.Length >= 1)
                    dt1 = dr.CopyToDataTable();
            }
            else
            {
                dt1 = db.GetChartData(accCode, "1");
            }
            int j = 1;
            for (int i = 0; i < dt1.Rows.Count; i++)
                dt1.Rows[i][1] = j++;
            c1.DataBindTable(dt1.DefaultView, "TradeDay");
            c1.Series[0].ChartType = SeriesChartType.RangeColumn;
            c1.Series[0].IsValueShownAsLabel = true;
            c1.Series[0].LabelForeColor = Color.Yellow;

            foreach (DataPoint pt in c1.Series[0].Points)
                pt.Color = (pt.YValues[0] >= 0) ? Color.Green : Color.Red;

            c1.ChartAreas[0].AxisX.MajorGrid.LineWidth = c1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //Series 2
            DataTable dtMaster = isCommAccount ? db.GetLiveTradeMaster(accCode, comMonth.Text) : db.GetLiveTradeMaster(accCode);
            if (dtMaster.Rows.Count >= 1)
                valMaster = Convert.ToDouble(dtMaster.Rows[0][2]);

            c1.ChartAreas.Add(new ChartArea("Second"));
            double[] Values = new double[dt1.Rows.Count + 1];
            Values[0] = valMaster;
            j = 1;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Values[j] = Values[i] + Convert.ToDouble(dt1.Rows[i][0]);
                j++;
            }
            Series s2 = new Series
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Second",
                BorderWidth = 2
            };
            s2.Points.DataBindY(Values);
            c1.ChartAreas[1].AxisX.MajorGrid.LineWidth = 0;
            c1.ChartAreas[1].AxisY.Interval = 1000;

            c1.ChartAreas[1].AxisY.Maximum = valMaster * 1.2;
            c1.ChartAreas[1].AxisY.Minimum = valMaster - valMaster * .1;
            c1.Titles.Add("Trade Summary - " + DateTime.Now.ToString("MMMM yyyy"));
            c1.Titles[0].Font = util.GetFont(12);
            c1.Series.Add(s2);
            Controls.Add(c1);
        }
        private void LoadMainGrid(string selAccount)
        {
            dgTradeSummery.SelectionChanged -= new EventHandler(DgTradeSummery_SelectionChanged);

            var dg = dgTradeSummery;
            dg.RowTemplate.Height = 20;
            dg.DataSource = isCommAccount ? db.GetLiveTradeAll(selAccount, comMonth.Text) : db.GetLiveTradeAll(selAccount);
            dg.EnableHeadersVisualStyles = false;

            //Grid trade summery
            var s = dg.Columns;
            s[1].Width = 30;
            s[1].HeaderText = "Sno";
            s[2].Width = 55;    //pair
            s[3].Width = 40;    //action
            s[5].HeaderText = "Date";
            s[5].Width = 50;
            s[6].Width = 60;
            s[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg.RowHeadersVisible = s[0].Visible = s[4].Visible = s[7].Visible = s[8].Visible = s[9].Visible = s[10].Visible = s[11].Visible = s[12].Visible = false;
            double totalVal = 0, winVal = 0, lostVal = 0;
            int wincount = 0, lossCount = 0, i = 0;
            int recCount = dg.Rows.Count;
            if (recCount >= 1)
            {
                for (int rn = 0; rn <= recCount - 1; rn++)
                {
                    DataGridViewCellCollection ss = dg.Rows[rn].Cells;
                    ss[5].Value = ss[4].Value.ToString() + "-" + ss[5].Value.ToString().Substring(0, 3);
                    ss[1].Value = ++i;
                    double val = Convert.ToDouble(ss[6].Value);
                    ss[6].Style.BackColor = val == 0 ? Color.White : val > 0 ? Color.LightGreen : Color.Salmon;
                    ss[3].Style.ForeColor = ss[3].Value.ToString().ToLower() == "buy" ? Color.Green : Color.Red;
                    ss[7].ReadOnly = true;
                    ss[7].Style.Format = "C2";
                    totalVal += val;
                    if (val > 0)
                    {
                        wincount++;
                        winVal += val;
                    }
                    else
                    {
                        lossCount++;
                        lostVal += val;
                    }
                }
                dg.FirstDisplayedScrollingRowIndex = dg.RowCount - 1;
                lblTotal.Text = "Total Trades: " + recCount.ToString();
                lblWin.Text = "Win: " + wincount.ToString() + " (" + winVal.ToString("##.##") + ")";
                lblLoss.Text = "Loss: " + lossCount.ToString() + " (" + lostVal.ToString("##.##") + ")";
                try
                {
                    var rc = dg.Rows.Cast<DataGridViewRow>();
                    lblMaxwin.Text = "MaxWin : " + rc.Max(t => util.GetVal(t.Cells[6]));
                    lblMaxloss.Text = "MaxLoss : " + (rc.Any(t => util.GetVal(t.Cells[6]) < 0) ? rc.Where(t => util.GetVal(t.Cells[6]) < 0).Min(t => util.GetVal(t.Cells[6])).ToString() : "");
                    lblMinwin.Text = "MinWin : " + (rc.Any(t => util.GetVal(t.Cells[6]) > 0) ? rc.Where(t => util.GetVal(t.Cells[6]) > 0).Min(t => util.GetVal(t.Cells[6])).ToString() : "");
                    lblMinloss.Text = "MinLoss : " + (rc.Any(t => util.GetVal(t.Cells[6]) < 0) ? rc.Where(t => util.GetVal(t.Cells[6]) < 0).Max(t => util.GetVal(t.Cells[6])).ToString() : "");
                }
                catch (Exception) { }
            }

            //Header Values
            DataTable dt = isCommAccount ? db.GetLiveTradeMaster(selAccount, comMonth.Text) : db.GetLiveTradeMaster(selAccount);
            if (dt.Rows.Count >= 1)
            {
                valMaster = Convert.ToDouble(dt.Rows[0][2]);
                double closeBal = valMaster + totalVal;
                lblOpen.Text = "Open  : " + valMaster;
                lblClose.Text = "Close : " + Math.Round(closeBal, 2);
                lblProfit.ForeColor = closeBal > valMaster ? Color.Green : Color.Red;
                lblProfit.Text = "Profit : " + Math.Round(totalVal, 2);
                string result = dt.Rows[0][9].ToString();
                lblResult.Text = "Result : " + result;
                lblStart.Text = "Start : " + dt.Rows[0][7].ToString();
                lblEnd.Text = "End : " + dt.Rows[0][8].ToString();

                lblResult.BackColor = result == "Pass" ? Color.Green : result == "Fail" ? Color.Red : Color.Yellow;
                lblUserName.Text = "UserName : " + dt.Rows[0][11].ToString();
            }

            //Trade By Date
            dg = dgTradeByDate;
            dg.DataSource = isCommAccount ? db.GetTradeGroupByDate(selAccount, comMonth.Text) : db.GetTradeGroupByDate(selAccount);
            dg.RowTemplate.Height = 20;
            recCount = dg.Rows.Count;
            dg.EnableHeadersVisualStyles = false;
            if (recCount >= 1)
            {
                dg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg.Columns[0].Width = 55;
                dg.Columns[0].Visible = false;
                dg.Columns[1].Width = 50;
                dg.Columns[2].Width = 35;
                dg.Columns[3].Width = 60;
                for (int rn = 0; rn <= recCount - 1; rn++)
                {
                    DataGridViewCellCollection ss = dg.Rows[rn].Cells;
                    double val = Convert.ToDouble(ss[3].Value);
                    ss[3].Style.BackColor = val == 0 ? Color.White : val > 0 ? Color.LightGreen : Color.Salmon;
                }
            }

            //Trade By currency
            dg = dgTradeByCurrency;
            dg.DataSource = isCommAccount ? db.GetTradeGroupByPair(selAccount, comMonth.Text) : db.GetTradeGroupByPair(selAccount);
            recCount = dg.Rows.Count;
            dg.RowTemplate.Height = 20;
            dg.Columns[0].Width = 55;
            dg.Columns[1].Width = 35;
            dg.Columns[2].Width = 60;
            if (recCount >= 1)
            {
                dg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int rn = 0; rn <= recCount - 1; rn++)
                {
                    DataGridViewCellCollection ss = dg.Rows[rn].Cells;
                    double val = Convert.ToDouble(ss[2].Value);
                    ss[2].Style.BackColor = val == 0 ? Color.White : val > 0 ? Color.LightGreen : Color.Salmon;
                }
            }

            dgTradeSummery.SelectionChanged += new EventHandler(DgTradeSummery_SelectionChanged);
        }
        private void BtnAddTrade_click(object sender, EventArgs e)
        {
            if (isNewTrade == true)
            {
                db.InsertTrade(cmoNewAccount.Text, txtPair.Text.ToUpper(), rdoSell.Checked ? "SELL" : "BUY", cmoDate.Text, cmoNewMonth.Text, txtUnits.Text, cmoTradeSize.Text, txtTradeDetail.Text);
                util.ShowMessage("New Trade Created Sucessfully.");
            }
        
            else
            {
                if (dgTradeSummery.SelectedRows.Count == 1)
                {
                    DataGridViewCellCollection dc = dgTradeSummery.SelectedRows[0].Cells;
                    db.UpdateTrade(dc[0].Value.ToString(), cmoNewAccount.Text, txtPair.Text.ToUpper(), rdoSell.Checked ? "SELL" : "BUY", cmoDate.Text, cmoNewMonth.Text, txtUnits.Text, cmoTradeSize.Text, txtTradeDetail.Text);
                    util.ShowMessage("Trade Updated Sucessfully.");
                }
            }
            grpTradeDetails.Visible = false;
            ClearScreen();
            DgAccounts_SelectionChanged(sender, e);
        }
        private void ClearScreen()
        {
            txtTradeDetail.Text = "Time :   Pattern:  Ratio:    ";
            txtPair.Text = "";
            txtUnits.Text = "0.00";
            rdoSell.Checked = true;
            cmoDate.Text = DateTime.Now.ToString("%d");
            cmoNewAccount.SelectedIndex = 1;
            cmoNewMonth.Text = DateTime.Now.ToString("MMM");
        }
        private string selAcc;
        private void DgAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection dc = dgAccounts.SelectedRows[0].Cells;
                isCommAccount = comMonth.Visible = btnShow.Visible = dc[2].Value.ToString() != "0";
                selAcc = dc[1].Value.ToString();
                LoadMainGrid(selAcc);
                ShowChart(selAcc, isCommAccount);
                rdoSummery.Checked= true;
            }
        }
        private void ComMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgAccounts_SelectionChanged(sender, e);
        }
        private void DgTradeSummery_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTradeSummery.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection dc = dgTradeSummery.SelectedRows[0].Cells;
                DataTable dt = db.GetLiveTradeByID(dc[0].Value.ToString());

                cmoNewAccount.Text = dt.Rows[0].ItemArray[1].ToString();
                txtPair.Text = dt.Rows[0].ItemArray[2].ToString();
                rdoSell.Checked = dt.Rows[0].ItemArray[3].ToString().ToLower() == "sell" ? true : false;
                rdoBuy.Checked = !rdoSell.Checked;
                cmoDate.Text = dt.Rows[0].ItemArray[4].ToString();
                cmoNewMonth.Text = dt.Rows[0].ItemArray[5].ToString().Substring(0, 3);
                txtUnits.Text = dt.Rows[0].ItemArray[6].ToString();
                txtTradeDetail.Text = dt.Rows[0].ItemArray[8].ToString();
                cmoTradeSize.Text = dt.Rows[0].ItemArray[13].ToString();
                btnAdd.Text = "Save Update";
                lblHeading.Text = "Update Trade";
                grpTradeDetails.Visible = true;
            }
        }
        private void BtnAddnew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearScreen();
            isNewTrade = grpTradeDetails.Visible = true;
            btnAdd.Text = "Save New";
            lblHeading.Text = "Add New Trade";
            cmoNewAccount.Items.Clear();
            foreach (DataRow row in db.GetLiveAccounts().Rows)
            {
                if (row["status"].ToString() == "Running")
                    cmoNewAccount.Items.Add(row["TradeAccount"].ToString());
            }
            cmoNewAccount.Text = selAcc;
        }
        private void BtnDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgTradeSummery.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection dc = dgTradeSummery.SelectedRows[0].Cells;
                db.DeleteTrade(dc[0].Value.ToString());
                util.ShowMessage("Trade Deleted Sucessfully.");
                DgAccounts_SelectionChanged(sender, e);
            }
        }
        private void BtnShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DgAccounts_SelectionChanged(sender, e);
        }
        private void LnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpTradeDetails.Visible = false;
        }
        private void DgTradeByDate_Click(object sender, EventArgs e)
        {
            string selValue = dgTradeByDate.SelectedRows[0].Cells[1].Value.ToString();
            bool setPosition = false;
            var dg = dgTradeSummery;
            for (int i = 0; i <= dg.RowCount - 1; i++)
            {
                var dr = dg.Rows[i];
                dr.Cells[1].Style.BackColor =
                dr.Cells[2].Style.BackColor = dr.Cells[3].Style.BackColor =
                dr.Cells[4].Style.BackColor = dr.Cells[5].Style.BackColor =
                   dr.Cells[5].Value.ToString() == selValue ? Color.LightGoldenrodYellow : Color.White;

                if (dr.Cells[5].Value.ToString() == selValue && setPosition == false)
                {
                    dg.FirstDisplayedScrollingRowIndex = i;
                    setPosition = true;
                }
            }
        }
        private void DgTradeByCurrency_Click(object sender, EventArgs e)
        {
            string selValue = dgTradeByCurrency.SelectedRows[0].Cells[0].Value.ToString();
            bool setPosition = false;
            var dg = dgTradeSummery;
            for (int i = 0; i <= dg.RowCount - 1; i++)
            {
                var dr = dg.Rows[i];
                dr.Cells[1].Style.BackColor =
                dr.Cells[2].Style.BackColor = dr.Cells[3].Style.BackColor =
                dr.Cells[4].Style.BackColor = dr.Cells[5].Style.BackColor =
                   dr.Cells[2].Value.ToString() == selValue ? Color.LightGoldenrodYellow : Color.White;

                if (dr.Cells[2].Value.ToString() == selValue && setPosition == false)
                {
                    dg.FirstDisplayedScrollingRowIndex = i;
                    setPosition = true;
                }
            }
        }
        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadMasterGrid(chkAll.Checked);
        }
        private void BtnSaveDB_Click(object sender, EventArgs e)
        {
            util.SaveToRepository();
        }
        private void ShowChart(bool isProfit)
        {
            c1.ChartAreas.Clear();
            c1.Series.Clear();
            c1.Legends.Clear();
            c1.Titles.Clear();
            Controls.Remove(c1);
            c1.ChartAreas.Add(new ChartArea("First"));
            c1.DataBindTable(
                isProfit ? db.GetChartProfit(selAcc) : db.GetChartCount(selAcc), "Month");
            c1.ChartAreas[0].AxisX.MajorGrid.LineWidth = c1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            for (int i = 0; i <= 2; i++)
            {
                c1.Series[i].ChartType = SeriesChartType.Column;
                c1.Series[i].IsValueShownAsLabel = true;
                c1.Series[i].LabelForeColor = Color.Black;
                c1.Series[i]["LabelStyle"] = "Bottom";
            }
            c1.Series[0].Color = Color.LightGreen;
            c1.Series[1].Color = Color.LightSalmon;
            c1.Series[2].Color = isProfit ?  Color.LightBlue : Color.Gold ;

            c1.Legends.Add(new Legend("Win"));
            c1.Legends[0].TableStyle = LegendTableStyle.Auto;
            c1.Legends[0].Docking = Docking.Bottom;
            c1.Legends[0].Alignment = StringAlignment.Center;
            c1.Series[0].Legend = "Win";
            c1.Titles.Add(isProfit ? "Chart By Amount" : "Chart By Total Trades");
            c1.Titles[0].Font = util.GetFont(12);

            Controls.Add(c1);
        }
        private void rdo_ReportOption(object sender, EventArgs e)
        {
            if (rdoSummery.Checked)
                ShowChart(selAcc, isCommAccount);
            else 
                ShowChart(rdoAmount.Checked);
        }

        

        }
    }
    

