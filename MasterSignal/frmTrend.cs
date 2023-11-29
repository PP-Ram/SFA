 using System.Windows.Forms;
using System.Drawing;
using System;

namespace MasterSignal
{
    public partial class frmTrend : Form
    {
        readonly Utilities util = new Utilities();
        readonly DataObject db = new DataObject();
        public frmTrend()
        {
            InitializeComponent();
        }
        private void FrmSnipper_Load(object sender, System.EventArgs e)
        {
            Left = Top = 10;
            MaximizeBox = MinimizeBox = false;
            Text = Utilities.AppName; 
            dgTrends.RowHeadersVisible = false;
            dgTrends.AllowUserToAddRows = false;
            SetupGrid();
        }
        private void SetupGrid()
        {
            dgTrends.DataSource = chkRed.Checked ? db.GetTrendAll(false) : db.GetTrendAll(true);

            int[] widhts = { 25, 100, 80, 80, 80, 80, 80 };
            for (int i = 0; i <= dgTrends.Columns.Count - 1; i++)
                dgTrends.Columns[i].Width = widhts[i];
            DayOfWeek dow = DateTime.Today.DayOfWeek;
            dgTrends.Columns[2].DefaultCellStyle.BackColor = dgTrends.Columns[3].DefaultCellStyle.BackColor = Color.LightGray;
            for (int i = 0; i <= dgTrends.Rows.Count - 1; i++)
            {
                var dr = dgTrends.Rows[i];
                for (int j = 1; j <= dr.Cells.Count - 1; j++)
                    dr.Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                string wstr = dr.Cells[2].Value.ToString().ToLower();
                string dstr = dr.Cells[4].Value.ToString().ToLower();
                string wdir = dr.Cells[3].Value.ToString();
                string ddir = dr.Cells[5].Value.ToString();

                //dr.Cells[1].Style.BackColor = (wstr.StartsWith('s') && dstr.StartsWith('s'))
                //   ? Color.LightSalmon : (wstr.StartsWith('l') && dstr.StartsWith('l')) ? Color.LightGreen : Color.White;

                //dr.Cells[2].Style.ForeColor = dr.Cells[3].Style.ForeColor = wstr.StartsWith('s') ?
                //      Color.Red : wstr.StartsWith('l') ? Color.Green : Color.Black;
                //dr.Cells[4].Style.ForeColor = dr.Cells[5].Style.ForeColor = dstr.StartsWith('s') ?
                //    Color.Red : dstr.StartsWith('l') ? Color.Green : Color.Black;

                int subDays = (dow == DayOfWeek.Monday) ? 5 :
                    (dow == DayOfWeek.Tuesday) ? 4 : 3;

                for (int checkDays = 0; checkDays <= subDays; checkDays++)
                {
                    if (ddir.StartsWith(DateTime.Now.AddDays(checkDays * -1).ToString("%d")))
                    {
                        dr.Cells[5].Style.BackColor = Color.Yellow;
                        dr.Cells[1].Style.Font = util.GetFont(11);
                    }
                }

                if (wdir.StartsWith(DateTime.Now.AddDays(-6).StartOfWeek(DayOfWeek.Monday).ToString("%d")))
                {
                    dr.Cells[3].Style.BackColor = Color.Yellow;
                    dr.Cells[1].Style.Font = util.GetFont(11);
                }

                dgTrends.EnableHeadersVisualStyles = dgTrends.Columns[6].Visible = false;
                dgTrends.Columns[0].ReadOnly = dgTrends.Columns[1].ReadOnly = true;
            }
        }
        private void DgTrends_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string colHeader = dgTrends.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (colHeader != "")
            {
                string rowHeader = dgTrends.Columns[e.ColumnIndex].HeaderText.ToString();
                string val = dgTrends.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                db.UpdateCurTrend(rowHeader, colHeader, val);
            }
            setTodayColor();
        }
        private void setTodayColor()
        {
            int totRec = dgTrends.Rows.Count;
            for (int i = 0; i <= totRec - 1; i++)
            {
                var dr = dgTrends.Rows[i];
                if (dr.Cells[5].Value.ToString().ToLower().StartsWith(DateTime.Now.ToString("%d")))
                    dr.Cells[5].Style.BackColor = Color.LightYellow;
            }
        }
        private void ResetAll(object sender, System.EventArgs e)
        {
            SetupGrid();
        }
        private void BtnSaveToDatabase_Click(object sender, System.EventArgs e)
        {
            util.SaveToRepository();
        }
    }
}
