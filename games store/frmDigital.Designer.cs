namespace games_store
{
    partial class frmDigital
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
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.lblDownload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(12, 214);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(63, 15);
            this.lblSerial.TabIndex = 11;
            this.lblSerial.Text = "Serial:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(165, 204);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(208, 25);
            this.txtSerial.TabIndex = 12;
            this.txtSerial.Text = "1234567890";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(215, 15);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type:              Digital";
            // 
            // txtDownload
            // 
            this.txtDownload.Location = new System.Drawing.Point(165, 242);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(208, 25);
            this.txtDownload.TabIndex = 15;
            this.txtDownload.Text = "/downloads/game.exe";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(12, 252);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(79, 15);
            this.lblDownload.TabIndex = 14;
            this.lblDownload.Text = "Download:";
            // 
            // frmDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(394, 437);
            this.Controls.Add(this.txtDownload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblSerial);
            this.Name = "frmDigital";
            this.Controls.SetChildIndex(this.lblSerial, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.lblType, 0);
            this.Controls.SetChildIndex(this.lblDownload, 0);
            this.Controls.SetChildIndex(this.txtDownload, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.Label lblDownload;
    }
}
