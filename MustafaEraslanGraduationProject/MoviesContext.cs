﻿using Microsoft.EntityFrameworkCore;
using MustafaEraslanGraduationProject.Entities;

namespace MustafaEraslanGraduationProject
{
    public partial class MoviesContext : DbContext
    {
        public MoviesContext()
        {
        }

        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mytable> Mytables { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mytable>(entity =>
            {
                entity.ToTable("mytable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Adult)
                    .HasMaxLength(126)
                    .HasColumnName("adult");

                entity.Property(e => e.BelongsToCollection)
                    .HasMaxLength(184)
                    .HasColumnName("belongs_to_collection");

                entity.Property(e => e.Budget)
                    .HasMaxLength(32)
                    .HasColumnName("budget");

                entity.Property(e => e.Genres)
                    .HasMaxLength(264)
                    .HasColumnName("genres");

                entity.Property(e => e.Homepage)
                    .HasMaxLength(242)
                    .HasColumnName("homepage");

                entity.Property(e => e.ImdbId)
                    .HasMaxLength(9)
                    .HasColumnName("imdb_id");

                entity.Property(e => e.OriginalLanguage)
                    .HasMaxLength(5)
                    .HasColumnName("original_language");

                entity.Property(e => e.OriginalTitle)
                    .HasMaxLength(109)
                    .HasColumnName("original_title");

                entity.Property(e => e.Overview)
                    .HasMaxLength(1000)
                    .HasColumnName("overview");

                entity.Property(e => e.Popularity)
                    .HasMaxLength(21)
                    .HasColumnName("popularity");

                entity.Property(e => e.PosterPath)
                    .HasMaxLength(35)
                    .HasColumnName("poster_path");

                entity.Property(e => e.ProductionCompanies)
                    .HasMaxLength(1252)
                    .HasColumnName("production_companies");

                entity.Property(e => e.ProductionCountries)
                    .HasMaxLength(1039)
                    .HasColumnName("production_countries");

                entity.Property(e => e.ReleaseDate)
                    .HasMaxLength(10)
                    .HasColumnName("release_date");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.Runtime)
                    .HasPrecision(6, 1)
                    .HasColumnName("runtime");

                entity.Property(e => e.SpokenLanguages)
                    .HasMaxLength(765)
                    .HasColumnName("spoken_languages");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .HasColumnName("status");

                entity.Property(e => e.Tagline)
                    .HasMaxLength(297)
                    .HasColumnName("tagline");

                entity.Property(e => e.Title)
                    .HasMaxLength(105)
                    .HasColumnName("title");

                entity.Property(e => e.Video)
                    .HasMaxLength(5)
                    .HasColumnName("video");

                entity.Property(e => e.VoteAverage)
                    .HasPrecision(4, 1)
                    .HasColumnName("vote_average");

                entity.Property(e => e.VoteCount).HasColumnName("vote_count");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<UserEntity> Users { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
