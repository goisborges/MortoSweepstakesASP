using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MortoSweepstakes.Models
{
    public class Bet
    {
        //This is a model for the Bets the users will place
        //it is a child class from the matches and Users model classes
        [Display(Name = "Bet ID")]
        public int BetId { get; set; }

        //bet score of team 1
        [Range(0, 10)]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Only integers from 0 to 10 are allowed here")]
        public int BetTeam1 { get; set; }

        //bet score for team 2
        [Range(0, 10)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Only integers from 0 to 10 are allowed here")]
        public int BetTeam2 { get; set; }

        //how many points the user made with this bet
        public int BetPoints { get; set; }

        //when the user placed the bet. Should not be valid if it's placed after the game starts
        public DateTime BetDateTime { get; set; }

        //Reference the parent table - Matches
        public Match Match { get; set; }

        //User Id needs to be a Foreign Key here
        public string UserId { get; set; }
    }
}
