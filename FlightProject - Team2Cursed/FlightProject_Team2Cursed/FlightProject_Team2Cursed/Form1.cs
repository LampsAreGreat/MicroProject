﻿using System;
using System.Windows.Forms;

namespace FlightProject_Team2Cursed
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllAirplanesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allRoutesbyCityNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FlightBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new AllFlights();
            form1.Show();
        }

        private void AirplaneBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new AllPlanes();
            form1.Show();
        }
    }
}
