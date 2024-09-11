using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FitCenter.Models;

public partial class FitCenterContext : DbContext
{
    public FitCenterContext()
    {
    }

    public FitCenterContext(DbContextOptions<FitCenterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Trener> Treners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=fit_center;Username=postgres;Password=123;Persist Security Info=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_pkey");

            entity.ToTable("client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abonement).HasColumnName("abonement");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("data");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<Trener>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("trener_pkey");

            entity.ToTable("trener");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Minage).HasColumnName("minage");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Rod).HasColumnName("rod");
            entity.Property(e => e.Spis).HasColumnName("spis");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
