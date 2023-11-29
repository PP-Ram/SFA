using System;
using System.Linq;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmPaymentHistory : Form
    {
        DataObject db;
        public frmPaymentHistory()
        {
            InitializeComponent();
        }
        private void SetupInit()
        {
            MaximizeBox = MinimizeBox=false;
            Text = Utilities.AppName;
            Top = 50;
            db = new DataObject();
            dgInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FrmPaymentHistory_Load(object sender, EventArgs e)
        {
            SetupInit();
            LoadHeader(true);
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
        }
        private void ShowItemGrid(string selID, bool isHeader)
        {
            dgItem.DataSource = isHeader ? db.GetPHdetails(selID) : db.GetPHItemdetails(selID);
            dgItem.Columns[0].Visible = false;
            dgItem.Columns[1].Width = 200;
            dgItem.Columns[2].Width = dgItem.Columns[3].Width = 75;
            dgItem.Columns[4].DefaultCellStyle.Alignment = dgItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            int fno = isHeader ? 3 : 4;
            int sno = fno + 1 ;
            lblSubTotal.Text = "Total - " + dgItem.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[fno].Value)).ToString()
                + " INR: " + dgItem.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[sno].Value)).ToString("#,##.00");
        }
        private void DgInvoice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selID = dgInvoice.SelectedRows[0].Cells[0].Value.ToString();
            ShowItemGrid(selID, !rdoInvoiceItem.Checked);
        }
        private void RdoInvoiceItem_CheckedChanged(object sender, EventArgs e)
        {
            LoadHeader(!rdoInvoiceItem.Checked);
        }
        private void dgInvoice_MouseClick(object sender, MouseEventArgs e)
        {
            string selID = dgInvoice.SelectedRows[0].Cells[0].Value.ToString();
            ShowItemGrid(selID, !rdoInvoiceItem.Checked);
        }
    }
}
