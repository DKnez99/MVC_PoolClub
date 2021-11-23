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
                    UserId = 1,
                    Email = "johndoe@poolclub.com",
                    Password = "johndoe123",
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "0781235645",
                    RoleId = 1
                });
                entity.HasData(new AppUser
                {
                    UserId = 2,
                    Email = "maryann@poolclub.com",
                    Password = "maryann123",
                    FirstName = "Mary",
                    LastName = "Ann",
                    PhoneNumber = "0763214543",
                    RoleId = 1
                });
                entity.HasData(new AppUser
                {
                    UserId = 3,
                    Email = "markspencer@poolclub.com",
                    Password = "markspencer123",
                    FirstName = "Mark",
                    LastName = "Spencer",
                    PhoneNumber = "0762253312",
                    RoleId = 1
                });
                entity.HasData(new AppUser
                {
                    UserId = 4,
                    Email = "bobmarly@yahoo.com",
                    Password = "bobmarly123",
                    FirstName = "Bob",
                    LastName = "Marly",
                    PhoneNumber = "0712516674",
                    RoleId = 2
                });
                entity.HasData(new AppUser
                {
                    UserId = 5,
                    Email = "janejameson@gmail.com",
                    Password = "janejameson213",
                    FirstName = "Jane",
                    LastName = "Jameson",
                    PhoneNumber = "0711194203",
                    RoleId = 2
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
