using System.IO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmTradingImages : Form
    {
        private string fileName = "";
        public frmTradingImages()
        {
            InitializeComponent();
        }
        public static DataTable Dtable { get; set; }
        public Utilities util = new Utilities();
        private void LoadImage(string seqNo)
        {
            if (Dtable.Rows.Count >= 1)
            {
                DataRow dr = Dtable.Select("id =" + seqNo)[0];
                lblImageDesc.Text = dr.ItemArray[4].ToString();
                picTrading.Image = new Bitmap(dr.ItemArray[2].ToString() + "\\" + dr.ItemArray[1].ToString());
            }
        }
        readonly DataObject db = new DataObject();
        private void FrmEducation_Load(object sender, EventArgs e)
        {
            Dtable = db.GetTradeImageAll();
            LoadImage("1");
            LoadTreeview();
            grpAdd.Top = 150;
            grpAdd.Left = 300;
            lbltotal.Text = "Total Images: " + Dtable.Rows.Count.ToString();
        }
        private void LoadTreeview()
        {
            TVtradeImage.Nodes.Clear();
            int i = 0;
            foreach (DataRow dr in db.GetImageTypeAll().Rows)
            {
                string pNode = dr["imageType"].ToString();
                DataRow[] dr1 = Dtable.Select("Imagetype= '" + pNode + "'");
                if (dr1.Length > 0)
                {
                    TVtradeImage.Nodes.Add(pNode + " (" + dr1.Length + ")         ");
                    TVtradeImage.Nodes[i].NodeFont = new Font("Arial", 11, FontStyle.Bold);
                    TVtradeImage.Nodes[i].ForeColor = Color.Chocolate;
                    foreach (DataRow cr in dr1)
                        TVtradeImage.Nodes[i].Nodes.Add(cr[0].ToString(), cr[1].ToString());
                    i++;
                }
            }
            TVtradeImage.Nodes[0].Expand();
        }
        private void LnkAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.OK == FileImageDialog.ShowDialog())
            {
                cmpImageType.DataSource = db.GetImageTypeAll();
                cmpImageType.ValueMember = cmpImageType.DisplayMember = "imageType";
                txtDetails.Text = "";
                cmbSource.SelectedIndex = 0;

                lblFileNameVal.Text = FileImageDialog.FileName;
                fileName = FileImageDialog.SafeFileName;
                SetUploadVisible(true);
            }
        }
        private void SetUploadVisible(bool vStatus)
        {
            btnChange.Visible = picTrading.Visible = !vStatus;
            btnIUpload.Visible = grpAdd.Visible = vStatus;
        }
        private void BtnIUpload_Click(object sender, EventArgs e)
        {
            _ = db.InsertImage(fileName, cmpImageType.Text, cmbSource.Text, txtDetails.Text);
            File.Copy(lblFileNameVal.Text, util.GetConfigValue("ImagePath") + fileName);
            util.ShowMessage("Image uploaded sucessfully.");

            Dtable = db.GetTradeImageAll();
            SetUploadVisible(false);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            SetUploadVisible(false);
        }
        private void TVtradeImage_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
                LoadImage(e.Node.Name);
        }
        private void LnkChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TVtradeImage.SelectedNode != null)
            {
                btnChange.Visible = grpAdd.Visible = true;
                btnIUpload.Visible = false;
                cmpImageType.DataSource = db.GetImageTypeAll();
                cmpImageType.ValueMember = cmpImageType.DisplayMember = "imageType";

                DataRow dr = db.GetImageDetails(TVtradeImage.SelectedNode.Name).Rows[0];
                grpAdd.Text = dr[0].ToString();
                lblFileNameVal.Text = dr[1].ToString();
                cmpImageType.SelectedText = dr[3].ToString();
                txtDetails.Text = dr[4].ToString();
                cmbSource.SelectedText = dr[5].ToString();
            }
        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            _ = db.UpdateImage(grpAdd.Text, cmpImageType.Text, cmbSource.Text, txtDetails.Text);
            util.ShowMessage("Image details updated.");
            grpAdd.Visible = false;
        }
    }
}