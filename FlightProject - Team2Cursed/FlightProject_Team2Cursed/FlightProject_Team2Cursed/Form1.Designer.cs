namespace FlightProject_Team2Cursed
{
    partial class MainForm
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
            this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AirportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FlightsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AirplanesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrialDepartureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CrewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AirportBtn1 = new System.Windows.Forms.Button();
            this.FlightBtn1 = new System.Windows.Forms.Button();
            this.AirplaneBtn1 = new System.Windows.Forms.Button();
            this.RoutesBtn1 = new System.Windows.Forms.Button();
            this.LogBtn1 = new System.Windows.Forms.Button();
            this.flightNumBtn1 = new System.Windows.Forms.Button();
            this.CrewBtn1 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMenu,
            this.ExitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchMenu
            // 
            this.SearchMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.SearchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AirportsMenu,
            this.FlightsMenu,
            this.AirplanesMenu,
            this.RoutesMenu,
            this.LogsMenu,
            this.ArrialDepartureMenu,
            this.CrewMenu});
            this.SearchMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.SearchMenu.ImageTransparentColor = System.Drawing.Color.DarkTurquoise;
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(60, 20);
            this.SearchMenu.Text = "Search";
            this.SearchMenu.Click += new System.EventHandler(this.formsToolStripMenuItem_Click);
            // 
            // AirportsMenu
            // 
            this.AirportsMenu.BackColor = System.Drawing.Color.Snow;
            this.AirportsMenu.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportsMenu.ForeColor = System.Drawing.Color.Black;
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
            // AirplanesMenu
            // 
            this.AirplanesMenu.Name = "AirplanesMenu";
            this.AirplanesMenu.Size = new System.Drawing.Size(342, 22);
            this.AirplanesMenu.Text = "View All Airplanes";
            this.AirplanesMenu.Click += new System.EventHandler(this.viewAllAirplanesToolStripMenuItem_Click);
            // 
            // RoutesMenu
            // 
            this.RoutesMenu.Name = "RoutesMenu";
            this.RoutesMenu.Size = new System.Drawing.Size(342, 22);
            this.RoutesMenu.Text = "View All Routes (by City Name)";
            this.RoutesMenu.Click += new System.EventHandler(this.allRoutesbyCityNameToolStripMenuItem_Click);
            // 
            // LogsMenu
            // 
            this.LogsMenu.Name = "LogsMenu";
            this.LogsMenu.Size = new System.Drawing.Size(342, 22);
            this.LogsMenu.Text = "View Maintenance Logs";
            // 
            // ArrialDepartureMenu
            // 
            this.ArrialDepartureMenu.Name = "ArrialDepartureMenu";
            this.ArrialDepartureMenu.Size = new System.Drawing.Size(342, 22);
            this.ArrialDepartureMenu.Text = "Seach Arrial and Departure Cities by Flight#";
            // 
            // CrewMenu
            // 
            this.CrewMenu.Name = "CrewMenu";
            this.CrewMenu.Size = new System.Drawing.Size(342, 22);
            this.CrewMenu.Text = "Search Crew by Flight#";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(43, 20);
            this.ExitMenu.Text = "Exit";
            // 
            // AirportBtn1
            // 
            this.AirportBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.AirportBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirportBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportBtn1.ForeColor = System.Drawing.Color.White;
            this.AirportBtn1.Location = new System.Drawing.Point(227, 45);
            this.AirportBtn1.Name = "AirportBtn1";
            this.AirportBtn1.Size = new System.Drawing.Size(242, 35);
            this.AirportBtn1.TabIndex = 1;
            this.AirportBtn1.Text = "View All Airports";
            this.AirportBtn1.UseVisualStyleBackColor = false;
            // 
            // FlightBtn1
            // 
            this.FlightBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.FlightBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.FlightBtn1.ForeColor = System.Drawing.Color.White;
            this.FlightBtn1.Location = new System.Drawing.Point(227, 98);
            this.FlightBtn1.Name = "FlightBtn1";
            this.FlightBtn1.Size = new System.Drawing.Size(242, 35);
            this.FlightBtn1.TabIndex = 2;
            this.FlightBtn1.Text = "View All Flights";
            this.FlightBtn1.UseVisualStyleBackColor = false;
            this.FlightBtn1.Click += new System.EventHandler(this.FlightBtn1_Click);
            // 
            // AirplaneBtn1
            // 
            this.AirplaneBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.AirplaneBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirplaneBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.AirplaneBtn1.ForeColor = System.Drawing.Color.White;
            this.AirplaneBtn1.Location = new System.Drawing.Point(227, 157);
            this.AirplaneBtn1.Name = "AirplaneBtn1";
            this.AirplaneBtn1.Size = new System.Drawing.Size(242, 32);
            this.AirplaneBtn1.TabIndex = 3;
            this.AirplaneBtn1.Text = "View All Airplanes";
            this.AirplaneBtn1.UseVisualStyleBackColor = false;
            this.AirplaneBtn1.Click += new System.EventHandler(this.AirplaneBtn1_Click);
            // 
            // RoutesBtn1
            // 
            this.RoutesBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.RoutesBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoutesBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.RoutesBtn1.ForeColor = System.Drawing.Color.White;
            this.RoutesBtn1.Location = new System.Drawing.Point(227, 208);
            this.RoutesBtn1.Name = "RoutesBtn1";
            this.RoutesBtn1.Size = new System.Drawing.Size(242, 32);
            this.RoutesBtn1.TabIndex = 4;
            this.RoutesBtn1.Text = "View All Routes (City Name)";
            this.RoutesBtn1.UseVisualStyleBackColor = false;
            this.RoutesBtn1.Click += new System.EventHandler(this.RoutesBtn1_Click);
            // 
            // LogBtn1
            // 
            this.LogBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.LogBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.LogBtn1.ForeColor = System.Drawing.Color.White;
            this.LogBtn1.Location = new System.Drawing.Point(227, 260);
            this.LogBtn1.Name = "LogBtn1";
            this.LogBtn1.Size = new System.Drawing.Size(242, 28);
            this.LogBtn1.TabIndex = 5;
            this.LogBtn1.Text = "View Maintenance Logs";
            this.LogBtn1.UseVisualStyleBackColor = false;
            // 
            // flightNumBtn1
            // 
            this.flightNumBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.flightNumBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightNumBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.flightNumBtn1.ForeColor = System.Drawing.Color.White;
            this.flightNumBtn1.Location = new System.Drawing.Point(227, 312);
            this.flightNumBtn1.Name = "flightNumBtn1";
            this.flightNumBtn1.Size = new System.Drawing.Size(242, 31);
            this.flightNumBtn1.TabIndex = 6;
            this.flightNumBtn1.Text = "Seach by Flight#";
            this.flightNumBtn1.UseVisualStyleBackColor = false;
            this.flightNumBtn1.Click += new System.EventHandler(this.flightNumBtn1_Click);
            // 
            // CrewBtn1
            // 
            this.CrewBtn1.BackColor = System.Drawing.Color.DarkRed;
            this.CrewBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrewBtn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.CrewBtn1.ForeColor = System.Drawing.Color.White;
            this.CrewBtn1.Location = new System.Drawing.Point(227, 368);
            this.CrewBtn1.Name = "CrewBtn1";
            this.CrewBtn1.Size = new System.Drawing.Size(242, 30);
            this.CrewBtn1.TabIndex = 8;
            this.CrewBtn1.Text = "Search Crew by Flight#";
            this.CrewBtn1.UseVisualStyleBackColor = false;
            this.CrewBtn1.Click += new System.EventHandler(this.CrewBtn1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(227, 464);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(242, 29);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightProject_Team2Cursed.Properties.Resources.PlaneBackground;
            this.ClientSize = new System.Drawing.Size(741, 533);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CrewBtn1);
            this.Controls.Add(this.flightNumBtn1);
            this.Controls.Add(this.LogBtn1);
            this.Controls.Add(this.RoutesBtn1);
            this.Controls.Add(this.AirplaneBtn1);
            this.Controls.Add(this.FlightBtn1);
            this.Controls.Add(this.AirportBtn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem FlightsMenu;
        private System.Windows.Forms.ToolStripMenuItem AirplanesMenu;
        private System.Windows.Forms.ToolStripMenuItem RoutesMenu;
        private System.Windows.Forms.ToolStripMenuItem AirportsMenu;
        private System.Windows.Forms.ToolStripMenuItem LogsMenu;
        private System.Windows.Forms.ToolStripMenuItem ArrialDepartureMenu;
        private System.Windows.Forms.ToolStripMenuItem CrewMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.Button AirportBtn1;
        private System.Windows.Forms.Button FlightBtn1;
        private System.Windows.Forms.Button AirplaneBtn1;
        private System.Windows.Forms.Button RoutesBtn1;
        private System.Windows.Forms.Button LogBtn1;
        private System.Windows.Forms.Button flightNumBtn1;
        private System.Windows.Forms.Button CrewBtn1;
        private System.Windows.Forms.Button ExitBtn;
    }
}

