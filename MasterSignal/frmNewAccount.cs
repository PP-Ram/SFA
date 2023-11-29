using System;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmNewAccount : Form
    {
        Utilities util = new Utilities();
        DataObject db;

        public frmNewAccount()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cmbFundingfirm.Items.Add("FTMO");
            cmbFundingfirm.Items.Add("Fidelcrest");
            cmbFundingfirm.Items.Add("Pepperstone");

            cmbStatus.Items.Add("Closed");
            cmbStatus.Items.Add("Running");
            cmbStatus.Items.Add("Pass");
            cmbStatus.Items.Add("Fail");

            cmbPlatform.Items.Add("MT4");
            cmbPlatform.Items.Add("CTrader");

            cmbTrader.Items.Add("Bama");
            cmbTrader.Items.Add("Aruna");
            cmbTrader.Items.Add("Madhavan");
            cmbTrader.Items.Add("Ramesh");
            db = new DataObject();
            ClearAll();
            LoadAccount();
        }

        private void LoadAccount()
        {
            var q = dgAccounts;
            q.RowHeadersVisible = q.AllowUserToAddRows = q.EnableHeadersVisualStyles = false;
            q.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            q.DataSource = db.GetAccountNewAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            Account newAccount = new Account();
            rdoFund.Checked = rdoP1.Checked = rdoUSD.Checked = true;
            cmbFundingfirm.Text = "Fidelcrest";
            txtAccountNo.Text = "";
            txtCapital.Text = "0";
            txtUserName.Text = "";
            txtPassword.Text = "";

            txtProfitshare.Text = "0";
            txtProfitshare.Enabled = false;

            dtpAccopendate.Text = DateTime.Now.ToString();
            dtpAccclosedate.Text = "";
            dtpTradestartdate.Text = "";
            dtpTradeenddate.Text = "";
            txtDLamount.Text = "";
            txtDLpercent.Text = "";
            txtTLpercent.Text = "";
            txtTLamount.Text = "";
            txtTamount.Text = "";
            txtTpercent.Text = "";
            cmbTrader.Text = "Bama";
            txtChallengeFees.Text = "";

           

            txtDetails.Text = "";
            txtCurrencyPair.Text = "";
            txtTradepattern.Text = "0";
            txtTotaltradingdays.Text = "30";
            txtMintradingdays.Text = "10";
            ckNewsTrade.Checked = ckStoporders.Checked = ckWeekendTrade.Checked = false;

            txtMinpositionduration.Text = "10 Sec";
            txtClosingopenpositions.Text = "Friday-09:30PM";
            txtLotsizerange.Text = "0";
            txtActuallotsize.Text = "0";
            cmbPlatform.Text = "MT4";
            cmbStatus.Text = "Running";
            txtWebsite.Text = "www.Fidelcrest.com";
        }
        private void GetAccount(Account newAccount)
        {
            rdoPersonal.Checked = newAccount.AccountType == "Personal";
            rdoFund.Checked = newAccount.AccountType == "Fund";
            rdoP1.Checked = newAccount.ChallengeType == "P1";
            rdoP2.Checked = newAccount.ChallengeType == "P2";
            rdoP3.Checked = newAccount.ChallengeType == "P3";
            rdoUSD.Checked = newAccount.CurrencyType == "USD";
            rdoGBP.Checked = newAccount.CurrencyType == "GBP";
            rdoPersonal.Checked = newAccount.AccountType == "Personal";
            cmbFundingfirm.Text = newAccount.Fundingfirm;
            txtAccountNo.Text = newAccount.Accountno;
            txtCapital.Text = newAccount.Capital;
            txtUserName.Text = newAccount.UserName;
            txtPassword.Text = newAccount.Password;
            txtProfitshare.Text = newAccount.ProfitShare;
            dtpAccopendate.Text = newAccount.Accopendate;
            dtpAccclosedate.Text = newAccount.Accclosedate;
            dtpTradestartdate.Text = newAccount.Tradestartdate;
            dtpTradeenddate.Text = newAccount.Tradeenddate;
            txtDLamount.Text = newAccount.Maxdailylossamt;
            txtTLamount.Text = newAccount.Maxtotallossamt;
            txtTamount.Text = newAccount.Profittargetamt;
            txtDLpercent.Text = newAccount.Maxdailylossper;
            txtTLpercent.Text = newAccount.Maxtotallossper;
            txtTpercent.Text = newAccount.Profittargetper;
            cmbTrader.Text = newAccount.Trader;
            txtChallengeFees.Text = newAccount.Challengefee;
            txtDetails.Text = newAccount.Details;
            txtTradepattern.Text = newAccount.Tradepattern;
            txtCurrencyPair.Text = newAccount.Currencypair;
            txtTotaltradingdays.Text = newAccount.Totaltradingdays;
            txtMintradingdays.Text = newAccount.Mintradingdays;
            ckWeekendTrade.Checked = newAccount.Weekenedtrade == "True";
            ckStoporders.Checked = newAccount.Stoporders == "True";
            ckNewsTrade.Checked = newAccount.Newstrading == "True";
            txtMinpositionduration.Text = newAccount.Minpositionduration;
            txtClosingopenpositions.Text = newAccount.Closingopenpositions;
            txtLotsizerange.Text = newAccount.Lotsizerange;
            txtActuallotsize.Text = newAccount.Actuallotsize;
            cmbPlatform.Text = newAccount.Platform;
            cmbStatus.Text = newAccount.Status;
            txtWebsite.Text = newAccount.Website;
        }

        private Account ReadfromScreen()
        {
            Account newAccount = new Account
            {
                ID = Convert.ToInt32(dgAccounts.SelectedRows[0].Cells[0].Value.ToString()),
                AccountType = rdoPersonal.Checked ? "Personal" : "Fund",
                ChallengeType = rdoP1.Checked ? "P1" : rdoP2.Checked ? "P2" : rdoP3.Checked ? "P3" : "",
                CurrencyType = rdoUSD.Checked ? "usd" : rdoGBP.Checked ? "GBP" : "",
                Fundingfirm = cmbFundingfirm.Text,
                Accountno = txtAccountNo.Text,
                Capital = txtCapital.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                ProfitShare = txtProfitshare.Text,
                Accopendate = dtpAccopendate.Value.ToString(),
                Accclosedate = dtpAccclosedate.Value.ToString(),
                Tradestartdate = dtpTradestartdate.Value.ToString(),
                Tradeenddate = dtpTradeenddate.Value.ToString(),
                Maxdailylossamt = txtDLamount.Text,
                Maxdailylossper = txtDLpercent.Text,
                Maxtotallossamt = txtTLamount.Text,
                Maxtotallossper = txtTLpercent.Text,
                Profittargetamt = txtTamount.Text,
                Profittargetper = txtTpercent.Text,
                Trader = cmbTrader.Text,
                Challengefee = txtChallengeFees.Text,
                Details = txtDetails.Text,
                Tradepattern = txtTradepattern.Text,
                Currencypair = txtCurrencyPair.Text,
                Totaltradingdays = txtTotaltradingdays.Text,
                Mintradingdays = txtMintradingdays.Text,
                Weekenedtrade = ckWeekendTrade.Checked ? "True" : "False",
                Stoporders = ckStoporders.Checked ? "True" : "False",
                Newstrading = ckNewsTrade.Text,
                Minpositionduration = txtMinpositionduration.Text,
                Closingopenpositions = txtClosingopenpositions.Text,
                Lotsizerange = txtLotsizerange.Text,
                Actuallotsize = txtActuallotsize.Text,
                Platform = cmbPlatform.Text,
                Status = cmbStatus.Text,
                Website = txtWebsite.Text,


            };
            return newAccount;
        }

        private void txtTotaldays_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }
        private void NumberOnly(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDLamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);

        }

        private void txtTLamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);

        }

        private void txtTamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txttradedays_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txtDLpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txtTLpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txtTpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(e);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string action = btnAddAccount.Text.Substring(0, 1).ToLower();
            string displayMsg = action == "a" ? "Forex account added sucessfully." : "Forex account updated sucessfully.";
            db.ProcessAccount(ReadfromScreen(), action);
            util.ShowMessage(displayMsg);
            LoadAccount();
        }

        private void grpAccountmanagement_Enter(object sender, EventArgs e)
        {

        }

        private void dgAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAccounts.SelectedRows.Count >= 1)
            {
                string selValue = dgAccounts.SelectedRows[0].Cells[0].Value.ToString();
                Account acc = db.getNewAccountDetails(selValue);
            }
        }

        private void dgAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkBtnAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAll();
            btnAddAccount.Text = "Add New Account";
        }

        private void rdoP1_CheckedChanged(object sender, EventArgs e)
        {
            txtProfitshare.Enabled = rdoP2.Checked || rdoP3.Checked;
        }

        private void dtpAccopendate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
 }

        







