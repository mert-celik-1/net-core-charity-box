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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
     
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Price).HasColumnType("decimal(18,2)");


            builder.HasOne<User>(a => a.User).WithMany(u => u.Transactions).HasForeignKey(a => a.UserId);

            builder.ToTable("Transactions");



        }
    }
}
