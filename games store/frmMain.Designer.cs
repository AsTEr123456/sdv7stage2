namespace games_store
{
    partial class frmMain
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
            this.lbCatergories = new System.Windows.Forms.ListBox();
            this.lblCatergories = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCatergories
            // 
            this.lbCatergories.FormattingEnabled = true;
            this.lbCatergories.ItemHeight = 15;
            this.lbCatergories.Location = new System.Drawing.Point(32, 42);
            this.lbCatergories.Name = "lbCatergories";
            this.lbCatergories.Size = new System.Drawing.Size(217, 259);
            this.lbCatergories.TabIndex = 0;
            this.lbCatergories.DoubleClick += new System.EventHandler(this.lbCatergories_DoubleClick_1);
            // 
            // lblCatergories
            // 
            this.lblCatergories.AutoSize = true;
            this.lblCatergories.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCatergories.Location = new System.Drawing.Point(29, 13);
            this.lblCatergories.Name = "lblCatergories";
            this.lblCatergories.Size = new System.Drawing.Size(185, 19);
            this.lblCatergories.TabIndex = 1;
            this.lblCatergories.Text = "Game Catergories";
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Items.AddRange(new object[] {
            "League of Legends                        2019/5/2",
            "DOTA2                                    2019/4/20"});
            this.lbOrders.Location = new System.Drawing.Point(277, 42);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(494, 229);
            this.lbOrders.TabIndex = 2;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrders.Location = new System.Drawing.Point(274, 13);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(130, 19);
            this.lblOrders.TabIndex = 3;
            this.lblOrders.Text = "Game Orders";
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInfo.Location = new System.Drawing.Point(282, 284);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(489, 178);
            this.lblOrderInfo.TabIndex = 6;
            this.lblOrderInfo.Text = "Order Details:\r\nBuyer Name: Harry Sun\r\nGame Name: League of Legends\r\nDate Ordered" +
    ": 2019/5/2\r\nPrice Paid: $20.00\r\nType: Digital\r\nSerial Key: 1234567890\r\nDownload:" +
    " http://games.com/dl/LoL.zip";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(33, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close Program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(33, 307);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(216, 48);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete Order";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(49, 376);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Income: $0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOrderInfo);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lblCatergories);
            this.Controls.Add(this.lbCatergories);
            this.Name = "frmMain";
            this.Text = "My Game Store";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCatergories;
        private System.Windows.Forms.Label lblCatergories;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblTotal;
    }
}

