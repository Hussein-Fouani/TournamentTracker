using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        /// <summary>
        /// Represents a list of entries of a matchup 
        /// </summary>
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        /// <summary>
        /// Represents the winner of a matchup 
        /// </summary>
        public TeamModel Winnder { get; set; }

        /// <summary>
        /// Represents the round of a matchup 
        /// </summary>
        public int MatchUpRound { get; set; }
    }
}
