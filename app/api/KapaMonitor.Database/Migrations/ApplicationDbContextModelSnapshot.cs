﻿// <auto-generated />
using System;
using KapaMonitor.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace KapaMonitor.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Object")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StackTrace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int?>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("text");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId")
                        .IsUnique();

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResourceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.ContactInfoLocation", b =>
                {
                    b.Property<int>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("ContactInfoId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("ContactInfoLocation");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.OfferCertificate", b =>
                {
                    b.Property<int>("OfferId")
                        .HasColumnType("integer");

                    b.Property<int>("CertificateId")
                        .HasColumnType("integer");

                    b.HasKey("OfferId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("OfferCertificate");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.RequirementCertificate", b =>
                {
                    b.Property<int>("RequirementId")
                        .HasColumnType("integer");

                    b.Property<int>("CertificateId")
                        .HasColumnType("integer");

                    b.HasKey("RequirementId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("RequirementCertificate");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastChangedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.Property<float>("Number")
                        .HasColumnType("real");

                    b.Property<int>("ResourceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Requirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("AlreadySatisfied")
                        .HasColumnType("real");

                    b.Property<int>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<float>("CreationDate")
                        .HasColumnType("real");

                    b.Property<DateTime?>("LastChangedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<float>("Number")
                        .HasColumnType("real");

                    b.Property<int>("ResourceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UnitOfMeasureName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UnitOfMeasureName");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.UnitOfMeasure", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("UnitsOfMeasure");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Address", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.ContactInfo", "ContactInfo")
                        .WithOne("Address")
                        .HasForeignKey("KapaMonitor.Domain.Models.Address", "ContactInfoId");

                    b.HasOne("KapaMonitor.Domain.Models.Location", "Location")
                        .WithOne("Address")
                        .HasForeignKey("KapaMonitor.Domain.Models.Address", "LocationId");
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Certificate", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.Resource", "Resource")
                        .WithMany("Certificates")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.ContactInfoLocation", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.ContactInfo", "ContactInfo")
                        .WithMany("ContactInfoLocations")
                        .HasForeignKey("ContactInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Location", "Location")
                        .WithMany("ContactInfoLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.OfferCertificate", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.Certificate", "Certificate")
                        .WithMany("OfferCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Offer", "Offer")
                        .WithMany("OfferCertificates")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.ManyToManyHelper.RequirementCertificate", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.Certificate", "Certificate")
                        .WithMany("RequirementCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Requirement", "Requirement")
                        .WithMany("RequirementCertificates")
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Offer", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.ContactInfo", "ContactInfo")
                        .WithMany("Offers")
                        .HasForeignKey("ContactInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Location", "Location")
                        .WithMany("Offers")
                        .HasForeignKey("LocationId");

                    b.HasOne("KapaMonitor.Domain.Models.Resource", "Resource")
                        .WithMany("Offers")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Requirement", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.ContactInfo", "ContactInfo")
                        .WithMany("Requirements")
                        .HasForeignKey("ContactInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KapaMonitor.Domain.Models.Resource", "Resource")
                        .WithMany("Requirements")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KapaMonitor.Domain.Models.Resource", b =>
                {
                    b.HasOne("KapaMonitor.Domain.Models.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany("Resources")
                        .HasForeignKey("UnitOfMeasureName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
