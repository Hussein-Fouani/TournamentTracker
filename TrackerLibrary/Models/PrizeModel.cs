using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique Identifier for  prize
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the placement number  of a Team 
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the placement Name  of a Team 
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the Prize amount  of a for the winning team 
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the Percentage number  of a prize distributed 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placenumber,string placename ,string prizeamount,string prizepercentage)
        {
            PlaceName = placename;
            int placenbvalid = 0;
            int.TryParse(placenumber, out  placenbvalid);
            PlaceNumber = placenbvalid;

            decimal prizeamnt = 0;
            decimal.TryParse(prizeamount, out prizeamnt);
            PrizeAmount = prizeamnt;

            double prizepercentagee = 0;
            double.TryParse(prizepercentage, out prizepercentagee);
            PrizePercentage = prizepercentagee; 


        }
     

    }
}
