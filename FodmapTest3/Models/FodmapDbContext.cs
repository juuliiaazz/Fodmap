using System;
using System.Collections.Generic;
using FodmapTest3.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FodmapTest3.Models;

public partial class FodmapDbContext : DbContext
{


    

        public FodmapDbContext(DbContextOptions<FodmapDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<RedFodmap> RedFodmaps { get; set; }

    public virtual DbSet<YellowFodmap> YellowFodmaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=fodmap-db;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Gtin);

            entity.ToTable("Articles");

            entity.Property(e => e.Gtin)
                .HasMaxLength(150)
                .HasColumnName("GTIN");
            entity.Property(e => e.Hyllkantstext).HasMaxLength(50);
            entity.Property(e => e.Ingrediensforteckning);
            entity.Property(e => e.PictureUrl)
                .HasMaxLength(150)
                .HasColumnName("PictureURL");
            entity.Property(e => e.Varumarke).HasMaxLength(50);
            entity.Property(e => e.RedFodmap);
            entity.Property(e => e.YellowFodmap);
        });

        modelBuilder.Entity<RedFodmap>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("RedFodmaps");

            entity.Property(e => e.Id).HasMaxLength(150);
            entity.Property(e => e.RedFodmapList).HasMaxLength(50);
            
        });

        modelBuilder.Entity<YellowFodmap>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("YellowFodmaps");

            entity.Property(e => e.Id).HasMaxLength(150);
            entity.Property(e => e.YellowFodmapList).HasMaxLength(50);

        });

      

        OnModelCreatingPartial(modelBuilder);

    }

    


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
