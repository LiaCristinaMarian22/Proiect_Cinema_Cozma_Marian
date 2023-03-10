// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Cinema_Cozma_Marian.Data;

#nullable disable

namespace Proiect_Cinema_Cozma_Marian.Migrations
{
    [DbContext(typeof(Proiect_Cinema_Cozma_MarianContext))]
    [Migration("20230210153631_MovieGenre")]
    partial class MovieGenre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Actor1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actor2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.MovieGenre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.HasIndex("MovieID");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.Genre", b =>
                {
                    b.HasOne("Proiect_Cinema_Cozma_Marian.Models.Genre", null)
                        .WithMany("Genres")
                        .HasForeignKey("GenreID");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.MovieGenre", b =>
                {
                    b.HasOne("Proiect_Cinema_Cozma_Marian.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_Cinema_Cozma_Marian.Models.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.Genre", b =>
                {
                    b.Navigation("Genres");
                });

            modelBuilder.Entity("Proiect_Cinema_Cozma_Marian.Models.Movie", b =>
                {
                    b.Navigation("MovieGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
