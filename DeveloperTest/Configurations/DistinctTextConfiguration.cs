using DeveloperTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeveloperTest.Configurations
{
    public class DistinctTextConfiguration : IEntityTypeConfiguration<DistinctText>
    {
        public void Configure(EntityTypeBuilder<DistinctText> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id).ValueGeneratedOnAdd(); //will auto increment id
            builder.Property(a => a.Text)
                .IsRequired()
                .HasMaxLength(1000); 
        }
    }
}
