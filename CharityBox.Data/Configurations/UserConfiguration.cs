using CharityBox.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.Balance).HasColumnType("decimal(18,2)");

            builder.ToTable("AspNetUsers");

            builder.HasData(
                
                new User {Id="2", UserName="mertcelik",Email="mertcelik@gmail.com",Balance=1500,FirstName="Mert",LastName="Çelik",City="Istanbul",IsAdmin=false,PasswordHash= "E4FDC41E7458B7A4B128154A181D2C305133226909CF5B9DB3BD21B9884717AFA03A2096E201E2DC056C55D8C3F69164D08ECA3167FA074E1088940EE49EBB87" },
                new User {Id="1", UserName="admin",Email="admin@gmail.com",Balance=1500,IsAdmin=true,PasswordHash= "E4FDC41E7458B7A4B128154A181D2C305133226909CF5B9DB3BD21B9884717AFA03A2096E201E2DC056C55D8C3F69164D08ECA3167FA074E1088940EE49EBB87" }
                
                );
        }
    }
}
