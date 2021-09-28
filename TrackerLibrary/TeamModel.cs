using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a the teammembersinfo for a given team
        /// </summary>
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        /// <summary>
        /// Represents a team name
        /// </summary>
        public string TeamName { get; set; }

    }
}
