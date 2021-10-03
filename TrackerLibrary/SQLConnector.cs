using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Savea Prize to database
        /// </summary>
        /// <param name="model"> the Prize information  </param>
        /// <returns>the prize inforamtion including the unique idenifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
