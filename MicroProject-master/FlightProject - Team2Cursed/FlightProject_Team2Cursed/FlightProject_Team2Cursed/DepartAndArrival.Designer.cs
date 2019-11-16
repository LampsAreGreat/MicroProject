﻿namespace FlightProject_Team2Cursed
{
    partial class DepartAndArrival
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AirportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FlightsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrialDepartureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CrewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AnDBox = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnDText = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenu1,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackMenu1
            // 
            this.BackMenu1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackMenu1.ForeColor = System.Drawing.Color.DarkRed;
            this.BackMenu1.Name = "BackMenu1";
            this.BackMenu1.Size = new System.Drawing.Size(48, 20);
            this.BackMenu1.Text = "Back";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AirportsMenu,
            this.FlightsMenu,
            this.RoutesMenu,
            this.LogsMenu,
            this.ArrialDepartureMenu,
            this.CrewMenu});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // AirportsMenu
            // 
            this.AirportsMenu.Name = "AirportsMenu";
            this.AirportsMenu.Size = new System.Drawing.Size(262, 22);
            this.AirportsMenu.Text = "View All Airports";
            // 
            // FlightsMenu
            // 
            this.FlightsMenu.Name = "FlightsMenu";
            this.FlightsMenu.Size = new System.Drawing.Size(262, 22);
            this.FlightsMenu.Text = "View All Flights";
            // 
            // RoutesMenu
            // 
            this.RoutesMenu.Name = "RoutesMenu";
            this.RoutesMenu.Size = new System.Drawing.Size(262, 22);
            this.RoutesMenu.Text = "View All Airplanes";
            // 
            // LogsMenu
            // 
            this.LogsMenu.Name = "LogsMenu";
            this.LogsMenu.Size = new System.Drawing.Size(262, 22);
            this.LogsMenu.Text = "View All Routes (by City Name)";
            // 
            // ArrialDepartureMenu
            // 
            this.ArrialDepartureMenu.Name = "ArrialDepartureMenu";
            this.ArrialDepartureMenu.Size = new System.Drawing.Size(262, 22);
            this.ArrialDepartureMenu.Text = "View Maintenance Logs";
            // 
            // CrewMenu
            // 
            this.CrewMenu.Name = "CrewMenu";
            this.CrewMenu.Size = new System.Drawing.Size(262, 22);
            this.CrewMenu.Text = "Search Crew by Flight#";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(107, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seach Arrial and Departure Cities by Flight#";
            // 
            // AnDBox
            // 
            this.AnDBox.FormattingEnabled = true;
            this.AnDBox.Location = new System.Drawing.Point(12, 54);
            this.AnDBox.Name = "AnDBox";
            this.AnDBox.Size = new System.Drawing.Size(476, 420);
            this.AnDBox.TabIndex = 18;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkRed;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(12, 492);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(242, 29);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back to Main Menu";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(487, 492);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(242, 29);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(545, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Flight Number";
            // 
            // AnDText
            // 
            this.AnDText.Location = new System.Drawing.Point(548, 65);
            this.AnDText.Name = "AnDText";
            this.AnDText.Size = new System.Drawing.Size(145, 20);
            this.AnDText.TabIndex = 22;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(548, 107);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(145, 29);
            this.SubmitBtn.TabIndex = 23;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DepartAndArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightProject_Team2Cursed.Properties.Resources.PlaneBackground;
            this.ClientSize = new System.Drawing.Size(741, 533);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.AnDText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AnDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DepartAndArrival";
            this.Text = "Crew";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackMenu1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AirportsMenu;
        private System.Windows.Forms.ToolStripMenuItem FlightsMenu;
        private System.Windows.Forms.ToolStripMenuItem RoutesMenu;
        private System.Windows.Forms.ToolStripMenuItem LogsMenu;
        private System.Windows.Forms.ToolStripMenuItem ArrialDepartureMenu;
        private System.Windows.Forms.ToolStripMenuItem CrewMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AnDBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnDText;
        private System.Windows.Forms.Button SubmitBtn;
    }
}