using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Linq;

namespace Askona_CheckPoint
{
    public partial class FormCheck : Form
    {
        public FormCheck() => InitializeComponent();
        private void FormCheck_Load(object sender, EventArgs e)
        {
            FillCheck();
            CheckTimer.Start();
        }
        private void FillCheck()
        {
            int selectedRow = 0;
            if (CheckDGV.SelectedRows.Count > 0)
                selectedRow = CheckDGV.SelectedRows[0].Index;
            int displayedRow = 0;
            if (CheckDGV.Rows.Count > 0 && CheckDGV.FirstDisplayedCell != null)
                displayedRow = CheckDGV.FirstDisplayedCell.RowIndex;
            DateTime datebegin = CheckDTP.Value.Date.AddDays(1);
            DateTime dateend = CheckDTP.Value.Date;
            using (CheckPoint db = new CheckPoint())
            {
                var rq = db.Request.Where(x => x.FDATEBEGIN.CompareTo(datebegin) <= 0 && x.FDATEEND.CompareTo(dateend) >= 0)
                                   .Where(x => x.FSTATUS != Status.Initial && x.FSTATUS != Status.Changed)
                                   .Where(x => x.FGUESTFIO.ToUpper().Contains(FilterFIOTB.Text.ToUpper()) || FilterFIOTB.Text == "")
                                   .Where(x => x.FAUTONUMBER.ToUpper().Contains(FilterAutoTB.Text.ToUpper()) || FilterAutoTB.Text == "")
                                   .Select(x => new Check_View
                                   {
                                       FID = x.FID,
                                       FGUESTFIO = x.FGUESTFIO,
                                       FAUTOMARK = x.FAUTOMARK,
                                       FAUTONUMBER = x.FAUTONUMBER,
                                       FLOCATION = x.FLOCATION,
                                       FDATEBEGIN = x.FDATEBEGIN,
                                       FDATEEND = x.FDATEEND,
                                       FSTATUS = x.FSTATUS,
                                       FFACTDATEBEGIN = x.FFACTDATEBEGIN,
                                       FFACTDATEEND = x.FFACTDATEEND,
                                       FMEETFIO = x.FMEETFIO,
                                       FGUESTJOB = x.FGUESTJOB,
                                       FWHDATEBEGIN = x.FWHDATEBEGIN,
                                       FWHDATEEND = x.FWHDATEEND,
                                       FWHCOMMENT = x.FWHCOMMENT,
                                       FDESCR = x.FDESCR,
                                       FPURPOSE = x.FPURPOSE,
                                       FUTVDATE = x.FUTVDATE,
                                       FPHONE = x.FPHONE,
                                       FWHPERSON = x.FWHPERSON
                                   });
                CheckDGV.DataSource = new CustomBindingList<Check_View>(rq.ToList());
            }
            CheckDGV.Select();
            SumLabel.Text = "ИТОГО: " + CheckDGV.Rows.Count.ToString() + " шт.";

            if (selectedRow != 0 && selectedRow < CheckDGV.Rows.Count)
                CheckDGV.Rows[selectedRow].Selected = true;
            if (displayedRow != 0 && displayedRow < CheckDGV.Rows.Count)
                CheckDGV.FirstDisplayedScrollingRowIndex = displayedRow;
        }

        private void CheckDTP_ValueChanged(object sender, EventArgs e) => FillCheck();
        private void EditButton_Click(object sender, EventArgs e)
        {
            FormBlank fb = new FormBlank();
            fb.Owner = this.Owner;
            int row = CheckDGV.SelectedRows[0].Index;
            fb.GuestFIOTB.Text = CheckDGV.Rows[row].Cells[1].Value.ToString();
            fb.GuestJobTB.Text = CheckDGV.Rows[row].Cells[11].Value.ToString();
            fb.AutoMarkTB.Text = CheckDGV.Rows[row].Cells[2].Value.ToString();
            fb.AutoNumberTB.Text = CheckDGV.Rows[row].Cells[3].Value.ToString();
            fb.LocationTB.Text = CheckDGV.Rows[row].Cells[4].Value.ToString();
            fb.PurposeTB.Text = CheckDGV.Rows[row].Cells[16].Value.ToString();
            fb.BeginDateDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[5].Value;
            fb.BeginTimeDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[5].Value;
            fb.EndDateDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[6].Value;
            fb.EndTimeDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[6].Value;
            fb.MeetFIOTB.Text = CheckDGV.Rows[row].Cells[10].Value.ToString();
            fb.PhoneTB.Text = CheckDGV.Rows[row].Cells[18].Value.ToString();
            if (CheckDGV.Rows[row].Cells[9].Value != null)
            {
                fb.OutDateDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[9].Value;
                fb.OutTimeDTP.Value = (DateTime)CheckDGV.Rows[row].Cells[9].Value;
                fb.OutDateDTP.Visible = true;
                fb.OutTimeDTP.Visible = true;
                fb.OutLabel.Visible = true;
            }
            if (sender.ToString() == "System.Windows.Forms.DataGridView")
            {
                fb.CreateButton.Visible = false;
                fb.Text = "Просмотр заявки № " + CheckDGV.Rows[row].Cells[0].Value.ToString() + " (" + CheckDGV.Rows[row].Cells[15].Value.ToString() + ") (утверждено: " + CheckDGV.Rows[row].Cells[17].Value.ToString() + ")";
                if (CheckDGV.Rows[row].Cells[14].Value != null)
                    fb.WHTB.Text = CheckDGV.Rows[row].Cells[14].Value.ToString();
                fb.WHTB.Visible = true;
                fb.WHLabel.Visible = true;
                if (CheckDGV.Rows[row].Cells[19].Value != null)
                    fb.WHPersonLabel.Text = CheckDGV.Rows[row].Cells[19].Value.ToString();
                fb.WHPersonLabel.Visible = true;
                foreach (Control control in fb.Controls)
                    if (control.Name != "Cancel2Button")
                        control.Enabled = false;
            }
            else
            {
                fb.CreateButton.Text = "Правка";
                fb.Text = "Изменение заявки № " + CheckDGV.Rows[row].Cells[0].Value.ToString() + " (" + CheckDGV.Rows[row].Cells[15].Value.ToString() + ") (утверждено: " + CheckDGV.Rows[row].Cells[17].Value.ToString() + ")";
                fb.request_id = (int)CheckDGV.Rows[row].Cells[0].Value;
            }
            fb.ShowDialog();
            if (sender.ToString() != "System.Windows.Forms.DataGridView")
                FillCheck();
        }
        private void CheckDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditButton_Click(sender, e);
        private void InButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            if (CheckDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                    if (CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[8].Value == null ||
                        ((DateTime)CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[8].Value < (DateTime)CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[9].Value))
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                rq.FFACTDATEBEGIN = DateTime.Now;
                                rq.FSTATUS = Status.ActiveInput;
                                rq.FFACTDATEEND = rq.FWHDATEBEGIN = rq.FWHDATEEND = null;
                                rq.FWHCOMMENT = rq.FWHPERSON = null;
                            }
                            InOut io = new InOut
                            {
                                FID = id,
                                FFACTDATEBEGIN = DateTime.Now
                            };
                            db.InOut.Add(io);
                            db.SaveChanges();
                        }
                        FillCheck();
                    }
        }
        private void OutButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            if (CheckDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                {
                    if ((CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[8].Value != null && CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[9].Value == null) ||
                        (DateTime)CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[8].Value > (DateTime)CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[9].Value)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                rq.FFACTDATEEND = DateTime.Now;
                                rq.FSTATUS = Status.ActiveOutput;
                            }
                            var io = db.InOut.Where(x => x.FID == id)
                                             .Where(x => x.FFACTDATEEND == null)
                                             .FirstOrDefault();
                            if (io != null)
                                io.FFACTDATEEND = DateTime.Now;
                            db.SaveChanges();
                        }
                        FillCheck();
                    }
                }
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            if (CheckDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                    if (MessageBox.Show("Вы действительно хотите завершить заявку № " + id.ToString() + "?",
                                "Завершение",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                                rq.FSTATUS = Status.Completed;
                        }
                        FillCheck();
                    }
        }
        private void CheckDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckDGV.SelectedRows.Count != 0)
            {
                if (CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[7].Value.ToString() == Status.Completed)
                {
                    PrintButton.Enabled = false;
                    InButton.Enabled = false;
                    EndButton.Enabled = false;
                }
                else if (CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[8].Value != null &&
                         CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[9].Value == null)
                {
                    PrintButton.Enabled = true;
                    InButton.Enabled = true;
                    EndButton.Enabled = false;
                }
                else
                {
                    PrintButton.Enabled = true;
                    InButton.Enabled = true;
                    EndButton.Enabled = true;
                }
            }
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\combit.ListLabel15.dll"))
            {
                FormPrint fp = new FormPrint();
                fp.Owner = this;
                fp.Text = "Печать";
                fp.ShowDialog();
            }
            else MessageBox.Show("Печать недоступна!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MiDesign_Click(object sender, EventArgs e)
        {
            FormPrint fp = new FormPrint();
            fp.Owner = this;
            fp.Text = "Дизайнер";
            fp.ShowDialog();
        }
        private void FilterFIOTB_TextChanged(object sender, EventArgs e)
        {
            FillCheck();
            FilterFIOTB.Focus();
        }
        private void FilterAutoTB_TextChanged(object sender, EventArgs e)
        {
            FillCheck();
            FilterAutoTB.Focus();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Text = "Обновить";
            RefreshButton.ForeColor = Color.Black;
            FillCheck();
        }
        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            DateTime datebegin = CheckDTP.Value.Date.AddDays(1);
            DateTime dateend = CheckDTP.Value.Date;
            int realcount = 0;
            using (CheckPoint db = new CheckPoint())
            {
                realcount = db.Request.Where(x => x.FDATEBEGIN.CompareTo(datebegin) <= 0 && x.FDATEEND.CompareTo(dateend) >= 0)
                                      .Where(x => x.FSTATUS != Status.Initial && x.FSTATUS != Status.Changed)
                                      .Where(x => x.FGUESTFIO.ToUpper().Contains(FilterFIOTB.Text.ToUpper()) || FilterFIOTB.Text == "")
                                      .Where(x => x.FAUTONUMBER.ToUpper().Contains(FilterAutoTB.Text.ToUpper()) || FilterAutoTB.Text == "")
                                      .Count();
            }
            int viewcount = CheckDGV.Rows.Count;
            if (realcount > viewcount)
            {
                RefreshButton.Text = "Обновить\n(новых: " + (realcount - viewcount).ToString() + ")";
                RefreshButton.ForeColor = Color.Red;
            }
        }
        private void JournalButton_Click(object sender, EventArgs e)
        {
            if (CheckDGV.SelectedRows.Count != 0)
            {
                FormJournal fj = new FormJournal();
                fj.Owner = this.Owner;
                fj.request_id = (int)CheckDGV.Rows[CheckDGV.SelectedRows[0].Index].Cells[0].Value;
                fj.ShowDialog();
            }
        }
        private void DGV_Paint()
        {
            for (int i = 0; i < CheckDGV.Rows.Count; i++)
            {
                if (CheckDGV.Rows[i].Cells[7].Value.ToString() == Status.ActiveInput)
                    CheckDGV.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                if (CheckDGV.Rows[i].Cells[7].Value.ToString() == Status.EntryAllowed)
                    CheckDGV.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                if (CheckDGV.Rows[i].Cells[7].Value.ToString() == Status.ShipmentCompleted)
                    CheckDGV.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void CheckDGV_DataSourceChanged(object sender, EventArgs e) => DGV_Paint();
        private void CheckDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) => DGV_Paint();
    }
}