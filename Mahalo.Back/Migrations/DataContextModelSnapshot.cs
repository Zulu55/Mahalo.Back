﻿// <auto-generated />
using System;
using Mahalo.Back.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mahalo.Back.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mahalo.Shared.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Disorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Disorders");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ResourceId");

                    b.ToTable("NotificationsHistory");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationScheduling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("SchedulingDays")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("NotificationsScheduling");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationSchedulingResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("NotificationsSchedulingId")
                        .HasColumnType("int");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SchedulingDays")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NotificationsSchedulingId");

                    b.HasIndex("ResourceId");

                    b.ToTable("NotificationsSchedulingResources");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Psychologist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("OfficeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OfficeStart")
                        .HasColumnType("datetime2");

                    b.Property<double>("TerapyPrice")
                        .HasColumnType("float");

                    b.Property<double>("XCoordinate")
                        .HasColumnType("float");

                    b.Property<double>("YCoordinate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Psychologists");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.ResourceDisorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisorderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisorderId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ResourceId");

                    b.ToTable("ResourcesDisorder");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Terapy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HourTerapy")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasMaxLength(100)
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PsychologistId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PsychologistId");

                    b.HasIndex("UserId");

                    b.ToTable("Terapies");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("NotificationHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NotificationHistoryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.City", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Disorder", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.User", null)
                        .WithMany("Disorders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationHistory", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.Resource", "Resource")
                        .WithMany("NotificationsHistory")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationScheduling", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.User", null)
                        .WithMany("NotificationsScheduling")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationSchedulingResource", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.NotificationScheduling", "NotificationsScheduling")
                        .WithMany("NotificationsSchedulingResources")
                        .HasForeignKey("NotificationsSchedulingId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mahalo.Shared.Entities.Resource", "Resource")
                        .WithMany("NotificationsSchedulingResources")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NotificationsScheduling");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Psychologist", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Resource", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.User", null)
                        .WithMany("Resources")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.ResourceDisorder", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.Disorder", "Disorder")
                        .WithMany("ResourcesDisorder")
                        .HasForeignKey("DisorderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mahalo.Shared.Entities.Resource", "Resource")
                        .WithMany("ResourcesDisorder")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Disorder");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.State", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Terapy", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.City", "City")
                        .WithMany("Terapies")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mahalo.Shared.Entities.Psychologist", "Psychologist")
                        .WithMany("Terapies")
                        .HasForeignKey("PsychologistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mahalo.Shared.Entities.User", null)
                        .WithMany("Terapies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("City");

                    b.Navigation("Psychologist");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.User", b =>
                {
                    b.HasOne("Mahalo.Shared.Entities.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mahalo.Shared.Entities.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Mahalo.Shared.Entities.NotificationHistory", null)
                        .WithMany("Users")
                        .HasForeignKey("NotificationHistoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("City");

                    b.Navigation("DocumentType");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.City", b =>
                {
                    b.Navigation("Terapies");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Disorder", b =>
                {
                    b.Navigation("ResourcesDisorder");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationHistory", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.NotificationScheduling", b =>
                {
                    b.Navigation("NotificationsSchedulingResources");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Psychologist", b =>
                {
                    b.Navigation("Terapies");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.Resource", b =>
                {
                    b.Navigation("NotificationsHistory");

                    b.Navigation("NotificationsSchedulingResources");

                    b.Navigation("ResourcesDisorder");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Mahalo.Shared.Entities.User", b =>
                {
                    b.Navigation("Disorders");

                    b.Navigation("NotificationsScheduling");

                    b.Navigation("Resources");

                    b.Navigation("Terapies");
                });
#pragma warning restore 612, 618
        }
    }
}
