using Ado.net_exam.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net_exam
{
    public partial class MusicContext:DbContext
    {
        public MusicContext()
        {

        }
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }
        public virtual DbSet<Genre> genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Album_song> AlbumsSongs { get; set; }
        public virtual DbSet<Songs> songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NB24L70;Initial Catalog=music;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {


                entity.HasKey(e => e.album_id);

                entity.Property(e => e.album_id)
                    .HasColumnName("album_id");

                entity.Property(e => e.artist_id)
                    .HasColumnName("artist_id");

                entity.Property(e => e.album_year)
                    .HasColumnName("album_year");



                entity.HasOne(d => d.IdArtistNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.artist_id);
            });
            modelBuilder.Entity<Album_song>(entity =>
            {
                entity.HasKey(e => new { e.album_id, e.song_id });

                entity.Property(e => e.album_id)
                    .HasColumnName("AlbumId");

                entity.Property(e => e.song_id)
                    .HasColumnName("Song_id");



                entity.HasOne(d => d.IdAlbumNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.album_id);

                entity.HasOne(d => d.IdSongNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.song_id);
            });
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.artist_id);

                entity.Property(e => e.artist_id)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.genre_id)
                    .HasColumnName("GenreId");

                entity.Property(e => e.country_id)
                    .HasColumnName("CountryId");

                entity.Property(e => e.Artist_Site_URL)
                    .IsUnicode(false)
                    .HasColumnName("Artist_Site_URL");

                entity.HasOne(d => d.IdGenreNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.genre_id);

                entity.HasOne(d => d.IdCountryNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.country_id);
            });
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.country_id);

                entity.Property(e => e.country_id)
                    .HasColumnName("Country_id");

                entity.Property(e => e.country_name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CountryName");

            });
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.genre_id);

                entity.Property(e => e.genre_id)
                    .HasColumnName("GenreId");

                entity.Property(e => e.genre_name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GenreName");
            });
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.artist_id);

                entity.Property(e => e.artist_id)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.group_name)
                    .HasColumnName("GroupName");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.artist_id);
            });
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.artist_id);

                entity.Property(e => e.artist_id)
                    .HasColumnName("ArtistId");

                entity.Property(e => e.first_name)
                    .HasColumnName("First_name");

                entity.Property(e => e.last_name)
                    .HasColumnName("Last_name");

                entity.Property(e => e.birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Birthday");

                entity.Property(e => e.sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sex");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.artist_id);
            });
            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasKey(e => e.song_id);

                entity.Property(e => e.song_id)
                    .HasColumnName("Song_id");

                entity.Property(e => e.song_title)
                    .HasColumnName("Song_Title");

                entity.Property(e => e.song_duration)
                    .HasColumnName("Song_Duration");

            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
