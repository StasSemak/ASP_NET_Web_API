﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Data.Data;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(PhoneShopDbContext))]
    [Migration("20221001090706_AttributesAdded")]
    partial class AttributesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PhoneShop.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Battery")
                        .HasColumnType("int");

                    b.Property<string>("Camera")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<string>("Screen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Battery = 4500,
                            Camera = "12MP triple main, 32 MP front",
                            ImagePath = "https://fdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s20-fe-5g-1.jpg",
                            Model = "SAMSUNG Galaxy S20",
                            Price = 769.99m,
                            RAM = 8,
                            Screen = "6.5 inches",
                            Storage = 256
                        },
                        new
                        {
                            Id = 2,
                            Battery = 3240,
                            Camera = "12MP dual main, 12 MP front",
                            ImagePath = "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-01.jpg",
                            Model = "Apple iPhone 13",
                            Price = 829.99m,
                            RAM = 4,
                            Screen = "6.1 inches",
                            Storage = 256
                        },
                        new
                        {
                            Id = 3,
                            Battery = 4614,
                            Camera = "50MP dual main, 8 MP front",
                            ImagePath = "https://fdn2.gsmarena.com/vv/pics/google/google-pixel-6-1.jpg",
                            Model = "Google Pixel 6",
                            Price = 599m,
                            RAM = 8,
                            Screen = "6.4 inches",
                            Storage = 256
                        },
                        new
                        {
                            Id = 4,
                            Battery = 5000,
                            Camera = "50MP dual main, 8 MP front",
                            ImagePath = "https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-redmi-10-5g-1.jpg",
                            Model = "Xiaomi Redmi 11",
                            Price = 799.99m,
                            RAM = 6,
                            Screen = "6.58 inches",
                            Storage = 128
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
