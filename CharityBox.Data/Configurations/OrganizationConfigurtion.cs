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
    public class OrganizationConfigurtion:IEntityTypeConfiguration<Organizations>
    {
      
            public void Configure(EntityTypeBuilder<Organizations> builder)
            {
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Id).ValueGeneratedOnAdd();
                builder.Property(c => c.Balance).HasColumnType("decimal(18,2)");


            builder.ToTable("Organizations");

                builder.HasData(

                    new Organizations { Id = "1", Name = "Arama Kurtarma Derneği", ShortName="AKUT",PhotoUrl="akut.jpg",AccountNumber="123456",Description="",Balance=0 },
                    new Organizations { Id = "2", Name = "Yeşilay Derneği",ShortName="YEŞİLAY",PhotoUrl="yesilay.jpg",AccountNumber="135478",Description="",Balance=0 },
                    new Organizations { Id = "3", Name = "Lösemili Çocuklar Sağlık ve Eğitim Vakfı", ShortName="LÖSEV",PhotoUrl="losev.jpg",AccountNumber="985235",Description="",Balance=0 },
                    new Organizations { Id = "4", Name = "Türkiye Kızılay Derneği", ShortName="KIZILAY",PhotoUrl="kizilay.jpg",AccountNumber="584923",Description="",Balance=0 },
                    new Organizations { Id = "5", Name = "Türkiye Erozyonla Mücadele Ağaçlandırma ve Doğal Varlıkları Koruma Vakfı", ShortName="TEMA",PhotoUrl="tema.jpg",AccountNumber="582319",Description="",Balance=0 },
                    new Organizations { Id = "6", Name = "Toplum Gönüllüleri Vakfı", ShortName="TOG",PhotoUrl="tog.jpg",AccountNumber="594921",Description="",Balance=0 },
                    new Organizations { Id = "7", Name = "Türkiye Eğitim Gönüllüleri Vakfı", ShortName="TEGV",PhotoUrl="tegv.jpg",AccountNumber="124553",Description="",Balance=0 },
                    new Organizations { Id = "8", Name = "Tüvana Okuma İstekli Çocuk Eğitim Vakfı", ShortName="TOÇEV",PhotoUrl="tocev.jpg",AccountNumber="112336",Description="",Balance=0 },
                    new Organizations { Id = "9", Name = "Anne Çocuk Eğitim Vakfı", ShortName="AÇEV",PhotoUrl="acev.jpg",AccountNumber="865346",Description="",Balance=0 },
                    new Organizations { Id = "10", Name = "Darüşşafaka Cemiyeti", ShortName="DARÜŞŞAFAKA", PhotoUrl="darussafaka.jpg",AccountNumber="456754",Description="",Balance=0 }


                    );

            }
        

    }
}
