namespace Askona_CheckPoint
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.RequestButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestButton
            // 
            this.RequestButton.Enabled = false;
            this.RequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestButton.Location = new System.Drawing.Point(25, 20);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(300, 40);
            this.RequestButton.TabIndex = 0;
            this.RequestButton.Text = "Создание заявки";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Enabled = false;
            this.ControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlButton.Location = new System.Drawing.Point(25, 80);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(300, 40);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "Контроль проезда";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(25, 140);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(300, 40);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Контроль погрузки";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.RequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КПП";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button LoadButton;

    }
}

