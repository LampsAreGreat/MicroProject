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
    public partial class MaintenanceLogs : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;

        public MaintenanceLogs()
        {
            InitializeComponent();

            LogBox.Items.Clear();
            LogBox.Items.Add("Maintanence Logs");
            
            try
            {
                SQL = "select * from flight2019.maintanence";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);
                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    LogBox.Items.Add(dataReader.GetString(0) + ", " + dataReader.GetString(1));

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                LogBox.Items.Add(ex.Message);
            }
        }
    }
}
