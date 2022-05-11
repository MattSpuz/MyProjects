﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempManager.Models;

namespace Ch11Ex1TempManager.Migrations
{
    [DbContext(typeof(TempManagerContext))]
    partial class TempManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview1.19506.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TempManager.Models.Temp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("High")
                        .HasColumnType("float");

                    b.Property<double?>("Low")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Temps");
                });
#pragma warning restore 612, 618
        }
    }
}
