namespace FlightProject_Team2Cursed
{
    partial class Crew
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
            this.CrewBox = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CrewText = new System.Windows.Forms.TextBox();
            this.SubmitBtn2 = new System.Windows.Forms.Button();
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
            this.AirportsMenu.Size = new System.Drawing.Size(342, 22);
            this.AirportsMenu.Text = "View All Airports";
            // 
            // FlightsMenu
            // 
            this.FlightsMenu.Name = "FlightsMenu";
            this.FlightsMenu.Size = new System.Drawing.Size(342, 22);
            this.FlightsMenu.Text = "View All Flights";
            // 
            // RoutesMenu
            // 
            this.RoutesMenu.Name = "RoutesMenu";
            this.RoutesMenu.Size = new System.Drawing.Size(342, 22);
            this.RoutesMenu.Text = "View All Airplanes";
            // 
            // LogsMenu
            // 
            this.LogsMenu.Name = "LogsMenu";
            this.LogsMenu.Size = new System.Drawing.Size(342, 22);
            this.LogsMenu.Text = "View All Routes (by City Name)";
            // 
            // ArrialDepartureMenu
            // 
            this.ArrialDepartureMenu.Name = "ArrialDepartureMenu";
            this.ArrialDepartureMenu.Size = new System.Drawing.Size(342, 22);
            this.ArrialDepartureMenu.Text = "View Maintenance Logs";
            // 
            // CrewMenu
            // 
            this.CrewMenu.Name = "CrewMenu";
            this.CrewMenu.Size = new System.Drawing.Size(342, 22);
            this.CrewMenu.Text = "Seach Arrial and Departure Cities by Flight#";
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
            this.label1.Location = new System.Drawing.Point(199, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Crew by Flight#";
            // 
            // CrewBox
            // 
            this.CrewBox.FormattingEnabled = true;
            this.CrewBox.Location = new System.Drawing.Point(12, 53);
            this.CrewBox.Name = "CrewBox";
            this.CrewBox.Size = new System.Drawing.Size(476, 420);
            this.CrewBox.TabIndex = 19;
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
            this.BackBtn.TabIndex = 20;
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
            this.ExitBtn.TabIndex = 21;
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
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter Flight Number";
            // 
            // CrewText
            // 
            this.CrewText.Location = new System.Drawing.Point(548, 65);
            this.CrewText.Name = "CrewText";
            this.CrewText.Size = new System.Drawing.Size(145, 20);
            this.CrewText.TabIndex = 23;
            // 
            // SubmitBtn2
            // 
            this.SubmitBtn2.BackColor = System.Drawing.Color.DarkRed;
            this.SubmitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitBtn2.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn2.Location = new System.Drawing.Point(548, 108);
            this.SubmitBtn2.Name = "SubmitBtn2";
            this.SubmitBtn2.Size = new System.Drawing.Size(145, 29);
            this.SubmitBtn2.TabIndex = 24;
            this.SubmitBtn2.Text = "Submit";
            this.SubmitBtn2.UseVisualStyleBackColor = false;
            this.SubmitBtn2.Click += new System.EventHandler(this.SubmitBtn2_Click);
            // 
            // Crew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightProject_Team2Cursed.Properties.Resources.PlaneBackground;
            this.ClientSize = new System.Drawing.Size(741, 533);
            this.Controls.Add(this.SubmitBtn2);
            this.Controls.Add(this.CrewText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CrewBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Crew";
            this.Text = "DepartAndArrivalLocations";
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
        private System.Windows.Forms.ListBox CrewBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CrewText;
        private System.Windows.Forms.Button SubmitBtn2;
    }
}