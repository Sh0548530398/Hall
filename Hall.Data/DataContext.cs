using Hall.Core;
using Hall.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Orders> OrdersList { get; set; } 

        public DbSet<Photographer> PhotographersList { get; set; }

        public DbSet<Cameraman> CameramanList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Hall");
        }

    }
}
