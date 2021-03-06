// <auto-generated />
using DeveloperTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeveloperTest.Migrations
{
    [DbContext(typeof(TextDbContext))]
    [Migration("20210706161324_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("DeveloperTest.Models.DistinctText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DistinctWordCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DistinctTexts");
                });

            modelBuilder.Entity("DeveloperTest.Models.WatchWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Word")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WatchWords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Word = "cat"
                        },
                        new
                        {
                            Id = 2,
                            Word = "dog"
                        },
                        new
                        {
                            Id = 3,
                            Word = "rabbit"
                        },
                        new
                        {
                            Id = 4,
                            Word = "mouse"
                        },
                        new
                        {
                            Id = 5,
                            Word = "horse"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
