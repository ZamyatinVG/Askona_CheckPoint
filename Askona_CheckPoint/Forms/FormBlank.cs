using System;
using System.Windows.Forms;
using System.Linq;

namespace Askona_CheckPoint
{
    public partial class FormBlank : Form
    {
        public int request_id;
        public FormBlank() => InitializeComponent();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (GuestFIOTB.Text == "" || GuestJobTB.Text == "" || LocationTB.Text == "" || PurposeTB.Text == "" || MeetFIOTB.Text == "" || PhoneTB.Text == "")
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime beginDT = BeginDateDTP.Value.Date.Add(BeginTimeDTP.Value.TimeOfDay);
            DateTime endDT = EndDateDTP.Value.Date.Add(EndTimeDTP.Value.TimeOfDay);
            DateTime outDT = OutDateDTP.Value.Date.Add(OutTimeDTP.Value.TimeOfDay);
            if (beginDT.CompareTo(endDT) >= 0)
            {
                MessageBox.Show("Время окончания должно быть больше времени начала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (CheckPoint db = new CheckPoint())
            {
                if (CreateButton.Text == "Создать")
                {
                    if (beginDT.CompareTo(DateTime.Now) < 0)
                    {
                        MessageBox.Show("Время начала должны быть больше текущего!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Request rq = new Request
                    {
                        FCREATEDATE = DateTime.Now,
                        FDESCR = SystemInformation.UserName,
                        FGUESTFIO = GuestFIOTB.Text,
                        FGUESTJOB = GuestJobTB.Text,
                        FAUTOMARK = AutoMarkTB.Text,
                        FAUTONUMBER = AutoNumberTB.Text,
                        FLOCATION = LocationTB.Text,
                        FPURPOSE = PurposeTB.Text,
                        FDATEBEGIN = beginDT,
                        FDATEEND = endDT,
                        FMEETFIO = MeetFIOTB.Text,
                        FPHONE = PhoneTB.Text,
                        FSTATUS = Status.Initial
                    };
                    db.Request.Add(rq);
                }
                if (CreateButton.Text == "Изменить")
                {
                    if (beginDT.CompareTo(DateTime.Now) < 0)
                    {
                        MessageBox.Show("Время начала должны быть больше текущего!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var rq = db.Request.Where(x => x.FID == request_id).FirstOrDefault();
                    if (rq != null)
                    {
                        rq.FGUESTFIO = GuestFIOTB.Text;
                        rq.FGUESTJOB = GuestJobTB.Text;
                        rq.FAUTOMARK = AutoMarkTB.Text;
                        rq.FAUTONUMBER = AutoNumberTB.Text;
                        rq.FLOCATION = LocationTB.Text;
                        rq.FPURPOSE = PurposeTB.Text;
                        rq.FDATEBEGIN = beginDT;
                        rq.FDATEEND = endDT;
                        rq.FMEETFIO = MeetFIOTB.Text;
                        rq.FPHONE = PhoneTB.Text;
                        rq.FSTATUS = Status.Changed;
                    }
                }
                if (CreateButton.Text == "Правка")
                {
                    if (outDT.CompareTo(DateTime.Now) > 0)
                    {
                        MessageBox.Show("Время выхода должно быть меньше текущего!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var rq = db.Request.Where(x => x.FID == request_id).FirstOrDefault();
                    if (rq != null)
                    {
                        rq.FGUESTFIO = GuestFIOTB.Text;
                        rq.FGUESTJOB = GuestJobTB.Text;
                        rq.FAUTOMARK = AutoMarkTB.Text;
                        rq.FAUTONUMBER = AutoNumberTB.Text;
                        rq.FLOCATION = LocationTB.Text;
                        if (PurposeTB.Text.IndexOf("изменено") != -1)
                            rq.FPURPOSE = PurposeTB.Text.Substring(0, PurposeTB.Text.IndexOf("изменено")).Trim();
                        else
                            rq.FPURPOSE = PurposeTB.Text;
                        rq.FPURPOSE += Environment.NewLine + "изменено " + SystemInformation.UserName + " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                        rq.FDATEBEGIN = beginDT;
                        rq.FDATEEND = endDT;
                        rq.FMEETFIO = MeetFIOTB.Text;
                        rq.FPHONE = PhoneTB.Text;
                        if (rq.FFACTDATEEND != null)
                            rq.FFACTDATEEND = outDT;
                    }
                    var io = db.InOut.Where(x => x.FID == request_id)
                                     .OrderByDescending(x => x.FFACTDATEEND)
                                     .FirstOrDefault();
                    if (io != null && rq.FFACTDATEEND != null)
                        io.FFACTDATEEND = outDT;
                }
                if (CreateButton.Text == "Редактирование")
                {
                    var rq = db.Request.Where(x => x.FID == request_id).FirstOrDefault();
                    if (rq != null)
                    {
                        rq.FWHCOMMENT = WHTB.Text;
                        rq.FWHPERSON = SystemInformation.UserName;
                    }
                }
                try
                {
                    db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обращения к данным!\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Cancel2Button_Click(object sender, EventArgs e) => this.Close();
        private void FormBlank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}