using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Data;

namespace LiveStats
{
    public class DashboardPanel
    {
        public Panel checkboxTablePanel = new Panel();
        public List<string> tableNames = new List<string>();
        public List<CheckBox> checkBoxTableNames = new List<CheckBox>();
    }

    public class DashboardValues
    {
        private const string SUFFIX = ";Integrated Security=True;Min Pool Size=1;Max Pool Size=20;Load Balance Timeout=15;Trust Server Certificate=True";
        public string _connectionString = string.Empty;

        public string ConnectionString
        {
            get { return _connectionString; }
            set {  _connectionString = value; }
        }

        public void BuildConnectionString(string serverName, string instanceName, string databaseName)
        {
            if (string.IsNullOrEmpty(databaseName))
            {
                // Build a generic connectionString without a database reference.
                _connectionString = string.Concat("Server=", serverName, "\\", instanceName, SUFFIX);
            }
            else
            {
                // Build a complete connectionString with a database reference.
                _connectionString = string.Concat("Server=", serverName, "\\", instanceName, ";Database=", databaseName, SUFFIX);
            }
        }
    }

    public static class DashboardHelper
    {
        public static string[] RetrieveInstances()
        {
            string instanceQuery = "SELECT * FROM Win32_Service WHERE Name = 'MSSQLSERVER' OR Name LIKE 'MSSQL%$%'";

            return DataLayer.GetServerInstances(instanceQuery).ToArray() ?? Array.Empty<string>();
        }

        public static string[] GetDatabases(string connectionString)
        {
            string databaseQuery = "SELECT name FROM sys.databases WHERE state_desc = 'ONLINE'";

            return DataLayer.GetServerDatabases(databaseQuery, connectionString).ToArray() ?? Array.Empty<string>();
        }

        public static DashboardPanel BuildTablePanel(string connectionString)
        {
            DashboardPanel dashboardPanel = null;
            string tableQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            try
            {
                bool wasSuccessful = DataLayer.GetDatabaseTables(tableQuery, connectionString, out dashboardPanel);

                if (wasSuccessful)
                {
                    // Create UI elements for each table.
                    foreach (var table in dashboardPanel.tableNames)
                    {
                        CheckBox newCheckBox = new CheckBox();
                        newCheckBox.Name = table;
                        newCheckBox.Text = table;
                        newCheckBox.AutoSize = true;
                        dashboardPanel.checkBoxTableNames.Add(newCheckBox);
                    }

                    dashboardPanel.checkboxTablePanel.Name = "NewPanel";
                    dashboardPanel.checkboxTablePanel.BackColor = Color.White;
                    dashboardPanel.checkboxTablePanel.Size = new Size(319, 595);
                    dashboardPanel.checkboxTablePanel.AutoScroll = true;
                    dashboardPanel.checkboxTablePanel.Location = new Point(10, 10);
                    dashboardPanel.checkboxTablePanel.Tag = true;

                    int itrX = 20;
                    int itrY = 20;

                    // Generate a panel with the table names as checkboxes.
                    foreach (var checkBox in dashboardPanel.checkBoxTableNames)
                    {
                        dashboardPanel.checkboxTablePanel.Controls.Add(checkBox);
                        checkBox.Location = new Point(itrX, itrY);
                        itrY += 25;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load and/or generate table logic: {ex.Message}");
            }

            return dashboardPanel;
        }

        public static bool TestDatabaseConnection(string connectionString)
        {
            return DataLayer.TestConnectionString(connectionString);
        }

        public static DataSet GenerateTableView(DashboardPanel panel, string connectionString)
        {
            DataSet dataSet = new DataSet();

            foreach (var tableName in panel.tableNames)
            {
                // Add the DataTables representing a Database's tables to the DataSet.
                dataSet.Tables.Add(DataLayer.GetTableStatistics(connectionString, tableName));
            }

            return dataSet;
        }
    }
}
