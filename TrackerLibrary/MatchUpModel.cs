using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();

        public TeamModel Winnder { get; set; }

        public int MatchUpRound { get; set; }
    }
}
