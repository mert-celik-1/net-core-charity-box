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
    public class CampaignConfigurations : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.CurrentMoney).HasColumnType("decimal(18,2)");
            builder.Property(c => c.Limit).HasColumnType("decimal(18,2)");


            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Campaigns).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Campaigns).HasForeignKey(a => a.UserId);

            builder.ToTable("Campaigns");

            builder.HasData(

                new Campaign { Id = Guid.NewGuid().ToString(), Name = "SMA hastası Ahmet için yardım kampanyası",Description="Kampanya için etiket yazısı",Limit=400,CategoryId="1",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now},
                new Campaign { Id = Guid.NewGuid().ToString(), Name = "4 yaşındaki Ali için tekerli sandalye hediyesi",Description="Kampanya için etiket yazısı",Limit=100,CategoryId="1",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now},
                
                new Campaign { Id = Guid.NewGuid().ToString(), Name = "Köy okullarına bağış kampanyası",Description="Kampanya için etiket yazısı",Limit=400,CategoryId="2",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now},
                new Campaign { Id = Guid.NewGuid().ToString(), Name = "Minik Elife burs ilanı ",Description="Kampanya için etiket yazısı",Limit=100,CategoryId="2",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now},
                 
                new Campaign { Id = Guid.NewGuid().ToString(), Name = "Sokak kedilerine yuva yapımı",Description="Kampanya için etiket yazısı",Limit=400,CategoryId="3",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now},
                new Campaign { Id = Guid.NewGuid().ToString(), Name = "Barınaktaki dostlarımıza yemek bağışı ",Description="Kampanya için etiket yazısı",Limit=100,CategoryId="3",IsDone=false,IsRejected=false,IsVerified=true,City="Istanbul",PhotoUrl="default.jpg",UserId="2",CreatedDate=DateTime.Now}


                );

        }
    }
}
