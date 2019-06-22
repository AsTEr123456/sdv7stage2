namespace games_store
{
    partial class frmGames
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
            this.lbGames = new System.Windows.Forms.ListBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.ItemHeight = 15;
            this.lbGames.Location = new System.Drawing.Point(12, 31);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(314, 169);
            this.lbGames.TabIndex = 0;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            this.lbGames.DoubleClick += new System.EventHandler(this.lbGames_DoubleClick);
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGames.Location = new System.Drawing.Point(12, 9);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(163, 19);
            this.lblGames.TabIndex = 2;
            this.lblGames.Text = "Games For Sale";
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Location = new System.Drawing.Point(12, 255);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(314, 44);
            this.btnDeleteGame.TabIndex = 7;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(12, 205);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(163, 44);
            this.btnAddGame.TabIndex = 6;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInfo.Location = new System.Drawing.Point(348, 31);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(440, 313);
            this.lblGameInfo.TabIndex = 8;
            this.lblGameInfo.Text = "Game Details:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 305);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(314, 44);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "digi",
            "disc"});
            this.cmbType.Location = new System.Drawing.Point(186, 214);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(139, 23);
            this.cmbType.TabIndex = 10;
            this.cmbType.Text = "digi";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 2000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lbGames);
            this.Name = "frmGames";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}