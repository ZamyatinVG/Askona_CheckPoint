using System;
using System.Windows.Forms;
using combit.ListLabel15;

namespace Askona_CheckPoint
{
    public partial class FormPrint : Form
    {
        private ListLabel LL = new ListLabel();
        public FormPrint() => InitializeComponent();
        private void FormPrint_Load(object sender, EventArgs e)
        {
            LL.LicensingInfo = "jMijDg";
            LL.DefineVariables += new combit.ListLabel15.DefineVariablesHandler(LL_DefineVariables);
            MainWHButton.Click += Button_Click;
            LopatinaButton.Click += Button_Click;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int type;
            if (btn.Name == "MainWHButton")
                type = 0;
            else
                type = 1;
            try
            {
                if (this.Text == "Печать")
                    LL.Print(type, LlProject.Label, System.Windows.Forms.Application.StartupPath + "\\Шаблоны\\Пропуск.lbl", false, LlPrintMode.Export, LlBoxType.EmptyWait, this.Handle, "Печать...", true, "");
                else
                    LL.Design(type, this.Handle, "Открытие шаблона", LlProject.Label | LlProject.FileAlsoNew, System.Windows.Forms.Application.StartupPath + "\\Шаблоны\\Пропуск.lbl", false);
            }
            catch (LL_User_Aborted_Exception) { }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
        private void LL_DefineVariables(object sender, DefineElementsEventArgs e)
        {
            FormCheck fch = (FormCheck)this.Owner;
            int selectedRow = fch.CheckDGV.SelectedRows[0].Index;
            LL.Variables.Add("FID", fch.CheckDGV.Rows[selectedRow].Cells[0].Value.ToString());
            LL.Variables.Add("FDATE", DateTime.Now.ToLongDateString());
            LL.Variables.Add("FGUESTFIO", fch.CheckDGV.Rows[selectedRow].Cells[1].Value.ToString());
            LL.Variables.Add("FAUTO", fch.CheckDGV.Rows[selectedRow].Cells[2].Value.ToString() + " " + fch.CheckDGV.Rows[selectedRow].Cells[3].Value.ToString());
            LL.Variables.Add("FLOCATION", fch.CheckDGV.Rows[selectedRow].Cells[4].Value.ToString());
            LL.Variables.Add("FMEETFIO", fch.CheckDGV.Rows[selectedRow].Cells[10].Value.ToString());
            LL.Variables.Add("FFACTDATEBEGIN", fch.CheckDGV.Rows[selectedRow].Cells[8].Value?.ToString());
            LL.Variables.Add("FWHCOMMENT", fch.CheckDGV.Rows[selectedRow].Cells[14].Value?.ToString());
            LL.Variables.Add("JPGTYPE", e.UserData.ToString());
            if (!e.IsDesignMode) e.IsLastRecord = true;
        }
    }
}