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
    public partial class DepartAndArrival : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;
        SortedDictionary<String, String> arcodes;

        public DepartAndArrival()
        {
            InitializeComponent();
            loadARCodes();


        }



        private void loadARCodes()
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
                AnDBox.Items.Add(ex.Message);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AnDText.Text != null && AnDText.Text.Length > 0) {
                AnDBox.Items.Clear();
                AnDBox.Items.Add("Info for Flight#" + AnDText.Text);
                try
                {
                    SQL = "select f.FTRTID, r.rtardepart,r.rtararrivl,f.flightno  from flight2019.flight f inner join flight2019.route r on f.FTRTID = r.RTID where f.FLIGHTNO='";

                    SQL += AnDText.Text + "'";
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
                        AnDBox.Items.Add("Flight ID: " + dataReader.GetString(0) + " Departing: " + departcity.Trim() + " Arriving at: " + arrivalcity.Trim());



                    }
                    connection.Close();
                }
            catch (Exception ex)
            {
                AnDBox.Items.Add(ex.Message);
            }
            }
        }
    }
}
