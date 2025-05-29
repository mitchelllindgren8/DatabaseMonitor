using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LiveStats
{
    public static class DataLayer
    {
        //private DatabaseHelper databaseHelper = new DatabaseHelper();

        //public static List<string> GetInstances()
        //{
        //    List<string> instanceNames = new List<string>();

        //    try
        //    {
        //        ManagementObjectSearcher searcher = new ManagementObjectSearcher(INSTANCEQUERY);
        //        ManagementObjectCollection queryCollection = searcher.Get();

        //        foreach (ManagementObject m in queryCollection.Cast<ManagementObject>())
        //        {
        //            string? serverName = m["NAME"].ToString();

        //            if (serverName != null)
        //            {
        //                string[] pairValues = serverName.Split('$');

        //                if (!instanceNames.Contains(pairValues[1]))
        //                {
        //                    instanceNames.Add(pairValues[1]);
        //                }
        //            }
        //        }

        //        instanceNames = instanceNames.Where(s => !string.IsNullOrEmpty(s)).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Failed to load instances: {ex.Message}");
        //    }

        //    return instanceNames;
        //}

    }
}
