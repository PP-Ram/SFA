using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace MasterSignal
{
    public partial class frmPayment : Form
    {
        DataObject db;
        readonly Utilities util = new Utilities();
        public frmPayment()
        {
            InitializeComponent();
        }
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            SetupPage();
            LoadCombobox();
            LoadHeader(true);
        }
        private void SetupPage()
        {
            db = new DataObject();
            btnAdd.Enabled = MaximizeBox = MinimizeBox = false;
            Text = Utilities.AppName;
            dgInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Top = Left = 50;
        }
        private void LoadHeader(bool isHeader)
        {
            dgInvoice.DataSource = isHeader ? db.GetPHheader() : db.GetPHheaderItem();
            int strSearchVal = isHeader ? 0 : 1;
            if (dgInvoice.Rows.Count >= 1)
            {
                dgInvoice.Rows[0].Selected = true;
                ShowItemGrid(dgInvoice.Rows[0].Cells[0].Value.ToString(), isHeader);
            }
            if (strSearchVal == 0)
            {
                dgInvoice.Columns[0].Width = 40;
                dgInvoice.Columns[1].Width = 180;
                dgInvoice.Columns[2].Width = 140;
                dgInvoice.Columns[3].Width = 70;
                dgInvoice.Columns[4].Width = 80;
                dgInvoice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                lblMainTotal.Text = "Total - " + dgInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString("#,##.00");
            }
            lblInvoiceType.Visible = cboInvoiceType.Visible = isHeader;
        }
        private void ShowItemGrid(string selID, bool isHeader)
        {
            dgItem.DataSource = isHeader ? db.GetPHdetails(selID) : db.GetPHItemdetails(selID);
            dgItem.Columns[0].Visible = false;
            dgItem.Columns[1].Width = 200;
            dgItem.Columns[2].Width = dgItem.Columns[3].Width = 75;
            dgItem.Columns[4].DefaultCellStyle.Alignment = dgItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            int fno = isHeader ? 3 : 4;
            int sno = fno + 1;
            lblSubTotal.Text = "Total - " + dgItem.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[fno].Value)).ToString()
                + " INR: " + dgItem.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[sno].Value)).ToString("#,##.00");
        }
        private void RdoInvoiceItem_CheckedChanged(object sender, EventArgs e)
        {
            LoadHeader(!rdoInvoiceItem.Checked);
        }
        private void LoadCombobox()
        {
            var c = cmbAccounts;
            c.SelectedIndexChanged -= new EventHandler(CmbAccounts_SelectedIndexChanged);
            cboInvoiceType.SelectedIndexChanged -= new EventHandler(cboInvoiceType_SelectedIndexChanged);

            c.Items.Clear();
            DataRow[] rows = db.GetAccCodeAll().Select("Commission='1'");
            for (int i = 0; i < rows.Length; i++)
                c.Items.Add(rows[i]["TradeAccount"].ToString());

            c.SelectedIndex = 0;
            LoadDisbursements();
            cboInvoiceType.Items.Add("All");
            foreach (DataRow item in db.GetTypes().Rows)
            {
                cboInvoiceType.Items.Add(item[1].ToString());
                cmbType.Items.Add(item[1].ToString());
            }
            cboInvoiceType.SelectedIndex = 0;
            cmbType.SelectedIndex = 1;
            c.SelectedIndexChanged += new EventHandler(CmbAccounts_SelectedIndexChanged);
            cboInvoiceType.SelectedIndexChanged += new EventHandler(cboInvoiceType_SelectedIndexChanged);
        }
        private void LoadDisbursements()
        {
            var q = dgDisbursement;
            q.DataSource = db.GetdisbursementAll(cmbAccounts.Text.Substring(0, 1));
            q.AllowUserToAddRows = q.RowHeadersVisible = false;
            q.Columns[0].Width = 30;
            q.Columns[1].Width = 100;
            q.Columns[2].Width = q.Columns[3].Width = q.Columns[4].Width = 70;

            foreach (DataGridViewRow dr in q.Rows)
            {
                var s = dr.Cells[3].Style;
                s.BackColor = Color.LightGray;
                s.Alignment = dr.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dr.Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtNetamount.Text == "")
            {
                util.ShowMessage("Please calculate the Invoice amount");
            }
            else
            {
                Invoice newInvoice = new Invoice
                {
                    AccId = cmbAccounts.Text.Substring(0, 1),
                    InvoiceCode = "Inv-" + cmbAccounts.Text,
                    TotalAmt = txtAmount.Text,
                    InvDate = daTimeInvoice.Text.ToString(),
                    Type = cmbType.Text,
                    CapitalInterest = txtCaptialinterest.Text,
                    NetAmount = txtNetamount.Text,
                    ExchangeRate = txtErate.Text
                };
                if (Convert.ToInt16(cmbType.Text.Substring(0, 1)) == (int)InvoiceType.MonthlyProfitSplit)
                {
                    foreach (DataGridViewRow dr in dgDisbursement.Rows)
                        newInvoice.invItem.Add(Convert.ToInt32(dr.Cells[0].Value), Convert.ToString(dr.Cells[3].Value));
                }

                db.AddInvoice(newInvoice);
                MessageBox.Show("Invoice Payment withdraw added.", Utilities.AppName);
            }
        }
        private void CmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDisbursements();
        }
        private void LnkCalculate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double netAmt = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtCaptialinterest.Text);
            txtNetamount.Text = netAmt.ToString();
            foreach (DataGridViewRow dr in dgDisbursement.Rows)
            {
                dr.Cells[3].Value = Convert.ToDouble(dr.Cells[2].Value) * netAmt / 100;
                dr.Cells[4].Value = Convert.ToDouble(dr.Cells[3].Value) * Convert.ToDouble(txtErate.Text);
            }
            dgDisbursement.Columns["ActualValue"].DefaultCellStyle.Format = "N3";
            btnAdd.Enabled = true;
        }
        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgDisbursement.Visible = cmbType.Text == "2. Monthly Profit Split";
        }
        private void LnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNetamount.Text = txtCaptialinterest.Text = txtAmount.Text = "0.00";
            LoadDisbursements();
        }
        private void RdoWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            grpHistory.Visible = false;
            grpWidthdraw.Visible = true;
        }
        private void RdoHistory_CheckedChanged(object sender, EventArgs e)
        {
            grpHistory.Visible = true;
            grpWidthdraw.Visible = false;
            LoadHeader(true);
        }
        private void DgInvoice_MouseClick(object sender, MouseEventArgs e)
        {
            string selID = dgInvoice.SelectedRows[0].Cells[0].Value.ToString();
            ShowItemGrid(selID, !rdoInvoiceItem.Checked);
        }
        private void cboInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = dgInvoice.DataSource,
                Filter = cboInvoiceType.Text == "All" ? "1=1" : string.Format("Type='{0}'", cboInvoiceType.Text)
            };

            dgInvoice.DataSource = bs;
        }

        private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgInvoice.SelectedRows.Count == 1)
            {
                if (util.ShowQuestion("Do you want delete the selected payment?") == DialogResult.OK)
                {
                    DataGridViewCellCollection dc = dgInvoice.SelectedRows[0].Cells;
                    db.DeletePayment(dc[0].Value.ToString());
                }
                LoadHeader(true);
            }
        }
    }
}



