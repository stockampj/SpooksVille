﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpookyPark.Models;

namespace SpookyPark.Migrations
{
    [DbContext(typeof(SpookyParkContext))]
    [Migration("20191017160032_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SpookyPark.Models.Attraction", b =>
                {
                    b.Property<int>("AttractionId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("DeathCount");

                    b.Property<string>("Desc");

                    b.Property<int>("EntertainmentTypeId");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("AttractionId");

                    b.HasIndex("EntertainmentTypeId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("SpookyPark.Models.EntertainmentType", b =>
                {
                    b.Property<int>("EntertainmentTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AgeRestriction");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("EntertainmentTypeId");

                    b.ToTable("EntertainmentTypes");
                });

            modelBuilder.Entity("SpookyPark.Models.Attraction", b =>
                {
                    b.HasOne("SpookyPark.Models.EntertainmentType", "EntertainmentType")
                        .WithMany("Attractions")
                        .HasForeignKey("EntertainmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}