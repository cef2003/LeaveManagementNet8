using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cff2013b-f10a-2024-9cfa-90699a155b70",
                    UserId = "abc2004a-f10a-2a2b-9caa-90699a155a70"
                }, 
                new IdentityUserRole<string>
                {
                    RoleId = "cef2003b-f10a-2024-9caa-90699a155a70",
                    UserId = "3f94d925-fa71-4291-83f0-229a6285bdba"
                }
            );
        }
    }
}