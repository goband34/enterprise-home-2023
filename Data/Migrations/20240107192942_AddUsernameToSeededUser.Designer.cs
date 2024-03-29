﻿// <auto-generated />
using System;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AirlineDbContext))]
    [Migration("20240107192942_AddUsernameToSeededUser")]
    partial class AddUsernameToSeededUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("Domain.Models.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Columns")
                        .HasColumnType("INTEGER");

                    b.Property<double>("CommissionRate")
                        .HasColumnType("REAL");

                    b.Property<string>("CountryFrom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rows")
                        .HasColumnType("INTEGER");

                    b.Property<double>("WholesalePrice")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArrivalDate = new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Columns = 5,
                            CommissionRate = 0.5,
                            CountryFrom = "Italy",
                            CountryTo = "France",
                            DepartureDate = new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rows = 5,
                            WholesalePrice = 50.0
                        },
                        new
                        {
                            ID = 2,
                            ArrivalDate = new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Columns = 5,
                            CommissionRate = 2.0,
                            CountryFrom = "Spain",
                            CountryTo = "Japan",
                            DepartureDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rows = 7,
                            WholesalePrice = 650.0
                        },
                        new
                        {
                            ID = 3,
                            ArrivalDate = new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Columns = 4,
                            CommissionRate = 1.5,
                            CountryFrom = "Australia",
                            CountryTo = "Russia",
                            DepartureDate = new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rows = 10,
                            WholesalePrice = 450.0
                        },
                        new
                        {
                            ID = 4,
                            ArrivalDate = new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Columns = 1,
                            CommissionRate = 0.02,
                            CountryFrom = "Moldova",
                            CountryTo = "Germany",
                            DepartureDate = new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rows = 1,
                            WholesalePrice = 300.0
                        });
                });

            modelBuilder.Entity("Domain.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Column")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlightFK")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PricePaid")
                        .HasColumnType("REAL");

                    b.Property<int>("Row")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("FlightFK");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d515222e-12a0-4dcd-8871-a39f4df1f098",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "51e93285-51b2-4800-993e-a04615045079",
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PassportNumber = "",
                            PasswordHash = "AQAAAAEAACcQAAAAEJhi7VFnYQws6f/9IXYe2//s2GWawzgIkIe/1+yBRxMVbkl+1gdkEf5bY/Q4nIHUtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c9beaca3-6746-4f8f-9661-0da77ad70af2",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fbf286f3-355a-406d-b107-2bcbaab2139a",
                            ConcurrencyStamp = "a5d3fe2e-816b-48b6-9615-91070091df65",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2fb79bf0-82b4-41a3-bf55-74f43e150dc3",
                            ConcurrencyStamp = "9c695dd1-d54f-42a7-ba2b-44c1222a4b25",
                            Name = "Normal",
                            NormalizedName = "NORMAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d515222e-12a0-4dcd-8871-a39f4df1f098",
                            RoleId = "fbf286f3-355a-406d-b107-2bcbaab2139a"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Ticket", b =>
                {
                    b.HasOne("Domain.Models.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Flight", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
