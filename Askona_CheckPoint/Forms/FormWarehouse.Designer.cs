namespace Askona_CheckPoint
{
    partial class FormWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouse));
            this.SumLabel = new System.Windows.Forms.Label();
            this.JournalButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.WarehouseDTP = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.WarehouseDGV = new System.Windows.Forms.DataGridView();
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
            this.WarehouseTimer = new System.Windows.Forms.Timer(this.components);
            this.FilterAutoLabel = new System.Windows.Forms.Label();
            this.FilterAutoTB = new System.Windows.Forms.TextBox();
            this.FilterFIOTB = new System.Windows.Forms.TextBox();
            this.FilterFIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(869, 6);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(63, 16);
            this.SumLabel.TabIndex = 21;
            this.SumLabel.Text = "ИТОГО:";
            // 
            // JournalButton
            // 
            this.JournalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalButton.Location = new System.Drawing.Point(483, 44);
            this.JournalButton.Name = "JournalButton";
            this.JournalButton.Size = new System.Drawing.Size(150, 25);
            this.JournalButton.TabIndex = 5;
            this.JournalButton.Text = "Журнал";
            this.JournalButton.UseVisualStyleBackColor = true;
            this.JournalButton.Click += new System.EventHandler(this.JournalButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutButton.Location = new System.Drawing.Point(327, 44);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(150, 25);
            this.OutButton.TabIndex = 4;
            this.OutButton.Text = "Заверш. отгрузки";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // InButton
            // 
            this.InButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InButton.Location = new System.Drawing.Point(171, 44);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(150, 25);
            this.InButton.TabIndex = 3;
            this.InButton.Text = "Разрешить въезд";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(15, 44);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 25);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // WarehouseDTP
            // 
            this.WarehouseDTP.CustomFormat = "";
            this.WarehouseDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseDTP.Location = new System.Drawing.Point(86, 6);
            this.WarehouseDTP.Name = "WarehouseDTP";
            this.WarehouseDTP.Size = new System.Drawing.Size(150, 22);
            this.WarehouseDTP.TabIndex = 1;
            this.WarehouseDTP.ValueChanged += new System.EventHandler(this.WarehouseDTP_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(12, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(68, 16);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Период:";
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
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // WarehouseDGV
            // 
            this.WarehouseDGV.AllowUserToAddRows = false;
            this.WarehouseDGV.AllowUserToDeleteRows = false;
            this.WarehouseDGV.AllowUserToResizeRows = false;
            this.WarehouseDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WarehouseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column17});
            this.WarehouseDGV.Location = new System.Drawing.Point(15, 107);
            this.WarehouseDGV.MultiSelect = false;
            this.WarehouseDGV.Name = "WarehouseDGV";
            this.WarehouseDGV.ReadOnly = true;
            this.WarehouseDGV.RowHeadersWidth = 4;
            this.WarehouseDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WarehouseDGV.Size = new System.Drawing.Size(1007, 568);
            this.WarehouseDGV.TabIndex = 0;
            this.WarehouseDGV.TabStop = false;
            this.WarehouseDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehouseDGV_CellDoubleClick);
            this.WarehouseDGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WarehouseDGV_ColumnHeaderMouseClick);
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
            this.Column8.DataPropertyName = "FWHDATEBEGIN";
            this.Column8.HeaderText = "Время въезда";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FWHDATEEND";
            this.Column9.HeaderText = "Время отгрузки";
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
            this.Column12.DataPropertyName = "FWHCOMMENT";
            this.Column12.HeaderText = "Комментарий склада";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "FDESCR";
            this.Column13.HeaderText = "Дескриптор";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "FPURPOSE";
            this.Column14.HeaderText = "Цель посещения";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "FUTVDATE";
            this.Column15.HeaderText = "Дата утверждения";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "FPHONE";
            this.Column16.HeaderText = "Телефон";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "FWHPERSON";
            this.Column17.HeaderText = "Сотрудник склада";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column17.Width = 125;
            // 
            // WarehouseTimer
            // 
            this.WarehouseTimer.Interval = 10000;
            this.WarehouseTimer.Tick += new System.EventHandler(this.WarehouseTimer_Tick);
            // 
            // FilterAutoLabel
            // 
            this.FilterAutoLabel.AutoSize = true;
            this.FilterAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterAutoLabel.Location = new System.Drawing.Point(327, 82);
            this.FilterAutoLabel.Name = "FilterAutoLabel";
            this.FilterAutoLabel.Size = new System.Drawing.Size(48, 16);
            this.FilterAutoLabel.TabIndex = 24;
            this.FilterAutoLabel.Text = "Авто:";
            // 
            // FilterAutoTB
            // 
            this.FilterAutoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterAutoTB.Location = new System.Drawing.Point(377, 79);
            this.FilterAutoTB.Name = "FilterAutoTB";
            this.FilterAutoTB.Size = new System.Drawing.Size(100, 22);
            this.FilterAutoTB.TabIndex = 25;
            this.FilterAutoTB.TextChanged += new System.EventHandler(this.FilterAutoTB_TextChanged);
            // 
            // FilterFIOTB
            // 
            this.FilterFIOTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFIOTB.Location = new System.Drawing.Point(132, 79);
            this.FilterFIOTB.Name = "FilterFIOTB";
            this.FilterFIOTB.Size = new System.Drawing.Size(189, 22);
            this.FilterFIOTB.TabIndex = 23;
            this.FilterFIOTB.TextChanged += new System.EventHandler(this.FilterFIOTB_TextChanged);
            // 
            // FilterFIOLabel
            // 
            this.FilterFIOLabel.AutoSize = true;
            this.FilterFIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterFIOLabel.Location = new System.Drawing.Point(12, 82);
            this.FilterFIOLabel.Name = "FilterFIOLabel";
            this.FilterFIOLabel.Size = new System.Drawing.Size(114, 16);
            this.FilterFIOLabel.TabIndex = 22;
            this.FilterFIOLabel.Text = "Фильтер ФИО:";
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 687);
            this.Controls.Add(this.FilterAutoLabel);
            this.Controls.Add(this.FilterAutoTB);
            this.Controls.Add(this.FilterFIOTB);
            this.Controls.Add(this.FilterFIOLabel);
            this.Controls.Add(this.WarehouseDGV);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.JournalButton);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.WarehouseDTP);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.RefreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль погрузки";
            this.Load += new System.EventHandler(this.FormWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Button JournalButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DateTimePicker WarehouseDTP;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.DataGridView WarehouseDGV;
        private System.Windows.Forms.Timer WarehouseTimer;
        private System.Windows.Forms.Label FilterAutoLabel;
        private System.Windows.Forms.TextBox FilterAutoTB;
        private System.Windows.Forms.TextBox FilterFIOTB;
        private System.Windows.Forms.Label FilterFIOLabel;
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
    }
}