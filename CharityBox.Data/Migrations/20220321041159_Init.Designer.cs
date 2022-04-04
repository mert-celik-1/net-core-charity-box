﻿// <auto-generated />
using System;
using CharityBox.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharityBox.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220321041159_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CharityBox.Core.Campaign", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CurrentMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<decimal>("Limit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Campaigns");

                    b.HasData(
                        new
                        {
                            Id = "05c699d5-2adf-4990-a7e2-751b9d1c66e2",
                            CategoryId = "1",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(3794),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 400m,
                            Name = "SMA hastası Ahmet için yardım kampanyası",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        },
                        new
                        {
                            Id = "aadf50b3-e6ec-4d0c-befd-fb831f8e138d",
                            CategoryId = "1",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(4133),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 100m,
                            Name = "4 yaşındaki Ali için tekerli sandalye hediyesi",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        },
                        new
                        {
                            Id = "eb5c302b-7bc6-4cb0-8a91-04ddb621025d",
                            CategoryId = "2",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(4142),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 400m,
                            Name = "Köy okullarına bağış kampanyası",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        },
                        new
                        {
                            Id = "5fe55630-7355-4e2e-aa76-3006ed334974",
                            CategoryId = "2",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(4147),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 100m,
                            Name = "Minik Elife burs ilanı ",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        },
                        new
                        {
                            Id = "ab61474f-7932-43f5-be1d-9b426a0ab3c6",
                            CategoryId = "3",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(4153),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 400m,
                            Name = "Sokak kedilerine yuva yapımı",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        },
                        new
                        {
                            Id = "fa43981f-f4cc-4eef-a291-da07fcad1fc8",
                            CategoryId = "3",
                            City = "Istanbul",
                            CreatedDate = new DateTime(2022, 3, 21, 7, 11, 58, 906, DateTimeKind.Local).AddTicks(4266),
                            CurrentMoney = 0m,
                            Description = "Kampanya için etiket yazısı",
                            IsDone = false,
                            IsRejected = false,
                            IsVerified = true,
                            Limit = 100m,
                            Name = "Barınaktaki dostlarımıza yemek bağışı ",
                            PhotoUrl = "default.jpg",
                            UserId = "2"
                        });
                });

            modelBuilder.Entity("CharityBox.Core.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Sağlık"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Eğitim"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Sokak Hayvanları"
                        });
                });

            modelBuilder.Entity("CharityBox.Core.Organizations", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccountNumber = "123456",
                            Balance = 0m,
                            Description = "",
                            Name = "Arama Kurtarma Derneği",
                            PhotoUrl = "akut.jpg",
                            ShortName = "AKUT"
                        },
                        new
                        {
                            Id = "2",
                            AccountNumber = "135478",
                            Balance = 0m,
                            Description = "",
                            Name = "Yeşilay Derneği",
                            PhotoUrl = "yesilay.jpg",
                            ShortName = "YEŞİLAY"
                        },
                        new
                        {
                            Id = "3",
                            AccountNumber = "985235",
                            Balance = 0m,
                            Description = "",
                            Name = "Lösemili Çocuklar Sağlık ve Eğitim Vakfı",
                            PhotoUrl = "losev.jpg",
                            ShortName = "LÖSEV"
                        },
                        new
                        {
                            Id = "4",
                            AccountNumber = "584923",
                            Balance = 0m,
                            Description = "",
                            Name = "Türkiye Kızılay Derneği",
                            PhotoUrl = "kizilay.jpg",
                            ShortName = "KIZILAY"
                        },
                        new
                        {
                            Id = "5",
                            AccountNumber = "582319",
                            Balance = 0m,
                            Description = "",
                            Name = "Türkiye Erozyonla Mücadele Ağaçlandırma ve Doğal Varlıkları Koruma Vakfı",
                            PhotoUrl = "tema.jpg",
                            ShortName = "TEMA"
                        },
                        new
                        {
                            Id = "6",
                            AccountNumber = "594921",
                            Balance = 0m,
                            Description = "",
                            Name = "Toplum Gönüllüleri Vakfı",
                            PhotoUrl = "tog.jpg",
                            ShortName = "TOG"
                        },
                        new
                        {
                            Id = "7",
                            AccountNumber = "124553",
                            Balance = 0m,
                            Description = "",
                            Name = "Türkiye Eğitim Gönüllüleri Vakfı",
                            PhotoUrl = "tegv.jpg",
                            ShortName = "TEGV"
                        },
                        new
                        {
                            Id = "8",
                            AccountNumber = "112336",
                            Balance = 0m,
                            Description = "",
                            Name = "Tüvana Okuma İstekli Çocuk Eğitim Vakfı",
                            PhotoUrl = "tocev.jpg",
                            ShortName = "TOÇEV"
                        },
                        new
                        {
                            Id = "9",
                            AccountNumber = "865346",
                            Balance = 0m,
                            Description = "",
                            Name = "Anne Çocuk Eğitim Vakfı",
                            PhotoUrl = "acev.jpg",
                            ShortName = "AÇEV"
                        },
                        new
                        {
                            Id = "10",
                            AccountNumber = "456754",
                            Balance = 0m,
                            Description = "",
                            Name = "Darüşşafaka Cemiyeti",
                            PhotoUrl = "darussafaka.jpg",
                            ShortName = "DARÜŞŞAFAKA"
                        });
                });

            modelBuilder.Entity("CharityBox.Core.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CharityBox.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Balance = 1500m,
                            City = "Istanbul",
                            ConcurrencyStamp = "c50851a4-9a0e-4502-b33b-266e114a64fe",
                            Email = "mertcelik@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mert",
                            IsAdmin = false,
                            LastName = "Çelik",
                            LockoutEnabled = false,
                            PasswordHash = "E4FDC41E7458B7A4B128154A181D2C305133226909CF5B9DB3BD21B9884717AFA03A2096E201E2DC056C55D8C3F69164D08ECA3167FA074E1088940EE49EBB87",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "mertcelik"
                        },
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Balance = 1500m,
                            ConcurrencyStamp = "c2707b60-c77d-4b2f-ab00-6d5f0c54c1c2",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            IsAdmin = true,
                            LockoutEnabled = false,
                            PasswordHash = "E4FDC41E7458B7A4B128154A181D2C305133226909CF5B9DB3BD21B9884717AFA03A2096E201E2DC056C55D8C3F69164D08ECA3167FA074E1088940EE49EBB87",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("CharityBox.Core.UserRefreshToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CharityBox.Core.Campaign", b =>
                {
                    b.HasOne("CharityBox.Core.Category", "Category")
                        .WithMany("Campaigns")
                        .HasForeignKey("CategoryId");

                    b.HasOne("CharityBox.Core.User", "User")
                        .WithMany("Campaigns")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CharityBox.Core.Transaction", b =>
                {
                    b.HasOne("CharityBox.Core.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
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
                    b.HasOne("CharityBox.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CharityBox.Core.User", null)
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

                    b.HasOne("CharityBox.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CharityBox.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharityBox.Core.Category", b =>
                {
                    b.Navigation("Campaigns");
                });

            modelBuilder.Entity("CharityBox.Core.User", b =>
                {
                    b.Navigation("Campaigns");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}