using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Save a Prize to database
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
