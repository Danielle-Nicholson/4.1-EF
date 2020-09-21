using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPractice.Models
{
    public partial class ShelfContext : DbContext
    {
        public ShelfContext()
        {

        }

        public ShelfContext(DbContextOptions<ShelfContext> options) : base(options)
        {

        }

        // These properties allow the context to be read and written to.
        public virtual DbSet<Shelf> Shelves { get; set; }
        public virtual DbSet<ShelfMaterial> ShelfMaterials { get; set; }

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
            modelBuilder.Entity<ShelfMaterial>(entity =>
            {
                entity.Property(e => e.MaterialName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                
                entity.HasData(
                    new ShelfMaterial()
                    {
                        ID = -1,
                        MaterialName = "Wood"
                    },
                    new ShelfMaterial()
                    {
                        ID = -2,
                        MaterialName = "Steel"
                    },
                    new ShelfMaterial()
                    {
                        ID = -3,
                        MaterialName = "Plastic"
                    }
                );
                    
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.HasIndex(e => e.MaterialID)
                   .HasName("FK_" + nameof(Shelf) + "_" + nameof(ShelfMaterial));

                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                // Enforce the Foreign Key
                // Specify the relationship between the child and parent
                entity.HasOne(child => child.Material)
                // Specify the relationship between the parent and child(ren)
                    .WithMany(parent => parent.Shelves)
                // Specify the property acting as the foreign key
                    .HasForeignKey(child => child.MaterialID)
                // Specify delete behaviour
                    .OnDelete(DeleteBehavior.Restrict)
                // Name the foreign key
                    .HasConstraintName("FK_"+nameof(Shelf)+"_"+nameof(ShelfMaterial));

                /*
                entity.HasData(
                    new Shelf() { ID = -1, Name = "Tools Shelf"},
                    new Shelf() { ID = -2, Name = "Electronics Shelf" },
                    new Shelf() { ID = -3, Name = "Food Shelf" },
                    new Shelf() { ID = -4, Name = "Dishes Shelf" },
                    new Shelf() { ID = -5, Name = "Book Shelf" }
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
