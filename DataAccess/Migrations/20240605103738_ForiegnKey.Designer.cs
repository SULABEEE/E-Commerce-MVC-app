﻿// <auto-generated />
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240605103738_ForiegnKey")]
    partial class ForiegnKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("displayOrder")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            displayOrder = 1,
                            name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            displayOrder = 1,
                            name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            displayOrder = 1,
                            name = "History"
                        });
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy Spark",
                            Category_Id = 1,
                            Description = "akdjaks asldijaslid asldijalidjgubr ggkruggd slfoksel",
                            ISBN = "SWD999921",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "One Man's Sky"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jason Brody",
                            Category_Id = 3,
                            Description = "akdjaks asldijaslid asldijalidjgubr ggkruggd slfoksel",
                            ISBN = "SWD999451",
                            ListPrice = 80.0,
                            Price = 75.0,
                            Price100 = 65.0,
                            Price50 = 70.0,
                            Title = "Rocky"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Tommy Frag",
                            Category_Id = 2,
                            Description = "akdjaks asldijaslid asldijalidjgubr ggkruggd slfoksel",
                            ISBN = "SWD993321",
                            ListPrice = 40.0,
                            Price = 45.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Invisible"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Abella Danger",
                            Category_Id = 3,
                            Description = "akdjaks asldijaslid asldijalidjgubr ggkruggd slfoksel",
                            ISBN = "SWD991911",
                            ListPrice = 120.0,
                            Price = 100.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Sambo"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Franky Modest",
                            Category_Id = 4,
                            Description = "akdjaks asldijaslid asldijalidjgubr ggkruggd slfoksel",
                            ISBN = "SWD941121",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Lust"
                        });
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.HasOne("Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
