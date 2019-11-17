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
    public partial class AllAirports : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;

        public AllAirports()
        {
            InitializeComponent();
            AirportBox.Items.Clear();
            AirportBox.Items.Add("AIRPORTS");
            AirportBox.Items.Add("AIRPORT CODE, AIRPORT NAME");
            try
            {
                SQL = "select ARCD,arnm from flight2019.airport";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);
                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AirportBox.Items.Add(dataReader.GetString(0) + ", " + dataReader.GetString(1));

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                AirportBox.Items.Add(ex.Message);
            }
        }

        private void BackMenu1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
