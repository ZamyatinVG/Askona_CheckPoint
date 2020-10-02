namespace Askona_CheckPoint
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.MainWHButton = new System.Windows.Forms.Button();
            this.LopatinaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainWHButton
            // 
            this.MainWHButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWHButton.Location = new System.Drawing.Point(20, 30);
            this.MainWHButton.Name = "MainWHButton";
            this.MainWHButton.Size = new System.Drawing.Size(250, 40);
            this.MainWHButton.TabIndex = 1;
            this.MainWHButton.Text = "Точмаш";
            this.MainWHButton.UseVisualStyleBackColor = true;
            // 
            // LopatinaButton
            // 
            this.LopatinaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LopatinaButton.Location = new System.Drawing.Point(20, 89);
            this.LopatinaButton.Name = "LopatinaButton";
            this.LopatinaButton.Size = new System.Drawing.Size(250, 40);
            this.LopatinaButton.TabIndex = 2;
            this.LopatinaButton.Text = "Лопатина";
            this.LopatinaButton.UseVisualStyleBackColor = true;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.LopatinaButton);
            this.Controls.Add(this.MainWHButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MainWHButton;
        private System.Windows.Forms.Button LopatinaButton;
    }
}