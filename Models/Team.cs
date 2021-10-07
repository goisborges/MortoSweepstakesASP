using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MortoSweepstakes.Models
{
    public class Team
    {
       
        [Required]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        public char TeamGroup { get; set; }

        
    }
}
