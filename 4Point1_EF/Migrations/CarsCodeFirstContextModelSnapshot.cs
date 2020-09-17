﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _4Point1_EF.Models;

namespace _4Point1_EF.Migrations
{
    [DbContext(typeof(CarsCodeFirstContext))]
    partial class CarsCodeFirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_4Point1_EF.Models.CodeFirstCar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(10)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnName("colour")
                        .HasColumnType("varchar(10)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnName("manufacturer")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("model")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("Odometer")
                        .HasColumnName("odometer")
                        .HasColumnType("int(10)");

                    b.Property<string>("TrimLevel")
                        .IsRequired()
                        .HasColumnName("trim_level")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("code_first_car");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Colour = "Black",
                            Manufacturer = "Mitsubishi",
                            Model = "Lancer",
                            Odometer = 40000,
                            TrimLevel = "Evolution"
                        },
                        new
                        {
                            ID = 2,
                            Colour = "Red",
                            Manufacturer = "Honda",
                            Model = "Civic",
                            Odometer = 110000,
                            TrimLevel = "LX"
                        },
                        new
                        {
                            ID = 3,
                            Colour = "Blue",
                            Manufacturer = "Dodge",
                            Model = "Stealth",
                            Odometer = 98500,
                            TrimLevel = "R/T TT"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
