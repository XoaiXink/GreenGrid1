﻿using System.Linq;

namespace Green_Grid
{
    partial class GreeenGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreeenGrid));
            this.lblLine = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.bRedo = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.bUndo = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblLastMove = new System.Windows.Forms.Label();
            this.lblRedScore = new System.Windows.Forms.Label();
            this.lblYellowScore = new System.Windows.Forms.Label();
            this.btnTurn = new Green_Grid.RoundButton();
            this.btnOutLine = new Green_Grid.RoundButton();
            this.lnlTurn = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.tblGreeenGrid = new System.Windows.Forms.TableLayoutPanel();
            this.b71 = new Green_Grid.RoundButton();
            this.b31 = new Green_Grid.RoundButton();
            this.b61 = new Green_Grid.RoundButton();
            this.b11 = new Green_Grid.RoundButton();
            this.b51 = new Green_Grid.RoundButton();
            this.b41 = new Green_Grid.RoundButton();
            this.b21 = new Green_Grid.RoundButton();
            this.b16 = new Green_Grid.RoundButton();
            this.b32 = new Green_Grid.RoundButton();
            this.b12 = new Green_Grid.RoundButton();
            this.b22 = new Green_Grid.RoundButton();
            this.b26 = new Green_Grid.RoundButton();
            this.b52 = new Green_Grid.RoundButton();
            this.b42 = new Green_Grid.RoundButton();
            this.b72 = new Green_Grid.RoundButton();
            this.b62 = new Green_Grid.RoundButton();
            this.b23 = new Green_Grid.RoundButton();
            this.b24 = new Green_Grid.RoundButton();
            this.b36 = new Green_Grid.RoundButton();
            this.b46 = new Green_Grid.RoundButton();
            this.b63 = new Green_Grid.RoundButton();
            this.b15 = new Green_Grid.RoundButton();
            this.b13 = new Green_Grid.RoundButton();
            this.b56 = new Green_Grid.RoundButton();
            this.b66 = new Green_Grid.RoundButton();
            this.b73 = new Green_Grid.RoundButton();
            this.b74 = new Green_Grid.RoundButton();
            this.b53 = new Green_Grid.RoundButton();
            this.b33 = new Green_Grid.RoundButton();
            this.b76 = new Green_Grid.RoundButton();
            this.b64 = new Green_Grid.RoundButton();
            this.b25 = new Green_Grid.RoundButton();
            this.b65 = new Green_Grid.RoundButton();
            this.b43 = new Green_Grid.RoundButton();
            this.b54 = new Green_Grid.RoundButton();
            this.b35 = new Green_Grid.RoundButton();
            this.b14 = new Green_Grid.RoundButton();
            this.b44 = new Green_Grid.RoundButton();
            this.b45 = new Green_Grid.RoundButton();
            this.b55 = new Green_Grid.RoundButton();
            this.b34 = new Green_Grid.RoundButton();
            this.b75 = new Green_Grid.RoundButton();
            this.pnlTitle.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.tblGreeenGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.Black;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLine.ForeColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(0, 0);
            this.lblLine.Margin = new System.Windows.Forms.Padding(0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(4, 518);
            this.lblLine.TabIndex = 3;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.bRedo);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnTheme);
            this.pnlTitle.Controls.Add(this.bUndo);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(4, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(244, 136);
            this.pnlTitle.TabIndex = 4;
            // 
            // bRedo
            // 
            this.bRedo.BackColor = System.Drawing.Color.Bisque;
            this.bRedo.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.bRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRedo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.bRedo.Image = ((System.Drawing.Image)(resources.GetObject("bRedo.Image")));
            this.bRedo.Location = new System.Drawing.Point(189, 3);
            this.bRedo.Name = "bRedo";
            this.bRedo.Size = new System.Drawing.Size(52, 27);
            this.bRedo.TabIndex = 90;
            this.bRedo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bRedo.UseVisualStyleBackColor = false;
            this.bRedo.Click += new System.EventHandler(this.bRedo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(23, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 48);
            this.lblTitle.TabIndex = 88;
            this.lblTitle.Text = "GREEN GRID";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.Bisque;
            this.btnTheme.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnTheme.Image")));
            this.btnTheme.Location = new System.Drawing.Point(6, 3);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(41, 27);
            this.btnTheme.TabIndex = 76;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // bUndo
            // 
            this.bUndo.BackColor = System.Drawing.Color.Bisque;
            this.bUndo.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.bUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUndo.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUndo.Image = ((System.Drawing.Image)(resources.GetObject("bUndo.Image")));
            this.bUndo.Location = new System.Drawing.Point(133, 3);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(57, 27);
            this.bUndo.TabIndex = 76;
            this.bUndo.UseVisualStyleBackColor = false;
            this.bUndo.Click += new System.EventHandler(this.bUndo_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.OldLace;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.tblButtons);
            this.pnlInfo.Controls.Add(this.pnlStats);
            this.pnlInfo.Controls.Add(this.pnlTitle);
            this.pnlInfo.Controls.Add(this.lblLine);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(607, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(250, 520);
            this.pnlInfo.TabIndex = 0;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButtons.Controls.Add(this.btnRestart, 1, 1);
            this.tblButtons.Controls.Add(this.btnHome, 1, 2);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(4, 277);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 5;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtons.Size = new System.Drawing.Size(244, 241);
            this.tblButtons.TabIndex = 80;
            this.tblButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tblButtons_Paint);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRestart.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(64, 27);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(116, 54);
            this.btnRestart.TabIndex = 73;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Font = new System.Drawing.Font("Gadugi", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(64, 87);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 54);
            this.btnHome.TabIndex = 74;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblLastMove);
            this.pnlStats.Controls.Add(this.lblRedScore);
            this.pnlStats.Controls.Add(this.lblYellowScore);
            this.pnlStats.Controls.Add(this.btnTurn);
            this.pnlStats.Controls.Add(this.btnOutLine);
            this.pnlStats.Controls.Add(this.lnlTurn);
            this.pnlStats.Controls.Add(this.lblMove);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(4, 136);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(244, 141);
            this.pnlStats.TabIndex = 5;
            // 
            // lblLastMove
            // 
            this.lblLastMove.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMove.Location = new System.Drawing.Point(-7, 109);
            this.lblLastMove.Name = "lblLastMove";
            this.lblLastMove.Size = new System.Drawing.Size(240, 28);
            this.lblLastMove.TabIndex = 92;
            this.lblLastMove.Text = "Last Move : N/A";
            this.lblLastMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRedScore
            // 
            this.lblRedScore.AutoSize = true;
            this.lblRedScore.BackColor = System.Drawing.Color.Transparent;
            this.lblRedScore.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedScore.ForeColor = System.Drawing.Color.Red;
            this.lblRedScore.Location = new System.Drawing.Point(14, 1);
            this.lblRedScore.Name = "lblRedScore";
            this.lblRedScore.Size = new System.Drawing.Size(128, 38);
            this.lblRedScore.TabIndex = 91;
            this.lblRedScore.Text = "Tree : 0";
            this.lblRedScore.Click += new System.EventHandler(this.lblRedScore_Click);
            // 
            // lblYellowScore
            // 
            this.lblYellowScore.AutoSize = true;
            this.lblYellowScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYellowScore.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellowScore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblYellowScore.Location = new System.Drawing.Point(111, 1);
            this.lblYellowScore.Name = "lblYellowScore";
            this.lblYellowScore.Size = new System.Drawing.Size(173, 38);
            this.lblYellowScore.TabIndex = 90;
            this.lblYellowScore.Text = "Recycle : 0";
            // 
            // btnTurn
            // 
            this.btnTurn.BackgroundImage = global::GreenGrid1.Properties.Resources.tree;
            this.btnTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurn.FlatAppearance.BorderSize = 0;
            this.btnTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurn.Location = new System.Drawing.Point(146, 67);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(44, 44);
            this.btnTurn.TabIndex = 89;
            this.btnTurn.UseVisualStyleBackColor = false;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // btnOutLine
            // 
            this.btnOutLine.BackColor = System.Drawing.Color.Black;
            this.btnOutLine.FlatAppearance.BorderSize = 0;
            this.btnOutLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOutLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOutLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutLine.Location = new System.Drawing.Point(146, 72);
            this.btnOutLine.Name = "btnOutLine";
            this.btnOutLine.Size = new System.Drawing.Size(34, 34);
            this.btnOutLine.TabIndex = 88;
            this.btnOutLine.UseVisualStyleBackColor = false;
            // 
            // lnlTurn
            // 
            this.lnlTurn.AutoSize = true;
            this.lnlTurn.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTurn.Location = new System.Drawing.Point(61, 74);
            this.lnlTurn.Name = "lnlTurn";
            this.lnlTurn.Size = new System.Drawing.Size(121, 48);
            this.lnlTurn.TabIndex = 87;
            this.lnlTurn.Text = "Turn :";
            // 
            // lblMove
            // 
            this.lblMove.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(1, 34);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(240, 31);
            this.lblMove.TabIndex = 86;
            this.lblMove.Text = "Move : 0";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblGreeenGrid
            // 
            this.tblGreeenGrid.BackColor = System.Drawing.Color.Transparent;
            this.tblGreeenGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblGreeenGrid.ColumnCount = 15;
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8069F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253491F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8069F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253491F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8069F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253491F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.80689F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253491F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8069F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253493F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8069F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5253491F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.80689F));
            this.tblGreeenGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.1996008F));
            this.tblGreeenGrid.Controls.Add(this.b71, 13, 11);
            this.tblGreeenGrid.Controls.Add(this.b31, 5, 11);
            this.tblGreeenGrid.Controls.Add(this.b61, 11, 11);
            this.tblGreeenGrid.Controls.Add(this.b11, 1, 11);
            this.tblGreeenGrid.Controls.Add(this.b51, 9, 11);
            this.tblGreeenGrid.Controls.Add(this.b41, 7, 11);
            this.tblGreeenGrid.Controls.Add(this.b21, 3, 11);
            this.tblGreeenGrid.Controls.Add(this.b16, 1, 1);
            this.tblGreeenGrid.Controls.Add(this.b32, 5, 9);
            this.tblGreeenGrid.Controls.Add(this.b12, 1, 9);
            this.tblGreeenGrid.Controls.Add(this.b22, 3, 9);
            this.tblGreeenGrid.Controls.Add(this.b26, 3, 1);
            this.tblGreeenGrid.Controls.Add(this.b52, 9, 9);
            this.tblGreeenGrid.Controls.Add(this.b42, 7, 9);
            this.tblGreeenGrid.Controls.Add(this.b72, 13, 9);
            this.tblGreeenGrid.Controls.Add(this.b62, 11, 9);
            this.tblGreeenGrid.Controls.Add(this.b23, 3, 7);
            this.tblGreeenGrid.Controls.Add(this.b24, 3, 5);
            this.tblGreeenGrid.Controls.Add(this.b36, 5, 1);
            this.tblGreeenGrid.Controls.Add(this.b46, 7, 1);
            this.tblGreeenGrid.Controls.Add(this.b63, 11, 7);
            this.tblGreeenGrid.Controls.Add(this.b15, 1, 3);
            this.tblGreeenGrid.Controls.Add(this.b13, 1, 7);
            this.tblGreeenGrid.Controls.Add(this.b56, 9, 1);
            this.tblGreeenGrid.Controls.Add(this.b66, 11, 1);
            this.tblGreeenGrid.Controls.Add(this.b73, 13, 7);
            this.tblGreeenGrid.Controls.Add(this.b74, 13, 5);
            this.tblGreeenGrid.Controls.Add(this.b53, 9, 7);
            this.tblGreeenGrid.Controls.Add(this.b33, 5, 7);
            this.tblGreeenGrid.Controls.Add(this.b76, 13, 1);
            this.tblGreeenGrid.Controls.Add(this.b64, 11, 5);
            this.tblGreeenGrid.Controls.Add(this.b25, 3, 3);
            this.tblGreeenGrid.Controls.Add(this.b65, 11, 3);
            this.tblGreeenGrid.Controls.Add(this.b43, 7, 7);
            this.tblGreeenGrid.Controls.Add(this.b54, 9, 5);
            this.tblGreeenGrid.Controls.Add(this.b35, 5, 3);
            this.tblGreeenGrid.Controls.Add(this.b14, 1, 5);
            this.tblGreeenGrid.Controls.Add(this.b44, 7, 5);
            this.tblGreeenGrid.Controls.Add(this.b45, 7, 3);
            this.tblGreeenGrid.Controls.Add(this.b55, 9, 3);
            this.tblGreeenGrid.Controls.Add(this.b34, 5, 5);
            this.tblGreeenGrid.Controls.Add(this.b75, 13, 3);
            this.tblGreeenGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGreeenGrid.Location = new System.Drawing.Point(0, 0);
            this.tblGreeenGrid.Name = "tblGreeenGrid";
            this.tblGreeenGrid.RowCount = 13;
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.31068F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5225704F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.92233F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5225704F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.19776F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5225704F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.19776F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5225704F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.19776F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5225704F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.19775F));
            this.tblGreeenGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.2005968F));
            this.tblGreeenGrid.Size = new System.Drawing.Size(607, 520);
            this.tblGreeenGrid.TabIndex = 75;
            // 
            // b71
            // 
            this.b71.BackColor = System.Drawing.Color.OldLace;
            this.b71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b71.FlatAppearance.BorderSize = 0;
            this.b71.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b71.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b71.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b71.Location = new System.Drawing.Point(524, 433);
            this.b71.Name = "b71";
            this.b71.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b71.Size = new System.Drawing.Size(77, 77);
            this.b71.TabIndex = 147;
            this.b71.Text = "7";
            this.b71.UseVisualStyleBackColor = false;
            this.b71.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // b31
            // 
            this.b31.BackColor = System.Drawing.Color.OldLace;
            this.b31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b31.FlatAppearance.BorderSize = 0;
            this.b31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b31.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b31.Location = new System.Drawing.Point(180, 433);
            this.b31.Name = "b31";
            this.b31.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b31.Size = new System.Drawing.Size(77, 77);
            this.b31.TabIndex = 132;
            this.b31.Text = "3";
            this.b31.UseVisualStyleBackColor = false;
            this.b31.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b61
            // 
            this.b61.BackColor = System.Drawing.Color.OldLace;
            this.b61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b61.FlatAppearance.BorderSize = 0;
            this.b61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b61.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b61.Location = new System.Drawing.Point(438, 433);
            this.b61.Name = "b61";
            this.b61.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b61.Size = new System.Drawing.Size(77, 77);
            this.b61.TabIndex = 148;
            this.b61.Text = "6";
            this.b61.UseVisualStyleBackColor = false;
            this.b61.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.OldLace;
            this.b11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b11.FlatAppearance.BorderSize = 0;
            this.b11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b11.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b11.Location = new System.Drawing.Point(8, 433);
            this.b11.Name = "b11";
            this.b11.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b11.Size = new System.Drawing.Size(77, 77);
            this.b11.TabIndex = 74;
            this.b11.Text = "1";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b51
            // 
            this.b51.BackColor = System.Drawing.Color.OldLace;
            this.b51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b51.FlatAppearance.BorderSize = 0;
            this.b51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b51.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b51.Location = new System.Drawing.Point(352, 433);
            this.b51.Name = "b51";
            this.b51.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b51.Size = new System.Drawing.Size(77, 77);
            this.b51.TabIndex = 142;
            this.b51.Text = "5";
            this.b51.UseVisualStyleBackColor = false;
            this.b51.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b41
            // 
            this.b41.BackColor = System.Drawing.Color.OldLace;
            this.b41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b41.FlatAppearance.BorderSize = 0;
            this.b41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b41.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b41.Location = new System.Drawing.Point(266, 433);
            this.b41.Name = "b41";
            this.b41.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b41.Size = new System.Drawing.Size(77, 77);
            this.b41.TabIndex = 137;
            this.b41.Text = "4";
            this.b41.UseVisualStyleBackColor = false;
            this.b41.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.OldLace;
            this.b21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b21.FlatAppearance.BorderSize = 0;
            this.b21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b21.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b21.Location = new System.Drawing.Point(94, 433);
            this.b21.Name = "b21";
            this.b21.Padding = new System.Windows.Forms.Padding(0, 46, 40, 0);
            this.b21.Size = new System.Drawing.Size(77, 77);
            this.b21.TabIndex = 151;
            this.b21.Text = "2";
            this.b21.UseVisualStyleBackColor = false;
            this.b21.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b16
            // 
            this.b16.BackColor = System.Drawing.Color.OldLace;
            this.b16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b16.FlatAppearance.BorderSize = 0;
            this.b16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b16.Location = new System.Drawing.Point(8, 8);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(77, 78);
            this.b16.TabIndex = 115;
            this.b16.UseVisualStyleBackColor = false;
            this.b16.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b32
            // 
            this.b32.BackColor = System.Drawing.Color.OldLace;
            this.b32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b32.FlatAppearance.BorderSize = 0;
            this.b32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b32.Location = new System.Drawing.Point(180, 348);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(77, 77);
            this.b32.TabIndex = 133;
            this.b32.UseVisualStyleBackColor = false;
            this.b32.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.OldLace;
            this.b12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b12.FlatAppearance.BorderSize = 0;
            this.b12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b12.Location = new System.Drawing.Point(8, 348);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(77, 77);
            this.b12.TabIndex = 155;
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.OldLace;
            this.b22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b22.FlatAppearance.BorderSize = 0;
            this.b22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b22.Location = new System.Drawing.Point(94, 348);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(77, 77);
            this.b22.TabIndex = 152;
            this.b22.UseVisualStyleBackColor = false;
            this.b22.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b26
            // 
            this.b26.BackColor = System.Drawing.Color.OldLace;
            this.b26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b26.FlatAppearance.BorderSize = 0;
            this.b26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b26.Location = new System.Drawing.Point(94, 8);
            this.b26.Name = "b26";
            this.b26.Size = new System.Drawing.Size(77, 78);
            this.b26.TabIndex = 119;
            this.b26.UseVisualStyleBackColor = false;
            this.b26.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b52
            // 
            this.b52.BackColor = System.Drawing.Color.OldLace;
            this.b52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b52.FlatAppearance.BorderSize = 0;
            this.b52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b52.Location = new System.Drawing.Point(352, 348);
            this.b52.Name = "b52";
            this.b52.Size = new System.Drawing.Size(77, 77);
            this.b52.TabIndex = 143;
            this.b52.UseVisualStyleBackColor = false;
            this.b52.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b42
            // 
            this.b42.BackColor = System.Drawing.Color.OldLace;
            this.b42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b42.FlatAppearance.BorderSize = 0;
            this.b42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b42.Location = new System.Drawing.Point(266, 348);
            this.b42.Name = "b42";
            this.b42.Size = new System.Drawing.Size(77, 77);
            this.b42.TabIndex = 138;
            this.b42.UseVisualStyleBackColor = false;
            this.b42.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b72
            // 
            this.b72.BackColor = System.Drawing.Color.OldLace;
            this.b72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b72.FlatAppearance.BorderSize = 0;
            this.b72.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b72.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b72.Location = new System.Drawing.Point(524, 348);
            this.b72.Name = "b72";
            this.b72.Size = new System.Drawing.Size(77, 77);
            this.b72.TabIndex = 149;
            this.b72.UseVisualStyleBackColor = false;
            this.b72.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // b62
            // 
            this.b62.BackColor = System.Drawing.Color.OldLace;
            this.b62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b62.FlatAppearance.BorderSize = 0;
            this.b62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b62.Location = new System.Drawing.Point(438, 348);
            this.b62.Name = "b62";
            this.b62.Size = new System.Drawing.Size(77, 77);
            this.b62.TabIndex = 131;
            this.b62.UseVisualStyleBackColor = false;
            this.b62.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b23
            // 
            this.b23.BackColor = System.Drawing.Color.OldLace;
            this.b23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b23.FlatAppearance.BorderSize = 0;
            this.b23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b23.Location = new System.Drawing.Point(94, 263);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(77, 77);
            this.b23.TabIndex = 153;
            this.b23.UseVisualStyleBackColor = false;
            this.b23.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b24
            // 
            this.b24.BackColor = System.Drawing.Color.OldLace;
            this.b24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b24.FlatAppearance.BorderSize = 0;
            this.b24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b24.Location = new System.Drawing.Point(94, 178);
            this.b24.Name = "b24";
            this.b24.Size = new System.Drawing.Size(77, 77);
            this.b24.TabIndex = 154;
            this.b24.UseVisualStyleBackColor = false;
            this.b24.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b36
            // 
            this.b36.BackColor = System.Drawing.Color.OldLace;
            this.b36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b36.FlatAppearance.BorderSize = 0;
            this.b36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b36.Location = new System.Drawing.Point(180, 8);
            this.b36.Name = "b36";
            this.b36.Size = new System.Drawing.Size(77, 78);
            this.b36.TabIndex = 121;
            this.b36.UseVisualStyleBackColor = false;
            this.b36.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b46
            // 
            this.b46.BackColor = System.Drawing.Color.OldLace;
            this.b46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b46.FlatAppearance.BorderSize = 0;
            this.b46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b46.Location = new System.Drawing.Point(266, 8);
            this.b46.Name = "b46";
            this.b46.Size = new System.Drawing.Size(77, 78);
            this.b46.TabIndex = 122;
            this.b46.UseVisualStyleBackColor = false;
            this.b46.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b63
            // 
            this.b63.BackColor = System.Drawing.Color.OldLace;
            this.b63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b63.FlatAppearance.BorderSize = 0;
            this.b63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b63.Location = new System.Drawing.Point(438, 263);
            this.b63.Name = "b63";
            this.b63.Size = new System.Drawing.Size(77, 77);
            this.b63.TabIndex = 130;
            this.b63.UseVisualStyleBackColor = false;
            this.b63.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b15
            // 
            this.b15.BackColor = System.Drawing.Color.OldLace;
            this.b15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b15.FlatAppearance.BorderSize = 0;
            this.b15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b15.Location = new System.Drawing.Point(8, 94);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(77, 76);
            this.b15.TabIndex = 116;
            this.b15.UseVisualStyleBackColor = false;
            this.b15.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.OldLace;
            this.b13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b13.FlatAppearance.BorderSize = 0;
            this.b13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b13.Location = new System.Drawing.Point(8, 263);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(77, 77);
            this.b13.TabIndex = 117;
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b56
            // 
            this.b56.BackColor = System.Drawing.Color.OldLace;
            this.b56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b56.FlatAppearance.BorderSize = 0;
            this.b56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b56.Location = new System.Drawing.Point(352, 8);
            this.b56.Name = "b56";
            this.b56.Size = new System.Drawing.Size(77, 78);
            this.b56.TabIndex = 123;
            this.b56.UseVisualStyleBackColor = false;
            this.b56.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b66
            // 
            this.b66.BackColor = System.Drawing.Color.OldLace;
            this.b66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b66.FlatAppearance.BorderSize = 0;
            this.b66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b66.Location = new System.Drawing.Point(438, 8);
            this.b66.Name = "b66";
            this.b66.Size = new System.Drawing.Size(77, 78);
            this.b66.TabIndex = 124;
            this.b66.UseVisualStyleBackColor = false;
            this.b66.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b73
            // 
            this.b73.BackColor = System.Drawing.Color.OldLace;
            this.b73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b73.FlatAppearance.BorderSize = 0;
            this.b73.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b73.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b73.Location = new System.Drawing.Point(524, 263);
            this.b73.Name = "b73";
            this.b73.Size = new System.Drawing.Size(77, 77);
            this.b73.TabIndex = 139;
            this.b73.UseVisualStyleBackColor = false;
            this.b73.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // b74
            // 
            this.b74.BackColor = System.Drawing.Color.OldLace;
            this.b74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b74.FlatAppearance.BorderSize = 0;
            this.b74.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b74.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b74.Location = new System.Drawing.Point(524, 178);
            this.b74.Name = "b74";
            this.b74.Size = new System.Drawing.Size(77, 77);
            this.b74.TabIndex = 129;
            this.b74.UseVisualStyleBackColor = false;
            this.b74.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // b53
            // 
            this.b53.BackColor = System.Drawing.Color.OldLace;
            this.b53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b53.FlatAppearance.BorderSize = 0;
            this.b53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b53.Location = new System.Drawing.Point(352, 263);
            this.b53.Name = "b53";
            this.b53.Size = new System.Drawing.Size(77, 77);
            this.b53.TabIndex = 144;
            this.b53.UseVisualStyleBackColor = false;
            this.b53.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b33
            // 
            this.b33.BackColor = System.Drawing.Color.OldLace;
            this.b33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b33.FlatAppearance.BorderSize = 0;
            this.b33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b33.Location = new System.Drawing.Point(180, 263);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(77, 77);
            this.b33.TabIndex = 134;
            this.b33.UseVisualStyleBackColor = false;
            this.b33.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b76
            // 
            this.b76.BackColor = System.Drawing.Color.OldLace;
            this.b76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b76.FlatAppearance.BorderSize = 0;
            this.b76.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b76.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b76.Location = new System.Drawing.Point(524, 8);
            this.b76.Name = "b76";
            this.b76.Size = new System.Drawing.Size(77, 78);
            this.b76.TabIndex = 125;
            this.b76.UseVisualStyleBackColor = false;
            this.b76.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // b64
            // 
            this.b64.BackColor = System.Drawing.Color.OldLace;
            this.b64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b64.FlatAppearance.BorderSize = 0;
            this.b64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b64.Location = new System.Drawing.Point(438, 178);
            this.b64.Name = "b64";
            this.b64.Size = new System.Drawing.Size(77, 77);
            this.b64.TabIndex = 128;
            this.b64.UseVisualStyleBackColor = false;
            this.b64.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b25
            // 
            this.b25.BackColor = System.Drawing.Color.OldLace;
            this.b25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b25.FlatAppearance.BorderSize = 0;
            this.b25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b25.Location = new System.Drawing.Point(94, 94);
            this.b25.Name = "b25";
            this.b25.Size = new System.Drawing.Size(77, 76);
            this.b25.TabIndex = 120;
            this.b25.UseVisualStyleBackColor = false;
            this.b25.Click += new System.EventHandler(this.BtnColumn2_Click);
            // 
            // b65
            // 
            this.b65.BackColor = System.Drawing.Color.OldLace;
            this.b65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b65.FlatAppearance.BorderSize = 0;
            this.b65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b65.Location = new System.Drawing.Point(438, 94);
            this.b65.Name = "b65";
            this.b65.Size = new System.Drawing.Size(77, 76);
            this.b65.TabIndex = 126;
            this.b65.UseVisualStyleBackColor = false;
            this.b65.Click += new System.EventHandler(this.btnColumn6_Click);
            // 
            // b43
            // 
            this.b43.BackColor = System.Drawing.Color.OldLace;
            this.b43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b43.FlatAppearance.BorderSize = 0;
            this.b43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b43.Location = new System.Drawing.Point(266, 263);
            this.b43.Name = "b43";
            this.b43.Size = new System.Drawing.Size(77, 77);
            this.b43.TabIndex = 141;
            this.b43.UseVisualStyleBackColor = false;
            this.b43.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b54
            // 
            this.b54.BackColor = System.Drawing.Color.OldLace;
            this.b54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b54.FlatAppearance.BorderSize = 0;
            this.b54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b54.Location = new System.Drawing.Point(352, 178);
            this.b54.Name = "b54";
            this.b54.Size = new System.Drawing.Size(77, 77);
            this.b54.TabIndex = 145;
            this.b54.UseVisualStyleBackColor = false;
            this.b54.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b35
            // 
            this.b35.BackColor = System.Drawing.Color.OldLace;
            this.b35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b35.FlatAppearance.BorderSize = 0;
            this.b35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b35.Location = new System.Drawing.Point(180, 94);
            this.b35.Name = "b35";
            this.b35.Size = new System.Drawing.Size(77, 76);
            this.b35.TabIndex = 136;
            this.b35.UseVisualStyleBackColor = false;
            this.b35.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.OldLace;
            this.b14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b14.FlatAppearance.BorderSize = 0;
            this.b14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b14.Location = new System.Drawing.Point(8, 178);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(77, 77);
            this.b14.TabIndex = 118;
            this.b14.UseVisualStyleBackColor = false;
            this.b14.Click += new System.EventHandler(this.BtnColumn1_Click);
            // 
            // b44
            // 
            this.b44.BackColor = System.Drawing.Color.OldLace;
            this.b44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b44.FlatAppearance.BorderSize = 0;
            this.b44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b44.Location = new System.Drawing.Point(266, 178);
            this.b44.Name = "b44";
            this.b44.Size = new System.Drawing.Size(77, 77);
            this.b44.TabIndex = 140;
            this.b44.UseVisualStyleBackColor = false;
            this.b44.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b45
            // 
            this.b45.BackColor = System.Drawing.Color.OldLace;
            this.b45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b45.FlatAppearance.BorderSize = 0;
            this.b45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b45.Location = new System.Drawing.Point(266, 94);
            this.b45.Name = "b45";
            this.b45.Size = new System.Drawing.Size(77, 76);
            this.b45.TabIndex = 150;
            this.b45.UseVisualStyleBackColor = false;
            this.b45.Click += new System.EventHandler(this.BtnColumn4_Click);
            // 
            // b55
            // 
            this.b55.BackColor = System.Drawing.Color.OldLace;
            this.b55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b55.FlatAppearance.BorderSize = 0;
            this.b55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b55.Location = new System.Drawing.Point(352, 94);
            this.b55.Name = "b55";
            this.b55.Size = new System.Drawing.Size(77, 76);
            this.b55.TabIndex = 146;
            this.b55.UseVisualStyleBackColor = false;
            this.b55.Click += new System.EventHandler(this.BtnColumn5_Click);
            // 
            // b34
            // 
            this.b34.BackColor = System.Drawing.Color.OldLace;
            this.b34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b34.FlatAppearance.BorderSize = 0;
            this.b34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b34.Location = new System.Drawing.Point(180, 178);
            this.b34.Name = "b34";
            this.b34.Size = new System.Drawing.Size(77, 77);
            this.b34.TabIndex = 135;
            this.b34.UseVisualStyleBackColor = false;
            this.b34.Click += new System.EventHandler(this.BtnColumn3_Click);
            // 
            // b75
            // 
            this.b75.BackColor = System.Drawing.Color.OldLace;
            this.b75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b75.FlatAppearance.BorderSize = 0;
            this.b75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace;
            this.b75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.b75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b75.Location = new System.Drawing.Point(524, 94);
            this.b75.Name = "b75";
            this.b75.Size = new System.Drawing.Size(77, 76);
            this.b75.TabIndex = 127;
            this.b75.UseVisualStyleBackColor = false;
            this.b75.Click += new System.EventHandler(this.btnColumn7_Click);
            // 
            // GreeenGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GreenGrid1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 520);
            this.Controls.Add(this.tblGreeenGrid);
            this.Controls.Add(this.pnlInfo);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1400, 1000);
            this.MinimumSize = new System.Drawing.Size(788, 481);
            this.Name = "GreeenGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREENGRID";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GreeenGrid_KeyDown);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.tblButtons.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.tblGreeenGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblRedScore;
        private System.Windows.Forms.Label lblYellowScore;
        private RoundButton btnTurn;
        private RoundButton btnOutLine;
        private System.Windows.Forms.Label lnlTurn;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TableLayoutPanel tblGreeenGrid;
        private RoundButton b71;
        private RoundButton b31;
        private RoundButton b61;
        private RoundButton b11;
        private RoundButton b51;
        private RoundButton b41;
        private RoundButton b21;
        private RoundButton b16;
        private RoundButton b32;
        private RoundButton b12;
        private RoundButton b22;
        private RoundButton b26;
        private RoundButton b52;
        private RoundButton b42;
        private RoundButton b72;
        private RoundButton b62;
        private RoundButton b23;
        private RoundButton b24;
        private RoundButton b36;
        private RoundButton b46;
        private RoundButton b63;
        private RoundButton b15;
        private RoundButton b13;
        private RoundButton b56;
        private RoundButton b66;
        private RoundButton b73;
        private RoundButton b74;
        private RoundButton b53;
        private RoundButton b33;
        private RoundButton b76;
        private RoundButton b64;
        private RoundButton b25;
        private RoundButton b65;
        private RoundButton b43;
        private RoundButton b54;
        private RoundButton b35;
        private RoundButton b14;
        private RoundButton b44;
        private RoundButton b45;
        private RoundButton b55;
        private RoundButton b34;
        private RoundButton b75;
        private System.Windows.Forms.Button bRedo;
        private System.Windows.Forms.Label lblLastMove;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button bUndo;
    }
}