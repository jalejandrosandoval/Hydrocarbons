using Bussiness_Logic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Data
{
    public class AppDBContext : DbContext
    {
        

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Line_Hydrocarbon> Line_Hydrocarbons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Line_Hydrocarbon>().ToTable("Line_Hydrocarbons");

        }
    }
}
