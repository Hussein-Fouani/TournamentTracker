using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Data.SqlClient;
using ProjectTrackerUI;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection connection { get; private set; } 

        public static void InitializeConnections(Enums db)
        {
            // Set Up the Sql Connection
            if (db== Enums.Sql)  
            {
                SQLConnector connector = new();
                connection=(connector);
            }
            // create the text  Connection
            else if (db== Enums.TextFile)   
            {
                TextConnection text = new TextConnection();
                connection = text;
            }
            
        }
        
        public static string CnnString(string constring) => ConfigurationManager.ConnectionStrings[constring].ConnectionString;

    }
}
