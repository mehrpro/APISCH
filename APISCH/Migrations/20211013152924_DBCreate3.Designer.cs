﻿// <auto-generated />
using System;
using APISCH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APISCH.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211013152924_DBCreate3")]
    partial class DBCreate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APISCH.Entities.ImportExport", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ImportExportType")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TagID")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("ID");

                    b.ToTable("ImportExports");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            ImportExportType = true,
                            IsActive = true,
                            RegisterTime = new DateTime(2021, 10, 13, 18, 59, 24, 64, DateTimeKind.Local).AddTicks(4581),
                            TagID = "110A02EF1250"
                        });
                });

            modelBuilder.Entity("APISCH.Entities.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("RegisterTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            ID = "44fb0dc9-2ad5-42db-9691-503fb4334a64",
                            Age = (byte)35,
                            FName = "Farshid",
                            IsActive = true,
                            LName = "Mohammadi",
                            PhoneNumber = "9186620474",
                            RegisterTime = new DateTime(2021, 10, 13, 18, 59, 24, 66, DateTimeKind.Local).AddTicks(4550)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}