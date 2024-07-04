﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fiap_5nett_tech.api.Data;

#nullable disable

namespace fiap_5nett_tech.api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240704012108_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ddd1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("Ddd1");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Region", b =>
                {
                    b.Property<int>("Ddd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ddd"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR");

                    b.HasKey("Ddd");

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Contact", b =>
                {
                    b.HasOne("fiap_5nett_tech.Domain.Entities.Region", "Ddd")
                        .WithMany()
                        .HasForeignKey("Ddd1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ddd");
                });
#pragma warning restore 612, 618
        }
    }
}
