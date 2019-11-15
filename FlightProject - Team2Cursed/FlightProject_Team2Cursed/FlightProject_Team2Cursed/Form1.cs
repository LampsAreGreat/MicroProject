using System;
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

        private void RoutesBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new AllRoutes();
            form1.Show();
        }

        private void CrewBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new Crew();
            form1.Show();
        }

        private void flightNumBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new DepartAndArrival();
            form1.Show();
        }

        private void LogBtn1_Click(object sender, EventArgs e)
        {
            Form form1 = new MaintenanceLogs();
            form1.Show();
        }
    }
}
