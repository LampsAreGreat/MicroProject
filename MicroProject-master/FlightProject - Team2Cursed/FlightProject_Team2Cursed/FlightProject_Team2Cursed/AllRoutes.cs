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
    public partial class AllRoutes : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;
        SortedDictionary<String, String> arcodes;
        public AllRoutes()
        {
            InitializeComponent();
            loadARCodes();

            RouteBox.Items.Clear();
            RouteBox.Items.Add("ROUTES");
            try
            {
                SQL = "select rtno,rtardepart,rtararrivl from flight2019.route";
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
                    RouteBox.Items.Add("Route# " + dataReader.GetString(0) + " Departing: " + departcity.Trim() + " Arriving at: " + arrivalcity.Trim());


                }
                connection.Close();
            }
            catch (Exception ex)
            {
                RouteBox.Items.Add(ex.Message);
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
                RouteBox.Items.Add(ex.Message);
            }
        }
    }
}
