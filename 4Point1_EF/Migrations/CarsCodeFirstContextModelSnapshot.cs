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
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 199381,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 2,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 27320,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 3,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 48696,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 4,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 262923,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 5,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Corvette",
                            Odometer = 189920,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 6,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 30512,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 7,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 216400,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 8,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 234644,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 9,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 258688,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 10,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 243988,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 11,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 83714,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 12,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 220189,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 13,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 192930,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 14,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 289448,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 15,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 251240,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 16,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 280350,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 17,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 255740,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 18,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 287963,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 19,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 168189,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 20,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 87086,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 21,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 169562,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 22,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Durango",
                            Odometer = 135354,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 23,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 24200,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 24,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 190756,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 25,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 118234,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 26,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 294750,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 27,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 19257,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 28,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 1277,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 29,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 277687,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 30,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 254224,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 31,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Corvette",
                            Odometer = 71577,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 32,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 191825,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 33,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 80711,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 34,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 242729,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 35,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 61323,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 36,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 85819,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 37,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 76140,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 38,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 79770,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 39,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 203786,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 40,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 53775,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 41,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 161510,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 42,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 298194,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 43,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Fusion",
                            Odometer = 34187,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 44,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Durango",
                            Odometer = 69880,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 45,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 17577,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 46,
                            Colour = "Black",
                            Manufacturer = "Dodge",
                            Model = "Fusion",
                            Odometer = 241688,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 47,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 101030,
                            TrimLevel = "High Country"
                        },
                        new
                        {
                            ID = 48,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Fusion",
                            Odometer = 262649,
                            TrimLevel = "Awesome"
                        },
                        new
                        {
                            ID = 49,
                            Colour = "Black",
                            Manufacturer = "Chevrolet",
                            Model = "Corvette",
                            Odometer = 221038,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            ID = 50,
                            Colour = "Black",
                            Manufacturer = "Ford",
                            Model = "Durango",
                            Odometer = 60121,
                            TrimLevel = "R/T"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
