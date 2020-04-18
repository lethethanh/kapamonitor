﻿// <auto-generated />
using System;
using KapaMonitor.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace KapaMonitor.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200404160928_Mig_1")]
    partial class Mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("KapaMonitor.Domain.Internal.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ErrorCode")
                        .HasColumnType("integer");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("text");

                    b.Property<string>("Object")
                        .HasColumnType("text");

                    b.Property<string>("StackTrace")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FbUserId")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Gym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Area")
                        .HasColumnType("double precision");

                    b.Property<bool>("BarrierFree")
                        .HasColumnType("boolean");

                    b.Property<int>("Beds")
                        .HasColumnType("integer");

                    b.Property<bool>("HeavyCurrent")
                        .HasColumnType("boolean");

                    b.Property<double>("HeavyCurrentCapacity")
                        .HasColumnType("double precision");

                    b.Property<int>("QuantityWaterConnections")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Gyms");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("BarrierFree")
                        .HasColumnType("boolean");

                    b.Property<int>("BedsWithVentilator")
                        .HasColumnType("integer");

                    b.Property<int>("BedsWithoutVentilator")
                        .HasColumnType("integer");

                    b.Property<string>("IkId")
                        .HasColumnType("text");

                    b.Property<bool>("IsEmergencyHospital")
                        .HasColumnType("boolean");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BedsWithVentilatorOtherFLoor")
                        .HasColumnType("integer");

                    b.Property<int>("BedsWithVentilatorWithCarpet")
                        .HasColumnType("integer");

                    b.Property<int>("BedsWithoutVentilatorOtherFLoor")
                        .HasColumnType("integer");

                    b.Property<int>("BedsWithoutVentilatorWithCarpet")
                        .HasColumnType("integer");

                    b.Property<string>("FireProtectionsRegulations")
                        .HasColumnType("text");

                    b.Property<double>("HeavyCurentCapacity")
                        .HasColumnType("double precision");

                    b.Property<bool>("HeavyCurrent")
                        .HasColumnType("boolean");

                    b.Property<int>("KitchenCapacity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AccessToInternet")
                        .HasColumnType("boolean");

                    b.Property<string>("Accessability")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("GeoLatitude")
                        .HasColumnType("text");

                    b.Property<string>("GeoLongitude")
                        .HasColumnType("text");

                    b.Property<int?>("GymId")
                        .HasColumnType("integer");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("integer");

                    b.Property<int?>("HotelId")
                        .HasColumnType("integer");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("text");

                    b.Property<string>("PostCode")
                        .HasColumnType("text");

                    b.Property<int?>("SanitaryInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("GymId")
                        .IsUnique();

                    b.HasIndex("HotelId")
                        .IsUnique();

                    b.HasIndex("SanitaryInfoId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.SanitaryInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("BarrierFree")
                        .HasColumnType("boolean");

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityBathrooms")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityShowers")
                        .HasColumnType("integer");

                    b.Property<int>("QuantitySinks")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityToilents")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SanitaryInfos");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Hospital", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.Location", "Location")
                        .WithOne("Hospital")
                        .HasForeignKey("KapaMonitor.Domain.Models.Hospital", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Location", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.ContactInfo", "ContactInfo")
                        .WithMany("Location")
                        .HasForeignKey("ContactInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Gym", "Gym")
                        .WithOne("Location")
                        .HasForeignKey("KapaMonitor.Domain.Models.Location", "GymId");

                    b.HasOne("KapaMonitor.Domain.Models.Hotel", "Hotel")
                        .WithOne("Location")
                        .HasForeignKey("KapaMonitor.Domain.Models.Location", "HotelId");

                    b.HasOne("KapaMonitor.Domain.Models.SanitaryInfo", "SanitaryInfo")
                        .WithOne("Location")
                        .HasForeignKey("KapaMonitor.Domain.Models.Location", "SanitaryInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}