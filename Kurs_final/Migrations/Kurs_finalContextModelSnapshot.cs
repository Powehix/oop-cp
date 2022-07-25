﻿// <auto-generated />
using System;
using Kurs_final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kurs_final.Migrations
{
    [DbContext(typeof(Kurs_finalContext))]
    partial class Kurs_finalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kurs_final.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Specialty")
                        .IsRequired();

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Kurs_final.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Chamber")
                        .IsRequired();

                    b.Property<string>("Doctor");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Status");

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}