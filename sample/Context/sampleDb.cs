using Microsoft.EntityFrameworkCore;
using sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Context
{
    internal class sampleDb:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=DESKTOP-609D4KS;Database=sampleDb;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connection);    
        }
    }
}
