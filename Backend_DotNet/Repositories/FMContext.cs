using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FM_DotNet.Models;

namespace FM_DotNet.Repositories;

public partial class FMContext : DbContext
{
    public FMContext()
    {
    }

    public FMContext(DbContextOptions<FMContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddOn> AddOns { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarType> CarTypes { get; set; }

    public virtual DbSet<CityMaster> CityMasters { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Hub> Hubs { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;uid=sqluser;pwd=password;database=FM");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddOn>(entity =>
        {
            entity.HasKey(e => e.AddonId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.AirportId).HasName("PRIMARY");

            entity.HasOne(d => d.City).WithMany(p => p.Airports).HasConstraintName("FK2yld6il0wug59fgxke2ak2c5o");

            entity.HasOne(d => d.Hub).WithMany(p => p.Airports).HasConstraintName("FKsjl3o7kbfo2lblgsihfx35odv");

            entity.HasOne(d => d.State).WithMany(p => p.Airports).HasConstraintName("FKalg2cgcxjwipmkb90s9h4hfhe");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PRIMARY");

            entity.HasOne(d => d.Cartype).WithMany(p => p.Bookings).HasConstraintName("FK1iw8k5qheeqk041n43wishifu");

            entity.HasOne(d => d.Cust).WithMany(p => p.Bookings).HasConstraintName("FK57t2cgb8xr3mn2vms6j6t55ws");
        });

        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => e.BookingDetailId).HasName("PRIMARY");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK59941ondg9nwaifm2umnrduev");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PRIMARY");

            entity.HasOne(d => d.CarType).WithMany(p => p.Cars).HasConstraintName("FKggtv0dpqfowlhobef4e9qrdlm");

            entity.HasOne(d => d.Hub).WithMany(p => p.Cars).HasConstraintName("FKlannauot1phgh8tglmui81t8f");
        });

        modelBuilder.Entity<CarType>(entity =>
        {
            entity.HasKey(e => e.CarTypeId).HasName("PRIMARY");
        });

        modelBuilder.Entity<CityMaster>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PRIMARY");

            entity.HasOne(d => d.State).WithMany(p => p.CityMasters).HasConstraintName("FKfxtjuwt9iqx9n7xl6f8wl6uu4");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Hub>(entity =>
        {
            entity.HasKey(e => e.HubId).HasName("PRIMARY");

            entity.HasOne(d => d.City).WithMany(p => p.Hubs).HasConstraintName("FKje7oa2pw4xmhwh24felm6b8et");

            entity.HasOne(d => d.State).WithMany(p => p.Hubs).HasConstraintName("FKhkq33ikm1jpvqwpg0fm42ojv0");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PRIMARY");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.IdetailId).HasName("PRIMARY");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
