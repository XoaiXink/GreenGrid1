using GreenGrid1;
namespace Green_Grid

{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnPlayWithBots = new System.Windows.Forms.Button();
            this.btn2Players = new System.Windows.Forms.Button();
            this.lblConnectF = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayWithBots
            // 
            this.btnPlayWithBots.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPlayWithBots.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayWithBots.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPlayWithBots.Location = new System.Drawing.Point(288, 385);
            this.btnPlayWithBots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayWithBots.Name = "btnPlayWithBots";
            this.btnPlayWithBots.Size = new System.Drawing.Size(137, 62);
            this.btnPlayWithBots.TabIndex = 1;
            this.btnPlayWithBots.Text = "PLAY WITH BOTS";
            this.btnPlayWithBots.UseVisualStyleBackColor = false;
            this.btnPlayWithBots.Click += new System.EventHandler(this.btnPlayWithBots_Click);
            // 
            // btn2Players
            // 
            this.btn2Players.BackColor = System.Drawing.Color.PowderBlue;
            this.btn2Players.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Players.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn2Players.Location = new System.Drawing.Point(493, 385);
            this.btn2Players.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2Players.Name = "btn2Players";
            this.btn2Players.Size = new System.Drawing.Size(138, 62);
            this.btn2Players.TabIndex = 2;
            this.btn2Players.Text = "2 PLAYERS";
            this.btn2Players.UseVisualStyleBackColor = false;
            this.btn2Players.Click += new System.EventHandler(this.btn2Players_Click);
            // 
            // lblConnectF
            // 
            this.lblConnectF.BackColor = System.Drawing.Color.LightBlue;
            this.lblConnectF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectF.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblConnectF.Location = new System.Drawing.Point(266, 150);
            this.lblConnectF.Name = "lblConnectF";
            this.lblConnectF.Size = new System.Drawing.Size(387, 78);
            this.lblConnectF.TabIndex = 3;
            this.lblConnectF.Text = "GREEN GRID";
            this.lblConnectF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnInfo.Location = new System.Drawing.Point(386, 247);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(138, 62);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "ABOUT";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHowToPlay.Location = new System.Drawing.Point(386, 316);
            this.btnHowToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(138, 62);
            this.btnHowToPlay.TabIndex = 5;
            this.btnHowToPlay.Text = "HOW TO PLAY";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.Transparent;
            this.btnAudio.Image = global::GreenGrid1.Properties.Resources.sound_on;
            this.btnAudio.Location = new System.Drawing.Point(747, 125);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(63, 47);
            this.btnAudio.TabIndex = 6;
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::GreenGrid1.Properties.Resources.background_home;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 635);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblConnectF);
            this.Controls.Add(this.btn2Players);
            this.Controls.Add(this.btnPlayWithBots);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1569, 1224);
            this.MinimumSize = new System.Drawing.Size(880, 575);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlayWithBots;
        private System.Windows.Forms.Button btn2Players;
        private System.Windows.Forms.Label lblConnectF;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnAudio;
    }
}