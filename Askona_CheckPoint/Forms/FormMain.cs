using System;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Askona_CheckPoint
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (ADCheck("checkpoint_user") == "OK")
            {
                RequestButton.Enabled = true;
                Rights.p_user = true;
            }
            if (ADCheck("checkpoint_staff") == "OK")
            {
                RequestButton.Enabled = true;
                Rights.p_staff = true;
            }
            if (ADCheck("checkpoint_sec") == "OK") 
                ControlButton.Enabled = true;
            if (ADCheck("checkpoint_warehouse") == "OK")
                LoadButton.Enabled = true;
            this.Text += " (версия: " + Application.ProductVersion + ")";
        }

        private string ADCheck(string groupName)
        {
            DirectorySearcher ds = new DirectorySearcher("SAMAccountName=" + SystemInformation.UserName);
            SearchResult sr = ds.FindOne();
            if (sr == null) 
                return("В Active Directory не найдена учетная запись текущего пользователя.");
            DirectoryEntry user = sr.GetDirectoryEntry();
            ds.Filter = "(&(Name=" + groupName + ")(objectClass=group))";
            sr = ds.FindOne();
            if (sr == null)
                return("В Active Directory не найдена соответствующая группа пользователей.");
            DirectoryEntry group = sr.GetDirectoryEntry();
            if (!(bool)group.Invoke("IsMember", new object[] { user.Path }))
                return ("Текущий пользователь не входит в состав группы " + group.Name);
            else
                return("OK");
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            FormRequest fr = new FormRequest();
            fr.Owner = this;
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            FormCheck fc = new FormCheck();
            fc.Owner = this;
            this.Visible = false;
            fc.ShowDialog();
            this.Visible = true;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            FormWarehouse fw = new FormWarehouse();
            fw.Owner = this;
            this.Visible = false;
            fw.ShowDialog();
            this.Visible = true;
        }
    }
}