using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace MasterSignal
{
    public partial class frmNews : Form
    {
        public frmNews()
        {
            InitializeComponent();
        }
        DataObject db = new DataObject();
        Utilities util = new Utilities();
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }
        private void dgAllNews_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgAllNews.CurrentCell.ColumnIndex != 1) //Desired Column
            {
                if (e.Control is TextBox tb)
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }
        private void dgAllNews_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dgAllNews;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdateNews(rowHeader, colHeader, val);
                }
            }
        }

        private void frmNews_Load(object sender, EventArgs e)
        {
            
            Top = 0;
            var q = dgCountry;
            q.DataSource = db.GetNewsCount();
            q.RowHeadersVisible = q.AllowUserToAddRows = q.EnableHeadersVisualStyles =  false;
            q.Columns[0].Width = 60;
            q.Columns[1].Width = q.Columns[2].Width = 50;
            q.Columns[1].DefaultCellStyle.Alignment = q.Columns[2].DefaultCellStyle.Alignment
                = DataGridViewContentAlignment.MiddleCenter;
            q.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            q.ReadOnly = true;
            q.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            q.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            q = dgAllNews;
            q.RowTemplate.MinimumHeight = 30;
            q.RowHeadersVisible = q.AllowUserToAddRows = q.EnableHeadersVisualStyles = false;
            q.DataSource = db.GetENewsAll(ENewsPriority.ALL);
            q.Font = new Font("Tahoma", 10);
            q.Columns[0].Visible = false;
            q.Columns[1].Width = 160;
            q.Columns[2].Width = 50;
            q.Columns[3].Width = 65;
            q.Columns[4].Width = 250;
            q.Columns[5].DefaultCellStyle.Alignment =
            q.Columns[6].DefaultCellStyle.Alignment =
            q.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            q.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

           
            setFilter(null, null);
        }

        private void setFilter(string field, string value)
        {

            string rowFilter = (field is null) ? "" : string.Format("{0} = '{1}'", field, value);
            if (field == "Country")
                rowFilter += radHigh.Checked ? "and Priority = 'HIGH'" : radMedium.Checked ? "and Priority = 'MEDIUM'" : "";

            (dgAllNews.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            foreach (DataGridViewRow item in dgAllNews.Rows)
            {
                if (item.Cells[3].Value.ToString().ToLower() == "high")
                    item.DefaultCellStyle.ForeColor = Color.Red;

                if (item.Cells[1].Value.ToString().ToLower().Substring(3, 2) == DateTime.Now.ToString("dd"))
                    item.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            setFilter("Priority", "MEDIUM");
        }

        private void radHigh_CheckedChanged(object sender, EventArgs e)
        {
            setFilter("Priority", "High");
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            setFilter(null, null);
        }

        private void dgCountry_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCountry.SelectedRows.Count >= 1)
            {
                string selValue = dgCountry.SelectedRows[0].Cells[0].Value.ToString();
                if (selValue == "Total")
                {
                    setFilter(null, null);
                    radAll.Checked = true;
                }
                else
                {
                    setFilter("Country", selValue);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            util.SaveToRepository();
        }

        private void lnkLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string nFile = util.GetConfigValue("NewsFile");
            if (File.Exists(nFile))
            {
                StreamReader sr = new StreamReader(nFile);
                sr.ReadLine();
                List<EconomicNews> lstNews = new List<EconomicNews>();
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    lstNews.Add(new EconomicNews(rows[1], rows[2].Replace("'", ""), rows[3], rows[4]));
                }
                if (db.LoadNews(lstNews))
                    util.ShowMessage("Financial news loaded sucessfully " + lstNews.Count.ToString() + " rows");
                frmNews_Load(sender, e);
            }
            else
            {
                util.ShowMessage("Please check the file not exists. " + nFile);
            }
        }

        private void grp_news_Enter(object sender, EventArgs e)
        {

        }
    }
}
