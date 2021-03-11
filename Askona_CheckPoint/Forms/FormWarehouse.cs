using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

namespace Askona_CheckPoint
{
    public partial class FormWarehouse : Form
    {
        public FormWarehouse() => InitializeComponent();
        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            FillWarehouse();
            WarehouseTimer.Start();
        }
        private void FillWarehouse()
        {
            int selectedRow = 0;
            if (WarehouseDGV.SelectedRows.Count > 0)
                selectedRow = WarehouseDGV.SelectedRows[0].Index;
            int displayedRow = 0;
            if (WarehouseDGV.Rows.Count > 0 && WarehouseDGV.FirstDisplayedCell != null)
                displayedRow = WarehouseDGV.FirstDisplayedCell.RowIndex;
            DateTime datebegin = WarehouseDTP.Value.Date.AddDays(1);
            DateTime dateend = WarehouseDTP.Value.Date;
            using (CheckPoint db = new CheckPoint())
            {
                var rq = db.Request.Where(x => x.FDATEBEGIN.CompareTo(datebegin) <= 0 && x.FDATEEND.CompareTo(dateend) >= 0)
                                   .Where(x => x.FSTATUS != Status.Initial && x.FSTATUS != Status.Changed && x.FSTATUS != Status.Approved && x.FSTATUS != Status.ActiveOutput)
                                   .Where(x => x.FGUESTFIO.ToUpper().Contains(FilterFIOTB.Text.ToUpper()) || FilterFIOTB.Text == "")
                                   .Where(x => x.FAUTONUMBER.ToUpper().Contains(FilterAutoTB.Text.ToUpper()) || FilterAutoTB.Text == "")
                                   .Select(x => new Warehouse_View
                                   {
                                       FID= x.FID,
                                       FGUESTFIO = x.FGUESTFIO,
                                       FAUTOMARK = x.FAUTOMARK,
                                       FAUTONUMBER = x.FAUTONUMBER,
                                       FLOCATION = x.FLOCATION,
                                       FDATEBEGIN = x.FDATEBEGIN,
                                       FDATEEND = x.FDATEEND,
                                       FSTATUS = x.FSTATUS,
                                       FWHDATEBEGIN = x.FWHDATEBEGIN,
                                       FWHDATEEND = x.FWHDATEEND,
                                       FMEETFIO = x.FMEETFIO,
                                       FGUESTJOB = x.FGUESTJOB,
                                       FWHCOMMENT = x.FWHCOMMENT,
                                       FDESCR = x.FDESCR,
                                       FPURPOSE = x.FPURPOSE,
                                       FUTVDATE = x.FUTVDATE,
                                       FPHONE = x.FPHONE,
                                       FWHPERSON = x.FWHPERSON
                                   });
                WarehouseDGV.DataSource = new CustomBindingList<Warehouse_View>(rq.ToList());
            }
            WarehouseDGV.Select();
            SumLabel.Text = "ИТОГО: " + WarehouseDGV.Rows.Count.ToString() + " шт.";
            if (selectedRow != 0 && selectedRow < WarehouseDGV.Rows.Count)
                WarehouseDGV.Rows[selectedRow].Selected = true;
            if (displayedRow != 0 && displayedRow < WarehouseDGV.Rows.Count)
                WarehouseDGV.FirstDisplayedScrollingRowIndex = displayedRow;
        }
        private void WarehouseDTP_ValueChanged(object sender, EventArgs e) => FillWarehouse();

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Text = "Обновить";
            RefreshButton.ForeColor = Color.Black;
            FillWarehouse();
        }
        private void InButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            if (WarehouseDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                {
                    if (WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[12].Value == null)
                    {
                        MessageBox.Show("Нет комментария склада!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[8].Value == null &&
                        WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[7].Value.ToString() == Status.ActiveInput)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                rq.FWHDATEBEGIN = DateTime.Now;
                                rq.FWHDATEEND = null;
                                rq.FSTATUS = Status.EntryAllowed;                                
                            }
                            var io = db.InOut.Where(x => x.FID == id)
                                             .Where(x => x.FFACTDATEEND == null)
                                             .FirstOrDefault();
                            if (io != null)
                            {
                                io.FWHDATEBEGIN = DateTime.Now; ;
                                io.FWHDATEEND = null;
                            }
                            db.SaveChanges();
                        }
                        FillWarehouse();
                    }
                }
        }
        private void OutButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            if (WarehouseDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                {
                    if (WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[8].Value != null &&
                        WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[9].Value == null &&
                        WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[7].Value.ToString() == Status.EntryAllowed)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                rq.FWHDATEEND = DateTime.Now;
                                rq.FSTATUS = Status.ShipmentCompleted;
                            }
                            var io = db.InOut.Where(x => x.FID == id)
                                             .Where(x => x.FFACTDATEEND == null)
                                             .FirstOrDefault();
                            if (io != null)
                                io.FWHDATEEND = DateTime.Now;
                            db.SaveChanges();
                        }
                        FillWarehouse();
                    }
                }
        }
        private void JournalButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormJournal fj = new FormJournal();
                fj.Owner = this.Owner;
                fj.request_id = (int)WarehouseDGV.Rows[WarehouseDGV.SelectedRows[0].Index].Cells[0].Value;
                fj.ShowDialog();
            }
            catch { }
        }
        private void WarehouseTimer_Tick(object sender, EventArgs e)
        {
            DateTime datebegin = WarehouseDTP.Value.Date.AddDays(1);
            DateTime dateend = WarehouseDTP.Value.Date;
            int realcount = 0;
            using (CheckPoint db = new CheckPoint())
            {
                realcount = db.Request.Where(x => x.FDATEBEGIN.CompareTo(datebegin) <= 0 && x.FDATEEND.CompareTo(dateend) >= 0)
                                   .Where(x => x.FSTATUS != Status.Initial && x.FSTATUS != Status.Changed && x.FSTATUS != Status.Approved && x.FSTATUS != Status.ActiveOutput)
                                   .Where(x => x.FGUESTFIO.ToUpper().Contains(FilterFIOTB.Text.ToUpper()) || FilterFIOTB.Text == "")
                                   .Where(x => x.FAUTONUMBER.ToUpper().Contains(FilterAutoTB.Text.ToUpper()) || FilterAutoTB.Text == "")
                                   .Count();
            }
            int viewcount = WarehouseDGV.Rows.Count;
            if (realcount != viewcount)
            {
                RefreshButton.Text = "Обновить\n(изменено: " + Math.Abs(realcount - viewcount).ToString() + ")";
                RefreshButton.ForeColor = Color.Red;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            FormBlank fb = new FormBlank();
            fb.Owner = this.Owner;
            int row = WarehouseDGV.SelectedRows[0].Index;
            fb.GuestFIOTB.Text = WarehouseDGV.Rows[row].Cells[1].Value.ToString();
            fb.GuestJobTB.Text = WarehouseDGV.Rows[row].Cells[11].Value.ToString();
            fb.AutoMarkTB.Text = WarehouseDGV.Rows[row].Cells[2].Value.ToString();
            fb.AutoNumberTB.Text = WarehouseDGV.Rows[row].Cells[3].Value.ToString();
            fb.LocationTB.Text = WarehouseDGV.Rows[row].Cells[4].Value.ToString();
            fb.PurposeTB.Text = WarehouseDGV.Rows[row].Cells[14].Value.ToString();
            fb.BeginDateDTP.Value = (DateTime)WarehouseDGV.Rows[row].Cells[5].Value;
            fb.BeginTimeDTP.Value = (DateTime)WarehouseDGV.Rows[row].Cells[5].Value;
            fb.EndDateDTP.Value = (DateTime)WarehouseDGV.Rows[row].Cells[6].Value;
            fb.EndTimeDTP.Value = (DateTime)WarehouseDGV.Rows[row].Cells[6].Value;
            fb.MeetFIOTB.Text = WarehouseDGV.Rows[row].Cells[10].Value.ToString();
            if (WarehouseDGV.Rows[row].Cells[12].Value != null)
                fb.WHTB.Text = WarehouseDGV.Rows[row].Cells[12].Value.ToString();
            fb.WHTB.Visible = true;
            fb.WHLabel.Visible = true;
            fb.PhoneTB.Text = WarehouseDGV.Rows[row].Cells[16].Value.ToString();
            if (WarehouseDGV.Rows[row].Cells[17].Value != null)
                fb.WHPersonLabel.Text = WarehouseDGV.Rows[row].Cells[17].Value.ToString();
            fb.WHPersonLabel.Visible = true;
            if (sender.ToString() == "System.Windows.Forms.DataGridView")
            {
                fb.CreateButton.Visible = false;
                fb.Text = "Просмотр заявки № " + WarehouseDGV.Rows[row].Cells[0].Value.ToString() + " (" + WarehouseDGV.Rows[row].Cells[13].Value.ToString() + ") (утверждено: " + WarehouseDGV.Rows[row].Cells[15].Value.ToString() + ")";
                foreach (Control control in fb.Controls)
                    if (control.Name != "Cancel2Button")
                        control.Enabled = false;
            }
            else
            {
                fb.CreateButton.Text = "Редактирование";
                fb.Text = "Редактирование заявки № " + WarehouseDGV.Rows[row].Cells[0].Value.ToString() + " (" + WarehouseDGV.Rows[row].Cells[13].Value.ToString() + ") (утверждено: " + WarehouseDGV.Rows[row].Cells[15].Value.ToString() + ")";
                fb.request_id = (int)WarehouseDGV.Rows[row].Cells[0].Value;
                foreach (Control control in fb.Controls)
                    if (control.Name != "Cancel2Button" && control.Name != "WHTB" && control.Name != "CreateButton")
                        control.Enabled = false;
            }
            fb.ShowDialog();
            if (sender.ToString() != "System.Windows.Forms.DataGridView")
                FillWarehouse();
        }
        private void WarehouseDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditButton_Click(sender, e);
        private void FilterFIOTB_TextChanged(object sender, EventArgs e)
        {
            FillWarehouse();
            FilterFIOTB.Focus();
        }
        private void FilterAutoTB_TextChanged(object sender, EventArgs e)
        {
            FillWarehouse();
            FilterAutoTB.Focus();
        }
        private void DGV_Paint()
        {
            for (int i = 0; i < WarehouseDGV.Rows.Count; i++)
            {
                if (WarehouseDGV.Rows[i].Cells[7].Value.ToString() == Status.EntryAllowed)
                    WarehouseDGV.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                if (WarehouseDGV.Rows[i].Cells[7].Value.ToString() == Status.ShipmentCompleted)
                    WarehouseDGV.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void WarehouseDGV_DataSourceChanged(object sender, EventArgs e) => DGV_Paint();
        private void WarehouseDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) => DGV_Paint();
    }
}