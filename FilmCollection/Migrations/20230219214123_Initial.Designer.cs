﻿// <auto-generated />
using FilmCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmCollection.Migrations
{
    [DbContext(typeof(FilmCollectionContext))]
    [Migration("20230219214123_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("FilmCollection.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FilmCollection.Models.MoviesResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "Connor",
                            Notes = "good movie",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Chris Miller",
                            Edited = true,
                            LentTo = "Hannah",
                            Notes = "great movie",
                            Rating = "PG",
                            Title = "Puss 'n Boots",
                            Year = 2022
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Joseph Kosinski",
                            Edited = false,
                            LentTo = "Cooper",
                            Notes = "fav",
                            Rating = "PG-13",
                            Title = "Top Gun: Maverick",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("FilmCollection.Models.MoviesResponse", b =>
                {
                    b.HasOne("FilmCollection.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
