using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using data_karyawan_backend.Models;

namespace data_karyawan_backend.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataKaryawan> DataKaryawans { get; set; }

    public virtual DbSet<Negara> Negaras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DataKaryawan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("data_karyawan");

            entity.HasIndex(e => e.IdNegara, "fk_data_karyawan_negara");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Alamat)
                .HasColumnType("text")
                .HasColumnName("alamat");
            entity.Property(e => e.DibuatTgl)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("dibuat_tgl");
            entity.Property(e => e.IdNegara)
                .HasColumnType("int(11)")
                .HasColumnName("id_negara");
            entity.Property(e => e.JenisKelamin)
                .HasColumnType("enum('Laki-laki','Perempuan')")
                .HasColumnName("jenis_kelamin");
            entity.Property(e => e.Nama)
                .HasMaxLength(255)
                .HasColumnName("nama");
            entity.Property(e => e.Nik)
                .HasMaxLength(20)
                .HasColumnName("nik");
            entity.Property(e => e.TanggalLahir).HasColumnName("tanggal_lahir");

            entity.HasOne(d => d.IdNegaraNavigation).WithMany(p => p.DataKaryawans)
                .HasForeignKey(d => d.IdNegara)
                .HasConstraintName("fk_data_karyawan_negara");
        });

        modelBuilder.Entity<Negara>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("negara");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DibuatTgl)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("dibuat_tgl");
            entity.Property(e => e.Negara1)
                .HasMaxLength(255)
                .HasColumnName("negara");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
