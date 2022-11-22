using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace flight.DAL.Models
{
    public partial class TravelAgencyContext : DbContext
    {
        public TravelAgencyContext()
        {
        }

        public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airline> Airlines { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<FlightDetail> FlightDetails { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<TravelAgency> TravelAgencies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V7F3D08\\MSSQLSERVER01;Database=TravelAgency;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(35)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .HasColumnName("description")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.FlightId).ValueGeneratedNever();

                entity.Property(e => e.AirlineCode).HasColumnName("airlineCode");

                entity.Property(e => e.DateF)
                    .HasColumnType("date")
                    .HasColumnName("dateF");

                entity.Property(e => e.NumberOfSeats).HasColumnName("numberOfSeats");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.TerminalNumber).HasColumnName("terminalNumber");

                entity.HasOne(d => d.AirlineCodeNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.AirlineCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flight__airlineC__300424B4");

                entity.HasOne(d => d.CountryOfOriginCodeNavigation)
                    .WithMany(p => p.FlightCountryOfOriginCodeNavigations)
                    .HasForeignKey(d => d.CountryOfOriginCode)
                    .HasConstraintName("FK__Flight__CountryO__30F848ED");

                entity.HasOne(d => d.DestinationCountryCodeNavigation)
                    .WithMany(p => p.FlightDestinationCountryCodeNavigations)
                    .HasForeignKey(d => d.DestinationCountryCode)
                    .HasConstraintName("FK__Flight__Destinat__31EC6D26");
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasKey(e => e.OrderNumber)
                    .HasName("PK__FlightDe__2B1AFC1E481FC2D3");

                entity.Property(e => e.OrderNumber).HasColumnName("order number");

                entity.Property(e => e.FlightCode).HasColumnName("flightCode");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.FlightCodeNavigation)
                    .WithMany(p => p.FlightDetails)
                    .HasForeignKey(d => d.FlightCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlightDet__fligh__32E0915F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FlightDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FlightDet__userI__33D4B598");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .HasColumnName("description")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TravelAgency>(entity =>
            {
                entity.HasKey(e => e.AgencyCode)
                    .HasName("PK__TravelAg__5AB9C01CBA7F6ED7");

                entity.ToTable("TravelAgency");

                entity.Property(e => e.AgencyCode)
                    .ValueGeneratedNever()
                    .HasColumnName("agencyCode");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.ManegerId).HasColumnName("manegerId");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.TravelAgencies)
                    .HasForeignKey(d => d.FlightId)
                    .HasConstraintName("FK__TravelAge__fligh__34C8D9D1");

                entity.HasOne(d => d.Maneger)
                    .WithMany(p => p.TravelAgencies)
                    .HasForeignKey(d => d.ManegerId)
                    .HasConstraintName("FK__TravelAge__maneg__35BCFE0A");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(15)
                    .HasColumnName("first name")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(15)
                    .HasColumnName("last name")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
