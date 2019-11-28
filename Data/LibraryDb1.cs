using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsliPehlivan_HW5.Data
{
    public class LibraryDb1 : DbContext
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CetLibrary;Trusted_Connection=True;";
        public DbSet<CetUser> CetUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public LibraryDb1() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CetUser>().HasData(
                new CetUser
                {
                    Id = 1,
                    Name = "Aslı",
                    Surname = "Pehlivan",
                    UserName = "admin",
                    Password = new Service.CetUserService().hashPassword("admin"),
                    CreatedDate = DateTime.Now,
                    Role = "Öğrenci"
                }
            );
        }
    }
}
