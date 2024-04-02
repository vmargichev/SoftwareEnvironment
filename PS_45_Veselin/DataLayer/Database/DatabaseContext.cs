using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite(databasePath);
 //         base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            DatabaseUser user = new DatabaseUser("Georgi", "123", Welcome.Others.UserRolesEnum.ANONYMOUS, DateTime.Now.AddYears(10));
            DatabaseUser user1 = new DatabaseUser("Georgi1", "123", Welcome.Others.UserRolesEnum.ANONYMOUS, DateTime.Now.AddYears(5));
            DatabaseUser user2 = new DatabaseUser("Georgi2", "123", Welcome.Others.UserRolesEnum.ANONYMOUS, DateTime.Now.AddYears(7));
            modelBuilder.Entity<DatabaseUser>().HasData(user);
            modelBuilder.Entity<DatabaseUser>().HasData(user1);
            modelBuilder.Entity<DatabaseUser>().HasData(user2);

            //          base.OnModelCreating(modelBuilder);
        }
        public DbSet<DatabaseUser> Users { get; set; }
    }
}
