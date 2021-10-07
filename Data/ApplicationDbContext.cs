using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MortoSweepstakes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortoSweepstakes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //global references to the models so they are available globally
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Match> Matches { get; set; }

        public DbSet<Team> Teams { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
