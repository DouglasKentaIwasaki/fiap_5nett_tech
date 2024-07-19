﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fiap_5nett_tech.Infrastructure.Data;

#nullable disable

namespace fiap_5nett_tech.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DDD")
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

                    b.HasIndex("DDD");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Region", b =>
                {
                    b.Property<int>("Ddd")
                        .HasColumnType("int");

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
                        .WithMany("Contacts")
                        .HasForeignKey("DDD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CONTACT_REGION");

                    b.Navigation("Ddd");
                });

            modelBuilder.Entity("fiap_5nett_tech.Domain.Entities.Region", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
