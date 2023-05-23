﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20230522184545_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("API.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("API.Entities.LotNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BagCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LotNumbers");
                });

            modelBuilder.Entity("API.Entities.Packaging", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Packaging");
                });

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BagNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DecantNote")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GradeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LotNumberId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PackagingId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("LotNumberId");

                    b.HasIndex("PackagingId");

                    b.HasIndex("StatusId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("API.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.HasOne("API.Entities.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");

                    b.HasOne("API.Entities.LotNumber", "LotNumber")
                        .WithMany()
                        .HasForeignKey("LotNumberId");

                    b.HasOne("API.Entities.Packaging", "Packaging")
                        .WithMany()
                        .HasForeignKey("PackagingId");

                    b.HasOne("API.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("API.Entities.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId");

                    b.Navigation("Grade");

                    b.Navigation("LotNumber");

                    b.Navigation("Packaging");

                    b.Navigation("Status");

                    b.Navigation("Warehouse");
                });
#pragma warning restore 612, 618
        }
    }
}
