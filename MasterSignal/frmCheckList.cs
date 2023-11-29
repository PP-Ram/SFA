using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmCheckList : Form
    {
        public frmCheckList()
        {
            InitializeComponent();
        }
        DataObject db = new DataObject();
        private void FrmRelHistory_Load(object sender, EventArgs e)
        {
            Top = Left = 50;
            ShowGrid(db.GetCLList("Day"));
        }

        private void RadWeek_CheckedChanged(object sender, EventArgs e)
        {
            ShowGrid(db.GetCLList("Week"));
        }

        private void RadMonth_CheckedChanged(object sender, EventArgs e)
        {
            ShowGrid(db.GetCLList("Month"));
        }
        private void RadDay_CheckedChanged(object sender, EventArgs e)
        {
            ShowGrid(db.GetCLList("Day"));
        }
        private void Rad140k_CheckedChanged(object sender, EventArgs e)
        {
            ShowGrid(db.GetCLList("140k"));
            var dg = dgCheckList;
            dg.Columns[1].Width = 300;
            dg.Columns[2].Visible = dg.Columns[3].Visible = false;
            dg.Columns[4].Visible = true;
            dg.Columns[4].Width = 400;
            dg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dg.ReadOnly = false;

            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ShowGrid(DataTable dt)
        {
            var dg = dgCheckList;
            dg.AllowUserToAddRows = dg.RowHeadersVisible = false;
            dg.ReadOnly = true;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.RowTemplate.Resizable = DataGridViewTriState.True;
            dg.RowTemplate.MinimumHeight = 50;
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            dg.Columns[1].Width = 400;
            dg.Columns[2].Width = 100;
            dg.Columns[3].Width = 100;
            dg.Columns[4].Visible = false;
            dg.Columns[2].Visible = dg.Columns[3].Visible = true;

            foreach (DataGridViewColumn c in dg.Columns)
                c.DefaultCellStyle.Font = new Font("Arial", 16, GraphicsUnit.Pixel);
            for (int i = 0; i <= dg.RowCount - 1; i++)
            {
                var dr = dg.Rows[i];
                if (dr.Cells[3].Value.ToString() == "High")
                    dr.Cells[1].Style.BackColor = dr.Cells[2].Style.BackColor = dr.Cells[3].Style.BackColor = Color.LightSalmon;
            }
        }

        private void dgCheckList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dgCheckList;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdateCheckList(rowHeader, colHeader, val);
                }
            }
        }
    }
}
