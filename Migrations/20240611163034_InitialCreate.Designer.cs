﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentMarks.Data;

#nullable disable

namespace StudentMarks.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240611163034_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StudentMarks.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Chemistry")
                        .HasColumnType("int");

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Hindi")
                        .HasColumnType("int");

                    b.Property<int>("Maths")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Physics")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentMarks");
                });
#pragma warning restore 612, 618
        }
    }
}
