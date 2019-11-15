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
    public partial class Crew : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;
        public Crew()
        {
            InitializeComponent();

            CrewBox.Items.Clear();
            CrewBox.Items.Add("CREW FOR FLIGHT: " + CrewText.Text);
            try
            {
                SQL = "select f.flightno, c.pilots,c.attendants,c.resclerk,c.maint,c.janitor,c.refueling  from flight2019.flight f inner join flight2019.crew c on f.flightno = c.flightno where f.FLIGHTNO='";

                SQL += CrewText.Text + "'";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);


                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    CrewBox.Items.Add("Pilots: " + dataReader.GetString(1));
                    CrewBox.Items.Add("Attendants: " + dataReader.GetString(2));
                    CrewBox.Items.Add("ResClerks: " + dataReader.GetString(3));
                    CrewBox.Items.Add("Maint: " + dataReader.GetString(4));
                    CrewBox.Items.Add("Janitor: " + dataReader.GetString(5));
                    CrewBox.Items.Add("Refueling: " + dataReader.GetString(6));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                CrewBox.Items.Add(ex.Message);
            }
        }
    }
}
