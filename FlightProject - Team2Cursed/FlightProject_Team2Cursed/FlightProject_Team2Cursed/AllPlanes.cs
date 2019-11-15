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
    public partial class AllPlanes : Form
    {
        iDB2Connection connection;
        iDB2Command command;
        iDB2DataReader dataReader;
        String SQL;
        public AllPlanes()
        {
            InitializeComponent();
            PlaneBox.Items.Clear();
            PlaneBox.Items.Add("AIRPLANES");
            try
            {
                SQL = "select planeno,planemodel,pmake from flight2019.airplane";
                connection = new iDB2Connection("datasource=deathstar.gtc.edu");
                command = new iDB2Command(SQL, connection);
                connection.Open();

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    PlaneBox.Items.Add(dataReader.GetString(0).Trim() + ", " + dataReader.GetString(1).Trim() + ", " + dataReader.GetString(2).Trim());

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                PlaneBox.Items.Add(ex.Message);
            }
        }
    }
}
