﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalksAPI.Data;

#nullable disable

namespace NZWalksAPI.Migrations
{
    [DbContext(typeof(NzWalksDbContext))]
    partial class NzWalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalksAPI.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("area")
                        .HasColumnType("float");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longtitude")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("regions");
                });

            modelBuilder.Entity("NZWalksAPI.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("length")
                        .HasColumnType("float");

                    b.Property<Guid>("regionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("walkDifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("regionId");

                    b.HasIndex("walkDifficultyId");

                    b.ToTable("walks");
                });

            modelBuilder.Entity("NZWalksAPI.Models.Domain.WalkDifficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("walkDifficulty");
                });

            modelBuilder.Entity("NZWalksAPI.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalksAPI.Models.Domain.Region", "region")
                        .WithMany("walks")
                        .HasForeignKey("regionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalksAPI.Models.Domain.WalkDifficulty", "walkDifficulty")
                        .WithMany()
                        .HasForeignKey("walkDifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("region");

                    b.Navigation("walkDifficulty");
                });

            modelBuilder.Entity("NZWalksAPI.Models.Domain.Region", b =>
                {
                    b.Navigation("walks");
                });
#pragma warning restore 612, 618
        }
    }
}
