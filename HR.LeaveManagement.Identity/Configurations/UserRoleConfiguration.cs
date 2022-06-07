using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "5bb370f8-1a67-4ac8-a554-e5bbe9733c38",
                    UserId = "33a126e5-b10d-4d4a-b5cd-d9bb962c4716"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "6c15eac5-a55f-4231-b528-ce07824bb710",
                    UserId = "cae4dbfc-dd03-4474-977c-eefa1670d119"
                }
            );
        }
    }
}
