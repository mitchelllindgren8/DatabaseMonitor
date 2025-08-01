using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Linq;
using System.Management;

namespace LiveStats
{
    public partial class Dashboard : Form
    {
        DashboardValues _dashboardValues = new DashboardValues();
        DashboardPanel _dashboardPanel = new DashboardPanel();

        public Dashboard()
        {
            InitializeComponent();
        }

        #region UI Element Events

        // Insert the SSMS instances into the UI element.
        private void btnLoadSSMS_Click(object sender, EventArgs e)
        {
            cbInstances.Items.Clear();
            tbConnectionString.Clear();
            plInstanceStatus.BackColor = Color.DarkGray;
            plInstanceStatus.Refresh();

            if (rbWindowsAuth.Checked)
            {
                cbInstances.Items.AddRange(DashboardHelper.RetrieveInstances());
            }

            // TODO: Add code for SQL server credentials authentication.
            if (rbSQLAuth.Checked)
            {
                cbInstances.Items.AddRange(DashboardHelper.RetrieveInstances());
            }

            if (cbInstances.Items.Count > 0)
                plInstanceStatus.BackColor = Color.Green;
            else
                plInstanceStatus.BackColor = Color.Red;
        }

        // Insert the list of databases from the Server/Instance pair into the UI element.
        private void btnLoadDatabases_Click(object sender, EventArgs e)
        {
            string serverName = tbServer.Text;
            string instanceName = cbInstances.Text;

            cbDatabases.Items.Clear();
            tbConnectionString.Clear();
            plDatabaseStatus.BackColor = Color.DarkGray;
            Thread.Sleep(500);

            // Ensure we have an 'instanceName' value before loading any database tables.
            if (!string.IsNullOrEmpty(instanceName))
            {
                ManageConnectionString(serverName, instanceName, string.Empty);
                cbDatabases.Items.AddRange(DashboardHelper.GetDatabases(_dashboardValues.ConnectionString));
            }
            else
            {
                plDatabaseStatus.BackColor = Color.Red;
            }

            // Update UI elements.
            if (cbDatabases.Items.Count > 0)
            {
                plDatabaseStatus.BackColor = Color.Green;
            }
            else
            {
                plDatabaseStatus.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Generate a new panel with all the related database table names.
        /// </summary>
        private void btnLoadTables_Click(object sender, EventArgs e)
        {
            string serverName = tbServer.Text;
            string instanceName = cbInstances.Text;
            string databaseName = cbDatabases.Text;

            plTableStatus.BackColor = Color.DarkGray;
            plTableStatus.Refresh();

            // Ensure we have a databaseName' value before loading any database tables. (Note: An empty database string will load the first database within SSMS.)
            if (!string.IsNullOrEmpty(databaseName))
            {
                ManageConnectionString(serverName, instanceName, databaseName);
                _dashboardPanel = DashboardHelper.BuildTablePanel(_dashboardValues.ConnectionString);
            }
            else
            {
                plTableStatus.BackColor = Color.Red;
            }

            // Update UI elements.
            if (_dashboardPanel.checkboxTablePanel.Tag != null && (bool)_dashboardPanel.checkboxTablePanel.Tag)
            {
                plTableStatus.BackColor = Color.Green;
                plBaseTableView.Controls.Remove(plTableCheckBoxes);
                plTableCheckBoxes = _dashboardPanel.checkboxTablePanel;
                plBaseTableView.Controls.Add(plTableCheckBoxes);
                Thread.Sleep(500);
            }
            else
            {
                plTableStatus.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Test the database connection with the provided ConnectionString.
        /// </summary>
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = tbConnectionString.Text;

            if (DashboardHelper.TestDatabaseConnection(connectionString))
            {
                plConnectionStringStatus.BackColor = Color.Green;
            }
            else
            {
                plConnectionStringStatus.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Utilize the user created connectionString or user submitted connectionString.
        /// </summary>
        public void ManageConnectionString(string serverName, string instanceName, string databaseName)
        {
            //string connectionSting = tbConnectionString.Text;

            if (string.IsNullOrEmpty(tbConnectionString.Text) || !tbConnectionString.Text.Contains("Database"))
            {
                _dashboardValues.BuildConnectionString(serverName, instanceName, databaseName);
                tbConnectionString.Text = _dashboardValues.ConnectionString;
            }
            else
            {
                _dashboardValues.ConnectionString = tbConnectionString.Text;
            }
        }

        /// <summary>
        /// Indicates the type of connectionString that has been built or submitted by the user.
        /// </summary>
        private void tbConnectionString_TextChanged(object sender, EventArgs e)
        {
            string connectionString = tbConnectionString.Text;

            // Reset the status of the 'Test ConnectionString Status Panel'.
            plConnectionStringStatus.BackColor = Color.DarkGray;
            plConnectionStringStatus.Refresh();

            if (string.IsNullOrEmpty(connectionString))
            {
                // ConnectionString is empty.
                plConnectionStringTypeStatus.BackColor = Color.DarkGray;
                //plConnectionStringStatus.BackColor = Color.DarkGray;
            }
            else if (!connectionString.Contains("Database"))
            {
                // ConnectionString is partial and does not access a specific database.
                plConnectionStringTypeStatus.BackColor = Color.Orange;
            }
            else if (connectionString.Contains("Database"))
            {
                // ConnectionString is complete and can access a specific database.
                plConnectionStringTypeStatus.BackColor = Color.Green;
            }
            else
            {
                // There is an error with the connectionSring.
                plConnectionStringTypeStatus.BackColor = Color.Red;
            }
        }

        private void rbWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWindowsAuth.Checked)
            {
                tbDBusername.Enabled = false;
                tbDBpassword.Enabled = false;
                tbDBusername.BackColor = Color.Silver;
                tbDBpassword.BackColor = Color.Silver;
            }
        }
        private void rbSQLAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQLAuth.Checked)
            {
                tbDBusername.Enabled = true;
                tbDBpassword.Enabled = true;
                tbDBusername.BackColor = SystemColors.Window;
                tbDBpassword.BackColor = SystemColors.Window;
            }
        }

        #endregion

        private void btnLoadTableView_Click(object sender, EventArgs e)
        {
            string connectionString = tbConnectionString.Text;
            DataSet databaseDataSet = DashboardHelper.GenerateTableView(_dashboardPanel, connectionString);

            if (databaseDataSet.Tables.Count > 0)
            {
                plLoadTableView.BackColor = Color.Green;
                dgvDatabaseView.DataSource = databaseDataSet.Tables;

                // Create Stored-Procedure

                // Solve how to set results from SP into a usable data. Create row-by-row, set UI DataSource equal to DataSet obj, 
            }
            else
            {
                plLoadTableView.BackColor = Color.Red;
            }

        }
    }
}
