﻿using CharityBox.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityBox.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();


            builder.ToTable("Categories");

            builder.HasData(

                new Category { Id = "1", Name = "Sağlık" },
                new Category { Id = "2", Name = "Eğitim" },
                new Category { Id = "3", Name = "Sokak Hayvanları" }



                );

        }
    }
}
