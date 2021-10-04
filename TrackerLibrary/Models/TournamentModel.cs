using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Tournament  name 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the Tournament's Entry Fee 
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the Tournament's Teams that are participating in it 
        /// </summary>
        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the Tournament's Prize info 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the Tournament's  matchup info in each round  
        /// </summary>
        public List<List<MatchUpModel>> Rounds { get; set; }


    }
}
