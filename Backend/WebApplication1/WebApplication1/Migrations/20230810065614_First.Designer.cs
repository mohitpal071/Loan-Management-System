﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Model;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230810065614_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Model.Employee", b =>
                {
                    b.Property<string>("employee_id")
                        .HasColumnType("varchar(6)");

                    b.Property<DateTime>("date_of_birth")
                        .HasColumnType("Date");

                    b.Property<DateTime>("date_of_joining")
                        .HasColumnType("datetime2");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("employee_name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.HasKey("employee_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApplication1.Model.Employee_Issue_Detail", b =>
                {
                    b.Property<string>("issue_id")
                        .HasColumnType("varchar(6)");

                    b.Property<string>("employee_id")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<DateTime>("issue_date")
                        .HasColumnType("Date");

                    b.Property<string>("item_id")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<DateTime>("return_date")
                        .HasColumnType("Date");

                    b.HasKey("issue_id");

                    b.HasIndex("employee_id");

                    b.HasIndex("item_id");

                    b.ToTable("Employee_Issue_Details");
                });

            modelBuilder.Entity("WebApplication1.Model.Item", b =>
                {
                    b.Property<string>("item_id")
                        .HasColumnType("varchar(6)");

                    b.Property<string>("item_category")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("item_description")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("item_make")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("item_status")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<int>("item_valuation")
                        .HasColumnType("int");

                    b.HasKey("item_id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WebApplication1.Model.Employee_Issue_Detail", b =>
                {
                    b.HasOne("WebApplication1.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("item_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}