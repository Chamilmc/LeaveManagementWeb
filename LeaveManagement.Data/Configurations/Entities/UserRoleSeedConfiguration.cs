using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "caabc169-3aa6-4b7e-a3f2-c20f8beef355",
                    UserId = "329992f2-8336-4d98-a1b2-0a5eb489839b"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "329992f2-8336-4d98-a1b2-0a5eb489839a",
                     UserId = "329992f2-8336-4d98-a1b2-0a5eb489839c"
                 }
            );
        }
    }
}