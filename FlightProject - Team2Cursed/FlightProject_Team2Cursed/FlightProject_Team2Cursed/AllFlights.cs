using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightProject_Team2Cursed
{
    public partial class AllFlights : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;
        SortedDictionary<String, String> arcodes;

        public AllFlights()
        {
            InitializeComponent();
            loadARCodes();

            FlightBox.Items.Clear();
            FlightBox.Items.Add("FLIGHTS");
            try
            {
                SQL = "select f.FTRTID, r.rtardepart,r.rtararrivl  from flight2019.flight f inner join flight2019.route r on FTRTID = RTID";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);


                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    String departcity = "ERROR IF UNCHANGED";
                    String arrivalcity = "ERROR IF UNCHANGED";
                    arcodes.TryGetValue(dataReader.GetString(1), out departcity);
                    arcodes.TryGetValue(dataReader.GetString(2), out arrivalcity);
                    FlightBox.Items.Add("Flight ID: " + dataReader.GetString(0) + " Departing: " + departcity.Trim() + " Arriving at: " + arrivalcity.Trim());



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                FlightBox.Items.Add(ex.Message);
            }

        }

        public void loadARCodes()
        {
            try
            {
                SQL = "select ARCD,arcitynm from flight2019.airport";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);
                arcodes = new SortedDictionary<string, string>();
                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    arcodes.Add(dataReader.GetString(0), dataReader.GetString(1));

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                FlightBox.Items.Add(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainForm();
            mainMenu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackMenu1_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainForm();
            mainMenu.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
