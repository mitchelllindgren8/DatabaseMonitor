using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Data;

namespace LiveStats
{
    public static class DataLayer
    {
        /// <summary>
        /// Retrieve the list of SQL instances.
        /// </summary>
        public static List<string> GetServerInstances(string query)
        {
            List<string> instanceNames = new List<string>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
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

        /// <summary>
        /// Retrieve the list of SQL databases.
        /// </summary>
        public static List<string> GetServerDatabases(string query, string connectionString)
        {
            List<string> databaseList = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                databaseList.Add(reader["NAME"].ToString());
                            }
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

        /// <summary>
        /// Retrieve the list of database table names.
        /// </summary>
        public static bool GetDatabaseTables(string query, string connectionString, out DashboardPanel dashboardPanel)
        {
            dashboardPanel = new DashboardPanel();
            bool wasSuccessful = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dashboardPanel.tableNames.Add(reader["TABLE_NAME"].ToString());
                            }
                        }

                            dashboardPanel.tableNames.Sort();
                    }
                }

                if(dashboardPanel.tableNames.Count > 0)
                {
                    wasSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load database tables: {ex.Message}");
            }

            return wasSuccessful;
        }

        /// <summary>
        /// Test a SQL Server ConnectionString value.
        /// </summary>
        public static bool TestConnectionString(string connectionString)
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

        /// <summary>
        /// Called stored-procedure to collect database table data.
        /// </summary>
        public static DataTable GetTableStatistics(string connectionString, string tableName)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_GetTableStatistics", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TableName", tableName);
                        conn.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to process stored-procedure request and/or data: {ex.Message}");
            }

            return dataTable;
        }

    }
}
