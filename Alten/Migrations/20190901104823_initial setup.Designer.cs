﻿// <auto-generated />
using Alten.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alten.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190901104823_initial setup")]
    partial class initialsetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alten.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cementvägen 8, 111 11 Södertälje",
                            Name = "Kalles Grustransporter AB"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Balkvägen 12, 222 22 Stockholm",
                            Name = "Johans Bulk AB"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Budgetvägen 1, 333 33 Uppsala",
                            Name = "Haralds Värdetransporter AB"
                        });
                });

            modelBuilder.Entity("Alten.Models.CustomerVehicle", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<int>("VehicleId");

                    b.HasKey("CustomerId", "VehicleId");

                    b.ToTable("CustomerVehicles");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            VehicleId = 1
                        },
                        new
                        {
                            CustomerId = 1,
                            VehicleId = 2
                        },
                        new
                        {
                            CustomerId = 1,
                            VehicleId = 3
                        },
                        new
                        {
                            CustomerId = 2,
                            VehicleId = 4
                        },
                        new
                        {
                            CustomerId = 2,
                            VehicleId = 5
                        },
                        new
                        {
                            CustomerId = 3,
                            VehicleId = 6
                        },
                        new
                        {
                            CustomerId = 3,
                            VehicleId = 7
                        });
                });

            modelBuilder.Entity("Alten.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegistrationNo");

                    b.Property<string>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RegistrationNo = "ABC123",
                            VehicleId = "YS2R4X20005399401"
                        },
                        new
                        {
                            Id = 2,
                            RegistrationNo = "DEF456",
                            VehicleId = "VLUR4X20009093588"
                        },
                        new
                        {
                            Id = 3,
                            RegistrationNo = "GHI789",
                            VehicleId = "VLUR4X20009048066"
                        },
                        new
                        {
                            Id = 4,
                            RegistrationNo = "JKL012",
                            VehicleId = "YS2R4X20005388011"
                        },
                        new
                        {
                            Id = 5,
                            RegistrationNo = "MNO345",
                            VehicleId = "YS2R4X20005387949"
                        },
                        new
                        {
                            Id = 6,
                            RegistrationNo = "PQR678",
                            VehicleId = "VLUR4X20009048066"
                        },
                        new
                        {
                            Id = 7,
                            RegistrationNo = "STU901",
                            VehicleId = "YS2R4X20005387055"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
