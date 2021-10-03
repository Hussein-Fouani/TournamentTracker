using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new();

        public static void InitializeConnections(bool database,bool texfiles)
        {
            // Set Up the Sql Connection
            if (database)
            {
                SQLConnector connector = new();
                connections.Add(connector);
            }
            // create the text  Connection
            if (texfiles)
            {

            }

        }        

    }
}
