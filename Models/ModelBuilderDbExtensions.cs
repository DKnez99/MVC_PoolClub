using Microsoft.AspNetCore.Identity;
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
            //Seeding roles to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Staff", NormalizedName = "STAFF".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3d5c224l-3b0e-446f-86af-365d56fd0954", Name = "Visitor", NormalizedName = "VISITOR".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<AppUser>();


            //Seeding user to AspNetUsers table
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = "markspencer@poolclub.com",
                    NormalizedUserName = "MARKSPENCER@POOLCLUB.COM",
                    Email = "markspencer@poolclub.com",
                    NormalizedEmail = "MARKSPENCER@POOLCLUB.COM",
                    PasswordHash = hasher.HashPassword(null, "markspencer123"),
                    PhoneNumber = "07666473134",
                    FirstName = "Mark",
                    LastName = "Spencer",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            //Seeding tables
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
