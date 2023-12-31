using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication_Project.Models
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed Role
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "70cecf66-f00e-406f-ae29-0feb2183689c",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "f672f1be-450b-4899-b9a5-13a0ff856015",
                    Name = "Editor",
                    NormalizedName = "EDITOR"
                }
                );



            //PasswordHasher
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            //Creating User
            var user1 = new IdentityUser
            {
                Id = "c02f71c8-a822-4b3a-900c-5c62478b32f0",
                UserName = "Admin1@gmail.com",
                NormalizedUserName = "ADMIN1@GMAIL.COM",
                Email = "Admin1@gmail.com",
                NormalizedEmail = "ADMIN1@GMAIL.COM",
            };
            user1.PasswordHash = ph.HashPassword(user1, "Admin1@gmail.com"); //Set user password

            var user2 = new IdentityUser
            {
                Id = "4b9d054d-bcb0-475e-96be-7e07d5ee3b85",
                UserName = "Editor1@gmail.com",
                NormalizedUserName = "EDITOR1@GMAIL.COM",
                Email = "Editor1@gmail.com",
                NormalizedEmail = "EDITOR1@GMAIL.COM",
            };
            user2.PasswordHash = ph.HashPassword(user2, "Editor1@gmail.com");
            
            var user3 = new IdentityUser
            {
                Id = "b7f46612-41d2-47ba-af30-f957a680d92a",
                UserName = "Ibrahim@example.com",
                NormalizedUserName = "IBRAHIM@EXAMPLE.COM",
                Email = "Ibrahim@example.com",
                NormalizedEmail = "IBRAHIM@EXAMPLE.COM",
            };
            user3.PasswordHash = ph.HashPassword(user3, "Ibrahim1@example.com");
            
            var user4 = new IdentityUser
            {
                Id = "0442b285-375d-48a0-8f47-d6e21bf342c9",
                UserName = "Sajib@example.com",
                NormalizedUserName = "SAJIB@EXAMPLE.COM",
                Email = "Sajib@example.com",
                NormalizedEmail = "SAJIB@EXAMPLE.COM",
            };
            user4.PasswordHash = ph.HashPassword(user4, "Sajib1@example.com");
            
            var user5 = new IdentityUser
            {
                Id = "b9701316-989f-48d4-9e92-9ecf162e9c01",
                UserName = "User1@example.com",
                NormalizedUserName = "USER1@EXAMPLE.COM",
                Email = "User1@example.com",
                NormalizedEmail = "USER1@EXAMPLE.COM",
            };
            user5.PasswordHash = ph.HashPassword(user5, "User1@example.com");

            //Seed User
            builder.Entity<IdentityUser>().HasData(user1,user2,user3,user4);


            //Set User Role
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> {UserId= "c02f71c8-a822-4b3a-900c-5c62478b32f0", RoleId= "70cecf66-f00e-406f-ae29-0feb2183689c"},
                new IdentityUserRole<string> {UserId= "4b9d054d-bcb0-475e-96be-7e07d5ee3b85", RoleId= "f672f1be-450b-4899-b9a5-13a0ff856015" },
                new IdentityUserRole<string> { UserId = "b7f46612-41d2-47ba-af30-f957a680d92a", RoleId = "70cecf66-f00e-406f-ae29-0feb2183689c" },
                new IdentityUserRole<string> { UserId = "0442b285-375d-48a0-8f47-d6e21bf342c9", RoleId = "70cecf66-f00e-406f-ae29-0feb2183689c" }
                );
        }
    }
}
