using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represent One Team in the Matchup
        /// </summary>
        public TeamModel TeamComputing { get; set; }
        /// <summary>
        /// Represents the Score For this Particular Team
        /// </summary>
        public double  Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner
        /// </summary>
        public MatchUpModel ParentMatchUp { get; set; }

    }
}
