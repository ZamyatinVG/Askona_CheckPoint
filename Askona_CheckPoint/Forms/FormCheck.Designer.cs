namespace Askona_CheckPoint
{
    partial class FormCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheck));
            this.DateLabel = new System.Windows.Forms.Label();
            this.CheckDTP = new System.Windows.Forms.DateTimePicker();
            this.CheckDGV = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.FilterFIOLabel = new System.Windows.Forms.Label();
            this.FilterFIOTB = new System.Windows.Forms.TextBox();
            this.FilterAutoTB = new System.Windows.Forms.TextBox();
            this.FilterAutoLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.JournalButton = new System.Windows.Forms.Button();
            this.SumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CheckDGV)).BeginInit();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(12, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(68, 16);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Период:";
            // 
            // CheckDTP
            // 
            this.CheckDTP.CustomFormat = "";
            this.CheckDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckDTP.Location = new System.Drawing.Point(86, 6);
            this.CheckDTP.Name = "CheckDTP";
            this.CheckDTP.Size = new System.Drawing.Size(150, 22);
            this.CheckDTP.TabIndex = 1;
            this.CheckDTP.ValueChanged += new System.EventHandler(this.CheckDTP_ValueChanged);
            // 
            // CheckDGV
            // 
            this.CheckDGV.AllowUserToAddRows = false;
            this.CheckDGV.AllowUserToDeleteRows = false;
            this.CheckDGV.AllowUserToResizeRows = false;
            this.CheckDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CheckDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.CheckDGV.ContextMenuStrip = this.CMS;
            this.CheckDGV.Location = new System.Drawing.Point(17, 109);
            this.CheckDGV.MultiSelect = false;
            this.CheckDGV.Name = "CheckDGV";
            this.CheckDGV.ReadOnly = true;
            this.CheckDGV.RowHeadersWidth = 4;
            this.CheckDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckDGV.Size = new System.Drawing.Size(1005, 566);
            this.CheckDGV.TabIndex = 0;
            this.CheckDGV.TabStop = false;
            this.CheckDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckDGV_CellDoubleClick);
            this.CheckDGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CheckDGV_ColumnHeaderMouseClick);
            this.CheckDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckDGV_RowEnter);
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "FID";
            this.Column0.HeaderText = "№ п/п";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FGUESTFIO";
            this.Column1.HeaderText = "ФИО посетителя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FAUTOMARK";
            this.Column2.HeaderText = "Марка автомобиля";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FAUTONUMBER";
            this.Column3.HeaderText = "Гос. номер автомобиля";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FLOCATION";
            this.Column4.HeaderText = "Объект посещения";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FDATEBEGIN";
            this.Column5.HeaderText = "Время начала";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FDATEEND";
            this.Column6.HeaderText = "Время окончания";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FSTATUS";
            this.Column7.HeaderText = "Статус";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FFACTDATEBEGIN";
            this.Column8.HeaderText = "Время входа";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FFACTDATEEND";
            this.Column9.HeaderText = "Время выхода";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "FMEETFIO";
            this.Column10.HeaderText = "ФИО принимающего";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "FGUESTJOB";
            this.Column11.HeaderText = "Место работы посетителя";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "FWHDATEBEGIN";
            this.Column12.HeaderText = "Время въезда";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "FWHDATEEND";
            this.Column13.HeaderText = "Время отгрузки";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "FWHCOMMENT";
            this.Column14.HeaderText = "Комментарий склада";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "FDESCR";
            this.Column15.HeaderText = "Дескриптор";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "FPURPOSE";
            this.Column16.HeaderText = "Цель посещения";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "FUTVDATE";
            this.Column17.HeaderText = "Дата утверждения";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "FPHONE";
            this.Column18.HeaderText = "Телефон";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "FWHPERSON";
            this.Column19.HeaderText = "ФИО склад";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            this.Column19.Width = 125;
            // 
            // CMS
            // 
            this.CMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDesign});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(165, 26);
            // 
            // miDesign
            // 
            this.miDesign.Name = "miDesign";
            this.miDesign.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.miDesign.Size = new System.Drawing.Size(164, 22);
            this.miDesign.Text = "Дизайнер";
            this.miDesign.Visible = false;
            this.miDesign.Click += new System.EventHandler(this.MiDesign_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(15, 44);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(150, 25);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Печать пропуска";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // InButton
            // 
            this.InButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InButton.Location = new System.Drawing.Point(171, 44);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(150, 25);
            this.InButton.TabIndex = 3;
            this.InButton.Text = "Вход";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.Location = new System.Drawing.Point(483, 75);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(150, 25);
            this.EndButton.TabIndex = 9;
            this.EndButton.Text = "Завершить";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Visible = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // FilterFIOLabel
            // 
            this.FilterFIOLabel.AutoSize = true;
            this.FilterFIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFIOLabel.Location = new System.Drawing.Point(12, 82);
            this.FilterFIOLabel.Name = "FilterFIOLabel";
            this.FilterFIOLabel.Size = new System.Drawing.Size(114, 16);
            this.FilterFIOLabel.TabIndex = 5;
            this.FilterFIOLabel.Text = "Фильтер ФИО:";
            // 
            // FilterFIOTB
            // 
            this.FilterFIOTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFIOTB.Location = new System.Drawing.Point(132, 79);
            this.FilterFIOTB.Name = "FilterFIOTB";
            this.FilterFIOTB.Size = new System.Drawing.Size(189, 22);
            this.FilterFIOTB.TabIndex = 7;
            this.FilterFIOTB.TextChanged += new System.EventHandler(this.FilterFIOTB_TextChanged);
            // 
            // FilterAutoTB
            // 
            this.FilterAutoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterAutoTB.Location = new System.Drawing.Point(377, 79);
            this.FilterAutoTB.Name = "FilterAutoTB";
            this.FilterAutoTB.Size = new System.Drawing.Size(100, 22);
            this.FilterAutoTB.TabIndex = 8;
            this.FilterAutoTB.TextChanged += new System.EventHandler(this.FilterAutoTB_TextChanged);
            // 
            // FilterAutoLabel
            // 
            this.FilterAutoLabel.AutoSize = true;
            this.FilterAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterAutoLabel.Location = new System.Drawing.Point(327, 82);
            this.FilterAutoLabel.Name = "FilterAutoLabel";
            this.FilterAutoLabel.Size = new System.Drawing.Size(48, 16);
            this.FilterAutoLabel.TabIndex = 8;
            this.FilterAutoLabel.Text = "Авто:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshButton.Location = new System.Drawing.Point(872, 44);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(150, 57);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CheckTimer
            // 
            this.CheckTimer.Interval = 10000;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(483, 44);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 25);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutButton.Location = new System.Drawing.Point(327, 44);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(150, 25);
            this.OutButton.TabIndex = 4;
            this.OutButton.Text = "Выход";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // JournalButton
            // 
            this.JournalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalButton.Location = new System.Drawing.Point(639, 44);
            this.JournalButton.Name = "JournalButton";
            this.JournalButton.Size = new System.Drawing.Size(150, 25);
            this.JournalButton.TabIndex = 6;
            this.JournalButton.Text = "Журнал";
            this.JournalButton.UseVisualStyleBackColor = true;
            this.JournalButton.Click += new System.EventHandler(this.JournalButton_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(869, 6);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(63, 16);
            this.SumLabel.TabIndex = 13;
            this.SumLabel.Text = "ИТОГО:";
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 687);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.JournalButton);
            this.Controls.Add(this.FilterAutoLabel);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.FilterAutoTB);
            this.Controls.Add(this.FilterFIOTB);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FilterFIOLabel);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.CheckDGV);
            this.Controls.Add(this.CheckDTP);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.RefreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль проезда";
            this.Load += new System.EventHandler(this.FormCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckDGV)).EndInit();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker CheckDTP;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label FilterFIOLabel;
        private System.Windows.Forms.TextBox FilterFIOTB;
        private System.Windows.Forms.TextBox FilterAutoTB;
        private System.Windows.Forms.Label FilterAutoLabel;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.DataGridView CheckDGV;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem miDesign;
        private System.Windows.Forms.Timer CheckTimer;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button JournalButton;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }
}