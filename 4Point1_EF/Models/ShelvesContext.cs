﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPractice.Models
{
    public partial class ShelvesContext : DbContext
    {
        public ShelvesContext()
        {

        }

        public ShelvesContext(DbContextOptions<ShelvesContext> options) : base(options)
        {

        }

        // These properties allow the context to be read and written to.
        public virtual DbSet<Shelves> Shelves { get; set; }

        // Called when we're configuring a database connection.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                // Initialize the connection to a MySQL server.
                optionsBuilder
                    .UseMySql("server=localhost;port=3306;user=root;database=code_first_practice",
                        // Retreived from PHPMyAdmin under Home > Database Server > Server Version.
                        x => x.ServerVersion("10.4.14-MariaDB"));

                /*
                    Connection strings are used to define an entire connection profile in one string. They are composed of attributes and values separated by semicolons.
                    
                    server=VALUE - Declares the server address for the connection.
                    port=VALUE - Declares the port for the conenction.
                    user=VALUE - Declares the database username for the connection.
                    password=VALUE - Declares that username's password for the connection (if applicable).
                    database=VALUE - Declares the database name to connect to.
                */

                // server=localhost;port=3306;user=root;database=code_first_cars
            }
        }

        // Called when we're doing database migrations, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelves>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                /*
                entity.HasData(
                    new Manufacturer() { ID = 1, Name = "Chevrolet", YearFounded = 1911 },
                    new Manufacturer() { ID = 2, Name = "Ford", YearFounded = 1903 },
                    new Manufacturer() { ID = 3, Name = "Tesla", YearFounded = null },
                    new Manufacturer() { ID = 4, Name = "Dodge", YearFounded = null },
                    new Manufacturer() { ID = 5, Name = "Toyota", YearFounded = 1937 },
                    new Manufacturer() { ID = 6, Name = "Honda", YearFounded = 1946 },
                    new Manufacturer() { ID = 7, Name = "Mitsubishi", YearFounded = null },
                    new Manufacturer() { ID = 8, Name = "Nissan", YearFounded = null }
                    );
                */
            });



            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
