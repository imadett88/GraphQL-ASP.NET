﻿// <auto-generated />
using GraphqlWithAsp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphqlWithAsp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphqlWithAsp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Imad",
                            Roll = "STK122"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aymane",
                            Roll = "STV102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mohamed",
                            Roll = "WTX162"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Aya",
                            Roll = "SNK122"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Yassin",
                            Roll = "STK122"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
