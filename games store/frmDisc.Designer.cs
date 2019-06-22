namespace games_store
{
    partial class frmDisc
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(165, 203);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(208, 25);
            this.txtWeight.TabIndex = 14;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 206);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(119, 15);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight(grams):";
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(165, 239);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(208, 25);
            this.txtShipping.TabIndex = 16;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(12, 242);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(95, 15);
            this.lblShipping.TabIndex = 15;
            this.lblShipping.Text = "Shipping $:";
            // 
            // frmDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(394, 440);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "frmDisc";
            this.Controls.SetChildIndex(this.lblWeight, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.Controls.SetChildIndex(this.lblShipping, 0);
            this.Controls.SetChildIndex(this.txtShipping, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.Label lblShipping;
    }
}
