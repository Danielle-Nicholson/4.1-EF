﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExistingDBPractice.Models
{
    public partial class PersonContext : DbContext
    {
        public PersonContext()
        {
        }

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        public virtual DbSet<EmailAddress> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=existing_db_practice", x => x.ServerVersion("10.4.14-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasIndex(e => e.PersonID)
                    .HasName("FK_PhoneNumber_Person");

                entity.Property(e => e.Number)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.PersonID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhoneNumber_Person");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasIndex(e => e.PersonID)
                    .HasName("FK_EmailAddress_Person");

                entity.Property(e => e.Email)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.PersonID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailAddress_Person");

                entity.HasData(
                        new EmailAddress()
                        {
                            ID = 1,
                            Email = "johndoe@email.com",
                            PersonID = 1
                        },
                        new EmailAddress()
                        {
                            ID = 2,
                            Email = "janedoe@email.com",
                            PersonID = 2
                        },
                        new EmailAddress()
                        {
                            ID = 3,
                            Email = "tommywiseau@theroom.com",
                            PersonID = 3
                        },
                        new EmailAddress()
                        {
                            ID = 4,
                            Email = "jimmysmith@email.com",
                            PersonID = 4
                        },
                        new EmailAddress()
                        {
                            ID = 5,
                            Email = "sallysmith@email.com",
                            PersonID = 5
                        }
                    );
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
