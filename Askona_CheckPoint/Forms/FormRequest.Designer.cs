namespace Askona_CheckPoint
{
    partial class FormRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequest));
            this.RequestDTP = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.RequestDGV = new System.Windows.Forms.DataGridView();
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SelfChB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RequestDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestDTP
            // 
            this.RequestDTP.CustomFormat = "MMMM yyyy";
            this.RequestDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestDTP.Location = new System.Drawing.Point(86, 6);
            this.RequestDTP.Name = "RequestDTP";
            this.RequestDTP.Size = new System.Drawing.Size(150, 22);
            this.RequestDTP.TabIndex = 0;
            this.RequestDTP.ValueChanged += new System.EventHandler(this.RequestDTP_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(12, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(68, 16);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Период:";
            // 
            // RequestDGV
            // 
            this.RequestDGV.AllowUserToAddRows = false;
            this.RequestDGV.AllowUserToDeleteRows = false;
            this.RequestDGV.AllowUserToResizeRows = false;
            this.RequestDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RequestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column14});
            this.RequestDGV.Location = new System.Drawing.Point(15, 75);
            this.RequestDGV.MultiSelect = false;
            this.RequestDGV.Name = "RequestDGV";
            this.RequestDGV.ReadOnly = true;
            this.RequestDGV.RowHeadersWidth = 4;
            this.RequestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestDGV.Size = new System.Drawing.Size(1007, 600);
            this.RequestDGV.TabIndex = 0;
            this.RequestDGV.TabStop = false;
            this.RequestDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestDGV_CellDoubleClick);
            this.RequestDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestDGV_RowEnter);
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
            this.Column1.DataPropertyName = "FDESCR";
            this.Column1.HeaderText = "Дескриптор";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FCREATEDATE";
            this.Column2.HeaderText = "Дата создания";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FGUESTFIO";
            this.Column3.HeaderText = "ФИО посетителя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FGUESTJOB";
            this.Column4.HeaderText = "Место работы посетителя";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FAUTOMARK";
            this.Column5.HeaderText = "Марка автомобиля";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FAUTONUMBER";
            this.Column6.HeaderText = "Гос. номер автомобиля";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FLOCATION";
            this.Column7.HeaderText = "Объект посещения";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FDATEBEGIN";
            this.Column8.HeaderText = "Время начала";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FDATEEND";
            this.Column9.HeaderText = "Время окончания";
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
            this.Column10.Width = 250;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "FSTATUS";
            this.Column11.HeaderText = "Статус";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "FPURPOSE";
            this.Column12.HeaderText = "Цель посещения";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "FUTVDATE";
            this.Column13.HeaderText = "Дата утверждения";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "FPHONE";
            this.Column14.HeaderText = "Телефон";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 125;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(15, 44);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 25);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(171, 44);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 25);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(327, 44);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 25);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(483, 44);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(150, 25);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Утвердить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SelfChB
            // 
            this.SelfChB.AutoSize = true;
            this.SelfChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelfChB.Location = new System.Drawing.Point(242, 8);
            this.SelfChB.Name = "SelfChB";
            this.SelfChB.Size = new System.Drawing.Size(117, 20);
            this.SelfChB.TabIndex = 5;
            this.SelfChB.Text = "только свои";
            this.SelfChB.UseVisualStyleBackColor = true;
            this.SelfChB.Visible = false;
            this.SelfChB.CheckedChanged += new System.EventHandler(this.SelfChB_CheckedChanged);
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 687);
            this.Controls.Add(this.SelfChB);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.RequestDGV);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.RequestDTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заявок";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker RequestDTP;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridView RequestDGV;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.CheckBox SelfChB;
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
    }
}