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
            LogBox.Items.Add("Maint Logs");
            try
            {
                SQL = "select * from flight2019.MaintLog";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);


                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    LogBox.Items.Add("Log#: " + dataReader.GetString(1));
                    LogBox.Items.Add("Plane#: " + dataReader.GetString(2));
                    LogBox.Items.Add("TaskID: " + dataReader.GetString(3));
                    LogBox.Items.Add("Maint Start Date: " + dataReader.GetString(4));
                    LogBox.Items.Add("Maint End Date: " + dataReader.GetString(5));
                    LogBox.Items.Add("Status: " + dataReader.GetString(6));

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                LogBox.Items.Add(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainForm();
            mainMenu.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
