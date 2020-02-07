﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterProject.Api.Data;

namespace StarterProject.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190502024231_Add_Tokens")]
    partial class Add_Tokens
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.HasKey("Id");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Host"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Waiter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bartender"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Busser"
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailabilityId");

                    b.Property<int?>("PositionId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityId");

                    b.HasIndex("PositionId");

                    b.HasIndex("UserId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("StarterProject.Api.Data.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Role");

                    b.Property<string>("State");

                    b.Property<string>("Username");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Seeded-Admin-Adress",
                            City = "Seeded-Admin-City",
                            Email = "admin@admin.com",
                            FirstName = "Seeded-Admin-FirstName",
                            LastName = "Seeded-Admin-LastName",
                            PasswordHash = new byte[] { 96, 216, 212, 185, 190, 141, 198, 215, 240, 132, 239, 210, 143, 112, 55, 129, 203, 2, 78, 92 },
                            PasswordSalt = new byte[] { 199, 113, 40, 28, 93, 184, 230, 72, 104, 189, 48, 18, 107, 172, 62, 227 },
                            PhoneNumber = "Seeded-Admin-PhoneNumber",
                            Role = "Admin",
                            State = "Seeded-Admin-State",
                            Username = "admin",
                            ZipCode = "Seeded-Admin-ZipCode"
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Schedule", b =>
                {
                    b.HasOne("StarterProject.Api.Data.Entites.Availability", "Availability")
                        .WithMany("Schedules")
                        .HasForeignKey("AvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StarterProject.Api.Data.Entites.Position", "Position")
                        .WithMany("Schedules")
                        .HasForeignKey("PositionId");

                    b.HasOne("StarterProject.Api.Features.Users.User", "User")
                        .WithMany("Schedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StarterProject.Api.Data.Token", b =>
                {
                    b.HasOne("StarterProject.Api.Features.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
