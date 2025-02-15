﻿// <auto-generated />
using System;
using DataTables.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataTables.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20240716070802_os")]
    partial class os
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataTables.Models.Customer", b =>
                {
                    b.Property<int?>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address = "123 Main St",
                            City = "Anytown",
                            CompanyName = "Company A",
                            ContactName = "John Doe",
                            ContactTitle = "Manager",
                            Country = "USA",
                            Fax = "555-5678",
                            Phone = "555-1234",
                            PostalCode = "12345",
                            Region = "State A"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "456 Oak St",
                            City = "Othertown",
                            CompanyName = "Company B",
                            ContactName = "Jane Smith",
                            ContactTitle = "CEO",
                            Country = "USA",
                            Fax = "555-6789",
                            Phone = "555-2345",
                            PostalCode = "23456",
                            Region = "State B"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address = "789 Pine St",
                            City = "Sometown",
                            CompanyName = "Company C",
                            ContactName = "Jim Brown",
                            ContactTitle = "Director",
                            Country = "USA",
                            Fax = "555-7890",
                            Phone = "555-3456",
                            PostalCode = "34567",
                            Region = "State C"
                        },
                        new
                        {
                            CustomerID = 4,
                            Address = "101 Maple St",
                            City = "Anycity",
                            CompanyName = "Company D",
                            ContactName = "Sara White",
                            ContactTitle = "CFO",
                            Country = "USA",
                            Fax = "555-8901",
                            Phone = "555-4567",
                            PostalCode = "45678",
                            Region = "State D"
                        },
                        new
                        {
                            CustomerID = 5,
                            Address = "202 Elm St",
                            City = "Newtown",
                            CompanyName = "Company E",
                            ContactName = "Mike Green",
                            ContactTitle = "CTO",
                            Country = "USA",
                            Fax = "555-9012",
                            Phone = "555-5678",
                            PostalCode = "56789",
                            Region = "State E"
                        },
                        new
                        {
                            CustomerID = 6,
                            Address = "303 Birch St",
                            City = "Oldtown",
                            CompanyName = "Company F",
                            ContactName = "Lucy Blue",
                            ContactTitle = "COO",
                            Country = "USA",
                            Fax = "555-0123",
                            Phone = "555-6789",
                            PostalCode = "67890",
                            Region = "State F"
                        },
                        new
                        {
                            CustomerID = 7,
                            Address = "404 Cedar St",
                            City = "Smalltown",
                            CompanyName = "Company G",
                            ContactName = "Tom Black",
                            ContactTitle = "President",
                            Country = "USA",
                            Fax = "555-1234",
                            Phone = "555-7890",
                            PostalCode = "78901",
                            Region = "State G"
                        },
                        new
                        {
                            CustomerID = 8,
                            Address = "505 Cherry St",
                            City = "Bigcity",
                            CompanyName = "Company H",
                            ContactName = "Kate Red",
                            ContactTitle = "Vice President",
                            Country = "USA",
                            Fax = "555-2345",
                            Phone = "555-8901",
                            PostalCode = "89012",
                            Region = "State H"
                        },
                        new
                        {
                            CustomerID = 9,
                            Address = "606 Walnut St",
                            City = "Capitown",
                            CompanyName = "Company I",
                            ContactName = "Paul Yellow",
                            ContactTitle = "Executive",
                            Country = "USA",
                            Fax = "555-3456",
                            Phone = "555-9012",
                            PostalCode = "90123",
                            Region = "State I"
                        },
                        new
                        {
                            CustomerID = 10,
                            Address = "707 Hickory St",
                            City = "Hilltown",
                            CompanyName = "Company J",
                            ContactName = "Mary Purple",
                            ContactTitle = "Administrator",
                            Country = "USA",
                            Fax = "555-4567",
                            Phone = "555-0123",
                            PostalCode = "01234",
                            Region = "State J"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
