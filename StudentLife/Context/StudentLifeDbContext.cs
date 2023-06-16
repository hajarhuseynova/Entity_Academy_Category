using Microsoft.EntityFrameworkCore;
using StudentLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Context
{
    internal class StudentLifeDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Academy> Academy { get; set; }
        string connection = "Server=DESKTOP-609D4KS;Database=StudentLife;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);  
        }

    }
}
