using System;
using System.Windows.Forms;
using System.Linq;

namespace Askona_CheckPoint
{
    public partial class FormRequest : Form
    {
        public FormRequest() => InitializeComponent();

        private void FormRequest_Load(object sender, EventArgs e) => FillRequestDGV();

        private void FillRequestDGV()
        {
            int selectedRow = 0;
            if (RequestDGV.SelectedRows.Count > 0)
                selectedRow = RequestDGV.SelectedRows[0].Index;
            int displayedRow = 0;
            if (RequestDGV.Rows.Count > 0 && RequestDGV.FirstDisplayedCell != null)
                displayedRow = RequestDGV.FirstDisplayedCell.RowIndex;
            if (Rights.p_staff)
                SelfChB.Visible = true;
            using (CheckPoint db = new CheckPoint())
            {
                var rq = db.Request.Where(x => x.FCREATEDATE.Year == RequestDTP.Value.Year && x.FCREATEDATE.Month == RequestDTP.Value.Month)
                                   .Where(x => x.FDESCR == SystemInformation.UserName || (SelfChB.Visible && !SelfChB.Checked))
                                   .Select(x => new Request_View
                                   {
                                       FID = x.FID,
                                       FDESCR = x.FDESCR,
                                       FCREATEDATE = x.FCREATEDATE,
                                       FGUESTFIO = x.FGUESTFIO,
                                       FGUESTJOB = x.FGUESTJOB,
                                       FAUTOMARK = x.FAUTOMARK,
                                       FAUTONUMBER = x.FAUTONUMBER,
                                       FLOCATION = x.FLOCATION,
                                       FDATEBEGIN = x.FDATEBEGIN,
                                       FDATEEND = x.FDATEEND,
                                       FMEETFIO = x.FMEETFIO,
                                       FSTATUS = x.FSTATUS,
                                       FPURPOSE = x.FPURPOSE,
                                       FUTVDATE = x.FUTVDATE,
                                       FPHONE = x.FPHONE
                                   });
                RequestDGV.DataSource = new CustomBindingList<Request_View>(rq.ToList());
            }
            RequestDGV.Select();
            if (selectedRow != 0 && selectedRow < RequestDGV.Rows.Count)
                RequestDGV.Rows[selectedRow].Selected = true;
            if (displayedRow != 0 && displayedRow < RequestDGV.Rows.Count)
                RequestDGV.FirstDisplayedScrollingRowIndex = displayedRow;
        }

        private void RequestDTP_ValueChanged(object sender, EventArgs e) => FillRequestDGV();

        private void SelfChB_CheckedChanged(object sender, EventArgs e) => FillRequestDGV();

        private void RequestDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (RequestDGV.SelectedRows.Count != 0)
                if (RequestDGV.Rows[RequestDGV.SelectedRows[0].Index].Cells[1].Value.ToString() != SystemInformation.UserName ||
                    (RequestDGV.Rows[RequestDGV.SelectedRows[0].Index].Cells[11].Value.ToString() != Status.Initial &&
                    RequestDGV.Rows[RequestDGV.SelectedRows[0].Index].Cells[11].Value.ToString() != Status.Changed))
                {
                    EditButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    ConfirmButton.Enabled = false;
                }
                else
                {
                    EditButton.Enabled = true;
                    DeleteButton.Enabled = true;
                    ConfirmButton.Enabled = true;
                }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (RequestDGV.SelectedRows.Count != 0)
            { 
                FormBlank fb = new FormBlank();
                fb.Owner = this.Owner;
                int row = RequestDGV.SelectedRows[0].Index;
                fb.GuestFIOTB.Text = RequestDGV.Rows[row].Cells[3].Value.ToString();
                fb.GuestJobTB.Text = RequestDGV.Rows[row].Cells[4].Value.ToString();
                fb.AutoMarkTB.Text = RequestDGV.Rows[row].Cells[5].Value.ToString();
                fb.AutoNumberTB.Text = RequestDGV.Rows[row].Cells[6].Value.ToString();
                fb.LocationTB.Text = RequestDGV.Rows[row].Cells[7].Value.ToString();
                fb.PurposeTB.Text = RequestDGV.Rows[row].Cells[12].Value.ToString();
                fb.BeginDateDTP.Value = (DateTime)RequestDGV.Rows[row].Cells[8].Value;
                fb.BeginTimeDTP.Value = (DateTime)RequestDGV.Rows[row].Cells[8].Value;
                fb.EndDateDTP.Value = (DateTime)RequestDGV.Rows[row].Cells[9].Value;
                fb.EndTimeDTP.Value = (DateTime)RequestDGV.Rows[row].Cells[9].Value;
                fb.MeetFIOTB.Text = RequestDGV.Rows[row].Cells[10].Value.ToString();
                fb.PhoneTB.Text = RequestDGV.Rows[row].Cells[14].Value.ToString();
                if (sender.ToString() == "System.Windows.Forms.DataGridView")
                {
                    fb.CreateButton.Visible = false;
                    fb.Text = "Просмотр заявки № " + RequestDGV.Rows[row].Cells[0].Value.ToString() + " (" + RequestDGV.Rows[row].Cells[1].Value.ToString() + ")";
                    foreach (Control control in fb.Controls)
                        if (control.Name != "Cancel2Button")
                            control.Enabled = false;
                }
                else
                {
                    fb.CreateButton.Text = "Изменить";
                    fb.Text = "Изменение заявки № " + RequestDGV.Rows[row].Cells[0].Value.ToString() + " (" + RequestDGV.Rows[row].Cells[1].Value.ToString() + ")";
                    fb.request_id = (int)RequestDGV.Rows[row].Cells[0].Value;
                }
                if (RequestDGV.Rows[row].Cells[13].Value != null)
                    fb.Text += " (утверждено: " + RequestDGV.Rows[row].Cells[13].Value.ToString() + ")";
                fb.ShowDialog();
                if (sender.ToString() != "System.Windows.Forms.DataGridView")
                    FillRequestDGV();
            }
        }

        private void RequestDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditButton_Click(sender, e);

        private void CreateButton_Click(object sender, EventArgs e)
        {
            FormBlank fb = new FormBlank();
            fb.Owner = this.Owner;
            fb.Text = "Создание заявки";
            fb.CreateButton.Text = "Создать";
            DateTime dt = DateTime.Now;
            fb.BeginTimeDTP.Value = dt.AddHours(1).AddMinutes(-dt.Minute).AddSeconds(-dt.Second);
            fb.EndTimeDTP.Value = dt.AddHours(1).AddMinutes(-dt.Minute).AddSeconds(-dt.Second);
            fb.ShowDialog();
            FillRequestDGV();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RequestDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(RequestDGV.Rows[RequestDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                    if (MessageBox.Show("Вы действительно хотите удалить заявку № " + id.ToString() + "?",
                                        "Удаление",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                db.Request.Remove(rq);
                                db.SaveChanges();
                            }
                        }
                        FillRequestDGV();
                    }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (RequestDGV.SelectedRows.Count != 0)
                if (Int32.TryParse(RequestDGV.Rows[RequestDGV.SelectedRows[0].Index].Cells[0].Value.ToString(), out int id))
                    if (MessageBox.Show("Утвердить заявку № " + id.ToString() + "?",
                                    "Утверждение",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        using (CheckPoint db = new CheckPoint())
                        {
                            var rq = db.Request.Where(x => x.FID == id).FirstOrDefault();
                            if (rq != null)
                            {
                                rq.FSTATUS = Status.Approved;
                                rq.FUTVDATE = DateTime.Now;
                                db.SaveChanges();
                            }
                        }
                        FillRequestDGV();
                    }
        }
    }
}