﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Traveler.Destinations.Api.Infra.Data.Context;

#nullable disable

namespace Traveler.Destinations.Api.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221105210032_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.BookmarkedDestination.BookmarkedDestination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("BookmarkedDestinations", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.ClimateStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("ClimateStatus", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Quente"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chuvoso"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Nevando"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Frio"
                        });
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("TEXT")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("UpdatedAt");

                    b.Property<int>("_averageSpendId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AverageSpendId");

                    b.HasKey("Id");

                    b.HasIndex("_averageSpendId");

                    b.ToTable("Destinations", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationAverageSpend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("DestinationAverageSpend", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Baixo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Médio"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Alto"
                        });
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationClimateAverage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Max")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Max");

                    b.Property<int>("Min")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Min");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.ToTable("DestinationClimateAverage", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Url");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("DestinationImages", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("TagId");

                    b.ToTable("DestinationTagList", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("DestinationTags", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Montanhas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Praias"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cachoeiras"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Trilhas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pontos Turísticos"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Lugares Históricos"
                        });
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.RouteCoordinates", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DestinationId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL")
                        .HasColumnName("Latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL")
                        .HasColumnName("Longitude");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("RouteCoordinates", (string)null);
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.BookmarkedDestination.BookmarkedDestination", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", null)
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationAverageSpend", "AverageSpend")
                        .WithMany()
                        .HasForeignKey("_averageSpendId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AverageSpend");
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationClimateAverage", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", null)
                        .WithOne("ClimateAverage")
                        .HasForeignKey("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationClimateAverage", "DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.ClimateStatus", null)
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationImage", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", null)
                        .WithMany("Images")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationTag", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", null)
                        .WithMany("Tags")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.DestinationTags", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.RouteCoordinates", b =>
                {
                    b.HasOne("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", null)
                        .WithMany("Route")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveler.Destinations.Api.Domain.Aggregates.DestinationAggregate.Destination", b =>
                {
                    b.Navigation("ClimateAverage");

                    b.Navigation("Images");

                    b.Navigation("Route");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}