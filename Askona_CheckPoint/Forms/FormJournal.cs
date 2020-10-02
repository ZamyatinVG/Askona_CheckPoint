using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Askona_CheckPoint
{
    public partial class FormJournal : Form
    {
        public int request_id;

        public FormJournal()
        {
            InitializeComponent();
        }

        private void FormJournal_Load(object sender, System.EventArgs e)
        {
            using (CheckPoint db = new CheckPoint())
            {
                var io = db.InOut.Where(x => x.FID == request_id)
                                 .OrderBy(x => x.FFACTDATEBEGIN)
                                 .Select(x => new 
                                 {
                                    x.FFACTDATEBEGIN,
                                    x.FWHDATEBEGIN,
                                    x.FWHDATEEND,
                                    x.FFACTDATEEND
                                 });
                JournalDGV.DataSource = io.ToList();
            }
        }

        private void FormJournal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}