using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmConfimDialog : Form
    {
        Utilities util = new Utilities();
        public PossibleSignal newPOS;
        DataObject db = new DataObject();

        public frmConfimDialog()
        {
            InitializeComponent();
        }

        private void frmConfimDialog_Load(object sender, EventArgs e)
        {
            MaximizeBox = MinimizeBox = false;
            Text = Utilities.AppName;
            rdoBuy.Checked = true;
            DisplayScreen();
        }

        private void DisplayScreen()
        {
            lblcp.Text = newPOS.Pair.ToString();
            lbltp.Text = newPOS.TimeFrame.ToString();
            lblac.Text = newPOS.Action.ToString();
            lblac.BackColor = lblac.Text.ToLower() == "sell" ? Color.LightSalmon : Color.LightGreen;
            lblpa.Text = newPOS.Pattern.ToString();

            if (newPOS.Pattern == ChartPattern.DoubleDay || newPOS.Pattern == ChartPattern.SingleTestBar)
            {
                lblac.Visible = false;
                rdoBuy.Visible = rdoSell.Visible = true; 
            }
            else
            {
                lblac.Visible = true;
                rdoBuy.Visible = rdoSell.Visible = false; 
            }
            lblDHead.Text = "Add new " + newPOS.TimeFrame.ToString() + " Pattern";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
