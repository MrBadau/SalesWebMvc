﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.Models;

namespace Sales.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sales.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("Sales.Models.SallesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SallesRecord");
                });

            modelBuilder.Entity("Sales.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartamentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("Sales.Models.SallesRecord", b =>
                {
                    b.HasOne("Sales.Models.Seller", "Seller")
                        .WithMany("Salles")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("Sales.Models.Seller", b =>
                {
                    b.HasOne("Sales.Models.Departament", "Departament")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartamentId");
                });
#pragma warning restore 612, 618
        }
    }
}