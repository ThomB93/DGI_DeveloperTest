using DeveloperTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Configurations
{
    public class WatchWordConfiguration : IEntityTypeConfiguration<WatchWord>
    {
        public void Configure(EntityTypeBuilder<WatchWord> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id).ValueGeneratedOnAdd(); //will auto increment id
            builder.Property(a => a.Word)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
