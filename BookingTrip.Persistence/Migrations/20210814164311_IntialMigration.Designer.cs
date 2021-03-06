// <auto-generated />
using System;
using BookingTrip.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingTrip.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210814164311_IntialMigration")]
    partial class IntialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingTrip.Domin.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerName = "Ahmed Hassan",
                            Email = "ahmedHassan@gmail.com",
                            Password = "012345-ABcd"
                        });
                });

            modelBuilder.Entity("BookingTrip.Domin.ReservationTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResreverdByCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerName = "Ahmed Hassan",
                            Note = "mxmacmcffewp",
                            ReservationDate = new DateTime(2011, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResreverdByCustomerId = 1,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("BookingTrip.Domin.TripDetails", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TripName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("tripDetails");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            CityName = "Cairo",
                            Content = " Some Content",
                            CreationDate = new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "skxksxskx ",
                            Price = 1000,
                            TripName = "Cairo museum"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
