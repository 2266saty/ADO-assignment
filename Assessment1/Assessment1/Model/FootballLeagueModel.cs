using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1.Model
{
  public class FootballLeagueModel
    {
        public int MatchId { get; set; }
        public string TeamName1{ get; set; }
        public string TeamName2 { get; set; }
        public string MatchStatus { get; set; }
        public string WinningTeam { get; set; }
        public int Points { get; set; }

    }
}
