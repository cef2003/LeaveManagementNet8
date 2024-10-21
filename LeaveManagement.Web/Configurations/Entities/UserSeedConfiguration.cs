using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "abc2004a-f10a-2a2b-9caa-90699a155a70",
                    Email = "admin@user.com",
                    NormalizedEmail = "ADMIN@USER.COM",
                    UserName = "admin@user.com",
                    NormalizedUserName = "ADMIN@USER.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "3f94d925-fa71-4291-83f0-229a6285bdba",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "System2",
                    LastName = "Admin2",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                }
            );
        }
    }
}