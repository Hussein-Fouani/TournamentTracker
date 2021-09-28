using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represent One Team in the Matchup
        /// </summary>
        public TeamModel TeamComputing { get; set; }

        public double  Score { get; set; }
        public MatchUpModel ParentMatchUp { get; set; }

    }
}
