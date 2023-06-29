using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Revenue> Revenues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HEI2R4T\\SQLEXPRESS;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Car__3213E83FCD6B2901");

            entity.ToTable("Car");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.km).HasColumnName("km");
            entity.Property(e => e.name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.price).HasColumnName("price");
            entity.Property(e => e.year).HasColumnName("year");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contact");

            entity.Property(e => e.email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.firstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.lastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastName");
        });

        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.HasKey(e => e.Year).HasName("PK__Revenue__809A238AEB416AB5");

            entity.ToTable("Revenue");

            entity.Property(e => e.Year).HasColumnName("year");
            entity.Property(e => e.Amount).HasColumnName("amount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
