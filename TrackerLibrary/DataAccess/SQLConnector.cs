using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrackerLibrary.Models;
using Dapper;
using System.Configuration;

namespace TrackerLibrary.DataAccess
{
//@PlaceNumber int,
//@PlaceName nvarchar(150),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int=0 output


    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Save a Prize to database
        /// </summary>
        /// <param name="model"> the Prize information  </param>
        /// <returns>the prize inforamtion including the unique idenifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)

        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) 
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("Prizes_Info", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            }
        }
    }
}
