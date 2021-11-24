using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public static class ModelBuilderDbExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasData(new Role
                {
                    RoleId = 1,
                    Name = "Staff"
                });
                entity.HasData(new Role
                {
                    RoleId = 2,
                    Name = "Visitor"
                });
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasData(new AppUser
                {
                    Email = "johndoe@poolclub.com",
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "0781235645"
                });
                entity.HasData(new AppUser
                {
                    Email = "maryann@poolclub.com",
                    FirstName = "Mary",
                    LastName = "Ann",
                    PhoneNumber = "0763214543",
                });
                entity.HasData(new AppUser
                {
                    Email = "markspencer@poolclub.com",
                    FirstName = "Mark",
                    LastName = "Spencer",
                    PhoneNumber = "0762253312",
                });
                entity.HasData(new AppUser
                {
                    Email = "bobmarly@yahoo.com",
                    FirstName = "Bob",
                    LastName = "Marly",
                    PhoneNumber = "0712516674",
                });
                entity.HasData(new AppUser
                {
                    Email = "janejameson@gmail.com",
                    FirstName = "Jane",
                    LastName = "Jameson",
                    PhoneNumber = "0711194203",
                });
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasData(new Table
                {
                    TableId = 1,
                    Floor = 1
                });
                entity.HasData(new Table
                {
                    TableId = 2,
                    Floor = 1
                });
                entity.HasData(new Table
                {
                    TableId = 3,
                    Floor = 1
                });
                entity.HasData(new Table
                {
                    TableId = 4,
                    Floor = 2
                });
                entity.HasData(new Table
                {
                    TableId = 5,
                    Floor = 2
                });
                entity.HasData(new Table
                {
                    TableId = 6,
                    Floor = 2
                });
            });
        }
    }
}
