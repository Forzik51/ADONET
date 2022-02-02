using EntityIntro21._01._22.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityIntro21._01._22.Data.Models.FootballTeam;

namespace EntityIntro21._01._22.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=10.7.101.197;Database=Academy_HOLUBYEV;USer Id=test;Password=1;MultipleActiveResultSets=True;");
            }
        }

        public DbSet<FootballTeam> FootballTeam { get; set; }
    }
}