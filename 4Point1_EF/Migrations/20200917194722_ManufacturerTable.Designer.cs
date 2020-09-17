﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _4Point1_EF.Models;

namespace _4Point1_EF.Migrations
{
    [DbContext(typeof(CarsCodeFirstContext))]
    [Migration("20200917194722_ManufacturerTable")]
    partial class ManufacturerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 46854,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 2,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 287287,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 3,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 177150,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 4,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 7309,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 5,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 124589,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 6,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 58560,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 7,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 186997,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 8,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 266006,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 9,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 214519,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 10,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 205373,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 11,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 258338,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 12,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 63684,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 13,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 197659,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 14,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 141696,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 15,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 249184,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 16,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 167702,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 17,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 192133,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 18,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 225288,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 19,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Corvette",
                            Odometer = 224903,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 20,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Corvette",
                            Odometer = 172390,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 21,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Corvette",
                            Odometer = 15369,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 22,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 119101,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 23,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 261247,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 24,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 188169,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 25,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 274066,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 26,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 78686,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 27,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 281731,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 28,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 88611,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 29,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 236263,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 30,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 149519,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 31,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 131963,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 32,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 6527,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 33,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 70641,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 34,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 11040,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 35,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 163166,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 36,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 238158,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 37,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 276248,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 38,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 278312,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 39,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 22896,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 40,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 175270,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 41,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 214536,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 42,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 267356,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 43,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 211301,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 44,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 177588,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 45,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Corvette",
                            Odometer = 191347,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 46,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 174229,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 47,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 269640,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 48,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 197301,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 49,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 202834,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 50,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 171229,
                            TrimLevel = "Awesome"
                        });
                });

            modelBuilder.Entity("_4Point1_EF.Models.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int?>("YearFounded")
                        .HasColumnName("year_founded")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.ToTable("manufacturer");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Chevrolet",
                            YearFounded = 1911
                        },
                        new
                        {
                            ID = 2,
                            Name = "Ford",
                            YearFounded = 1903
                        },
                        new
                        {
                            ID = 3,
                            Name = "Tesla"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Dodge"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Toyota",
                            YearFounded = 1937
                        },
                        new
                        {
                            ID = 6,
                            Name = "Honda",
                            YearFounded = 1946
                        },
                        new
                        {
                            ID = 7,
                            Name = "Mitsubishi"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Nissan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
