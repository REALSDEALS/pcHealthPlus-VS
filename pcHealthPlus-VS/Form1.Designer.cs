﻿namespace pcHealthPlus_VS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.programMenu = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLabel = new System.Windows.Forms.Label();
            this.labelTimer1 = new System.Windows.Forms.Timer(this.components);
            this.colourMenuPanel1 = new System.Windows.Forms.Panel();
            this.logoHolderInMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programNameInMenu = new System.Windows.Forms.Label();
            this.programMenu.SuspendLayout();
            this.colourMenuPanel1.SuspendLayout();
            this.logoHolderInMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // programMenu
            // 
            this.programMenu.BackColor = System.Drawing.Color.White;
            this.programMenu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.programMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.helpMenuButton,
            this.aboutToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.programMenu.Location = new System.Drawing.Point(0, 0);
            this.programMenu.Name = "programMenu";
            this.programMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 5);
            this.programMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.programMenu.Size = new System.Drawing.Size(933, 30);
            this.programMenu.TabIndex = 0;
            this.programMenu.Text = "Menu";
            this.programMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.programMenu_ItemClicked);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_onClick);
            // 
            // helpMenuButton
            // 
            this.helpMenuButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenuButton.Name = "helpMenuButton";
            this.helpMenuButton.Size = new System.Drawing.Size(55, 23);
            this.helpMenuButton.Text = "&Help";
            this.helpMenuButton.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.gitHubToolStripMenuItem.Text = "&GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.programsToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.programsToolStripMenuItem.Text = "&Programs";
            this.programsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.programsToolStripMenuItem.Click += new System.EventHandler(this.programsToolStripMenuItem_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(12, 4);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 23);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "systemTime";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel.Click += new System.EventHandler(this.label1_timeLoad);
            // 
            // labelTimer1
            // 
            this.labelTimer1.Enabled = true;
            this.labelTimer1.Tick += new System.EventHandler(this.timeLabel_timer1);
            // 
            // colourMenuPanel1
            // 
            this.colourMenuPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.colourMenuPanel1.Controls.Add(this.logoHolderInMenu);
            this.colourMenuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.colourMenuPanel1.Location = new System.Drawing.Point(0, 30);
            this.colourMenuPanel1.Name = "colourMenuPanel1";
            this.colourMenuPanel1.Size = new System.Drawing.Size(225, 524);
            this.colourMenuPanel1.TabIndex = 2;
            // 
            // logoHolderInMenu
            // 
            this.logoHolderInMenu.Controls.Add(this.programNameInMenu);
            this.logoHolderInMenu.Controls.Add(this.pictureBox1);
            this.logoHolderInMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoHolderInMenu.Location = new System.Drawing.Point(0, 0);
            this.logoHolderInMenu.Name = "logoHolderInMenu";
            this.logoHolderInMenu.Size = new System.Drawing.Size(225, 100);
            this.logoHolderInMenu.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // programNameInMenu
            // 
            this.programNameInMenu.AutoSize = true;
            this.programNameInMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameInMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.programNameInMenu.Location = new System.Drawing.Point(95, 35);
            this.programNameInMenu.Name = "programNameInMenu";
            this.programNameInMenu.Size = new System.Drawing.Size(119, 25);
            this.programNameInMenu.TabIndex = 1;
            this.programNameInMenu.Text = "pcHealthPlus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.colourMenuPanel1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.programMenu);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.programMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "pcHealthPlus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.programMenu.ResumeLayout(false);
            this.programMenu.PerformLayout();
            this.colourMenuPanel1.ResumeLayout(false);
            this.logoHolderInMenu.ResumeLayout(false);
            this.logoHolderInMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip programMenu;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuButton;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer labelTimer1;
        private System.Windows.Forms.Panel colourMenuPanel1;
        private System.Windows.Forms.Panel logoHolderInMenu;
        private System.Windows.Forms.Label programNameInMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

