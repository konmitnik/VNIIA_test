using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VNIIA_test.Models;

namespace VNIIA_test.AppContext;

public partial class VniiaSharpContext : DbContext
{
    private readonly IConfiguration Configuration;
    public VniiaSharpContext()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..")
            .AddJsonFile("appsettings.json")
            .Build();
    }

    public VniiaSharpContext(DbContextOptions<VniiaSharpContext> options)
        : base(options)
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..")
            .AddJsonFile("appsettings.json")
            .Build();
    }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(Configuration.GetConnectionString("PostgreSQL"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_pkey");

            entity.ToTable("document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("position_pkey");

            entity.ToTable("position");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Sum).HasColumnName("sum");

            entity.HasOne(d => d.Doc).WithMany(p => p.Positions)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("position_doc_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
