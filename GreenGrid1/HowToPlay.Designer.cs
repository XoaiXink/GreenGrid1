using System.Windows.Forms;

namespace Green_Grid
{
    partial class HowToPlay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.pnlHow = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHow = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlHow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHow
            // 
            this.pnlHow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlHow.Controls.Add(this.btnExit);
            this.pnlHow.Controls.Add(this.lblHow);
            this.pnlHow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHow.Location = new System.Drawing.Point(0, 0);
            this.pnlHow.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHow.Name = "pnlHow";
            this.pnlHow.Size = new System.Drawing.Size(599, 70);
            this.pnlHow.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(800, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHow
            // 
            this.lblHow.BackColor = System.Drawing.Color.PowderBlue;
            this.lblHow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHow.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHow.Location = new System.Drawing.Point(0, 0);
            this.lblHow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(599, 70);
            this.lblHow.TabIndex = 0;
            this.lblHow.Text = "HOW TO PLAY";
            this.lblHow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHow.Click += new System.EventHandler(this.lblHow_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.GhostWhite;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Image = ((System.Drawing.Image)(resources.GetObject("lblInstructions.Image")));
            this.lblInstructions.Location = new System.Drawing.Point(0, 70);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(599, 390);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstructions.UseCompatibleTextRendering = true;
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 460);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlHow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOWTOPLAY";
            this.pnlHow.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlHow;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstructions;
    }
}