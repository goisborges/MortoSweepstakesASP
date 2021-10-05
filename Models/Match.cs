using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortoSweepstakes.Models
{
    public class Match
    {
        //model for the matches
        public int MatchId { get; set; }

        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public int ScoreTeam1 { get; set; }

        public int ScoreTeam2 { get; set; }

        public DateTime MatchDateTime { get; set; }

        //Reference to child Bet model
        public List<Bet> Bets { get; set; }

    }
}
