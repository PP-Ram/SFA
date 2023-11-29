using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmTickList : Form
    {
        DataObject db = new DataObject();
        Utilities util = new Utilities();
        string strDate;
        public frmTickList()
        {
            InitializeComponent();
        }
        private void frmTickList_Load(object sender, EventArgs e)
        {
            SetupScreen();
            LoadTickOption();
        }

        private void SetupScreen()
        {
            Text = Utilities.AppName;
            MinimizeBox = MaximizeBox  =false;
            strDate = DateTime.Now.ToString(Utilities.DateFormat);
            lblTickHeading.Text += strDate;
            btnSave.Enabled = false;
        }

        private void LoadTickOption()
        {
            StringBuilder sb = db.GetTickByDate(strDate, false);
            string[] tempVal = sb.ToString().Split(',');
            if (tempVal.Length > 2)
            {
                lblOne.BackColor = GetColor(tempVal[1]);
                lblTwo.BackColor = GetColor(tempVal[2]);
                lblThree.BackColor = GetColor(tempVal[3]);
                lblFour.BackColor = GetColor(tempVal[4]);
                lblFive.BackColor = GetColor(tempVal[5]);
                lblSix.BackColor = GetColor(tempVal[6]);

                chkOne.Checked = tempVal[1] == "True";
                chkTwo.Checked = tempVal[2] == "True";
                chkThree.Checked = tempVal[3] == "True";
                chkFour.Checked = tempVal[4] == "True";
                chkFive.Checked = tempVal[5] == "True";
                chkSix.Checked = tempVal[6] == "True";
            }
            else
            {
                chkOne.Checked = chkTwo.Checked = chkThree.Checked = chkFour.Checked = chkFive.Checked = chkSix.Checked = false;
                lblOne.BackColor = lblTwo.BackColor = lblThree.BackColor = lblFour.BackColor = lblFive.BackColor = lblSix.BackColor = Color.LightSalmon;
            }
        }

        private void FrmTickList_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            string mainStr = strDate + "," + chkOne.Checked + "," + chkTwo.Checked + "," + chkThree.Checked + "," 
                            + chkFour.Checked + "," + chkFive.Checked + "," + chkSix.Checked;
            db.AddOrUpdateTick(mainStr);
        }

        private void Chk_checked(object sender, EventArgs e)
        {
            ChkOne_CheckedChanged(sender, e);
        }

        private void ChkOne_CheckedChanged(object sender, EventArgs e)
        {
            switch (((CheckBox)sender).Name)
            {
                case "chkOne":
                    lblOne.BackColor = GetColor(chkOne.Checked);
                    break;
                case "chkTwo":
                    lblTwo.BackColor = GetColor(chkTwo.Checked);
                    break;
                case "chkThree":
                    lblThree.BackColor = GetColor(chkThree.Checked);
                    break;
                case "chkFour":
                    lblFour.BackColor = GetColor(chkFour.Checked);
                    break;
                case "chkFive":
                    lblFive.BackColor = GetColor(chkFive.Checked);
                    break;
                case "chkSix":
                    lblSix.BackColor = GetColor(chkSix.Checked);
                    break;
            }
            btnSave.Enabled = (chkOne.Checked && chkTwo.Checked && chkThree.Checked && chkFour.Checked && chkFive.Checked && chkSix.Checked);
        }
        private Color GetColor(object opt)
        {
            return Convert.ToBoolean(opt) ? Color.LightGreen : Color.LightSalmon;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            util.SaveToRepository();
        }
    }
}
