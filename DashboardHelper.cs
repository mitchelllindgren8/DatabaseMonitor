using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

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
        private const string DATABASESQUERY = "SELECT name FROM sys.databases WHERE state_desc = 'ONLINE'";
        private const string INSTANCEQUERY = "SELECT * FROM Win32_Service WHERE Name = 'MSSQLSERVER' OR Name LIKE 'MSSQL%$%'";
        private const string TABLEQUERY = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

        public static List<string> GetInstances()
        {
            List<string> instanceNames = new List<string>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(INSTANCEQUERY);
                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection.Cast<ManagementObject>())
                {
                    string? serverName = m["NAME"].ToString();

                    if (serverName != null)
                    {
                        string[] pairValues = serverName.Split('$');

                        if (!instanceNames.Contains(pairValues[1]))
                        {
                            instanceNames.Add(pairValues[1]);
                        }
                    }
                }

                instanceNames = instanceNames.Where(s => !string.IsNullOrEmpty(s)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load instances: {ex.Message}");
            }

            return instanceNames;
        }

        public static List<string> GetDatabases(string connectionString)
        {
            List<string> databaseList = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(DATABASESQUERY, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            databaseList.Add(reader["NAME"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load database list: {ex.Message}");
            }

            return databaseList;
        }

        public static DashboardPanel BuildTablePanel(string connectionString)
        {
            DashboardPanel dashboardPanel = new DashboardPanel();

            try
            {
                // Retrieve the database table names.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(TABLEQUERY, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            dashboardPanel.tableNames.Add(reader["TABLE_NAME"].ToString());
                        }
                    }

                    dashboardPanel.tableNames.Sort();
                }

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
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load and/or generate table logic: {ex.Message}");
            }

            return dashboardPanel;
        }

        public static bool TestDatabaseConnection(string connectionString)
        {
            bool wasSuccessful = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    wasSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to connection: {ex.Message}");
            }

            return wasSuccessful;
        }

        public static bool GenerateTableView(DashboardPanel panel)
        {
            foreach(var table in panel.tableNames)
            {
                //call the stored-procedure by using the ConnectionString and database's tablenames.
            }

            return false;
        }
    }
}
