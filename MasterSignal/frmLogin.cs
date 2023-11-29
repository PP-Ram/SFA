using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmLogin : Form
    {
        Utilities util = new Utilities();
        DataObject db = new DataObject();
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            Reset();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string fileName = util.GetConfigValue("DBFilePath");
            if (File.Exists(fileName))
            {
                if (IsValidUser(txtUserName.Text, txtPassword.Text) == true)
                {
                    db.InsertEvents(new LoginEvents(DateTime.Now.ToString(), "Logged in User", txtUserName.Text));
                    db.SetupInitialDB(txtUserName.Text);
                    this.Hide();
                    frmDashBoard fpopup = new frmDashBoard
                    {
                        loginDetail = db.GetUserDetails(txtUserName.Text)
                    };
                    LoggedInUser.Role = fpopup.loginDetail.RoleType;
                    LoggedInUser.name = txtUserName.Text;

                    if (fpopup.loginDetail.RoleType == RoleType.User)
                        fpopup.loginDetail.RoleType = LoggedInUser.Role = (rdoCusRole.Checked == true) ? RoleType.Customer : RoleType.User;
                    fpopup.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                util.ShowMessage("Please Check, DB file not exists. " + fileName);
                txtUserName.Focus();
            }
        }

        private bool IsValidUser(string uname, string pwd)
        {
            if (db.IsValidUSer(uname, pwd) == true)
            {
                if (db.IsUserActive(uname) == true)
                {
                    return true;
                }
                else
                {
                    util.ShowMessage("Please contact app support, The login details are not active.", "info");
                    return false;
                }
            }
            else
            {
                util.ShowMessage("Please check the Username and Password");
                return false;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (CheckLicence())
            {
                txtUserName.Text = util.GetConfigValue("UserName");
                txtPassword.Text = util.GetConfigValue("Password");
                rdoCusRole.Visible = rdoUserRole.Visible = util.GetConfigValue("Role").ToLower() == "usr";
            }
        }
        private bool CheckLicence()
        {
            return true;
        }

        private void LnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpLogin.Visible = lnkNewUser.Visible = false;
            grpNewUser.Visible = lnkBack.Visible = true;
            Height = 400;
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset();
        }

        protected void Reset()
        {
            grpLogin.Visible = lnkNewUser.Visible = true;
            Height = 320;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Image = new Bitmap(util.GetConfigValue("ImagePath") + "SFA_Logo.png");
            MaximizeBox = MinimizeBox = rdoCusRole.Visible = rdoUserRole.Visible = grpNewUser.Visible = lnkBack.Visible = false;
            Text = Utilities.AppName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearNewuserForm();
        }

        private void clearNewuserForm()
        {
            txtNewUN.Text = "";
            txtNewPass.Text = "";
            txtNewConPass.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            if (validateNewUser() == true)
            {
                string line = txtNewUN.Text + "," + txtNewConPass.Text + "," + txtPhone.Text + "," + txtEmail.Text;
                StreamWriter sw = File.AppendText("FxData/Data/AppUsers.txt");
                sw.WriteLine(line);
                sw.Close();
                util.ShowMessage("User created sucessflly, go to login page the enter app.", "info");
            }
        }
        protected bool validateNewUser()
        {
            if (txtNewConPass.Text != txtNewPass.Text)
            {
                util.ShowMessage("Please check password and confirm password");
                return false;
            }
            if (txtNewUN.Text == "")
            {
                util.ShowMessage("Please enter valid user name");
                return false;
            }
            if (txtNewConPass.Text.Length <= 3)
            {
                util.ShowMessage("Please enter password must be more than 3 letter.");
                return false;
            }
            return true;
        }
    }
}
