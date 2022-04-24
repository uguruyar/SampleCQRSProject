﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleCQRS.Models;

#nullable disable

namespace SampleCQRS.Migrations
{
    [DbContext(typeof(SampleCQRSContext))]
    [Migration("20220424190213_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SampleCQRS.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "The Rise of Skywalker",
                            Title = "Episode 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Attack of the Clones",
                            Title = "Episode 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Revenge of the Sith",
                            Title = "Episode 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "A New Hope",
                            Title = "Episode 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "The Empire Strikes Back",
                            Title = "Episode 5"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Revenge of the Sith",
                            Title = "Episode 6"
                        },
                        new
                        {
                            Id = 7,
                            Content = "The Force Awakens",
                            Title = "Episode 7"
                        },
                        new
                        {
                            Id = 8,
                            Content = "The Last Jedi",
                            Title = "Episode 8"
                        },
                        new
                        {
                            Id = 9,
                            Content = "The Rise of Skywalker",
                            Title = "Episode 9"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
