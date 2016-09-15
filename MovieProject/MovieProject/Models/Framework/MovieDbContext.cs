namespace MovieProject.Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDbContext : DbContext
    {
        public MovieDbContext()
            : base("name=MovieDbContext")
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Cinemas> Cinemas { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Movie_Ratings> Movie_Ratings { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Seats> Seats { get; set; }
        public virtual DbSet<Showing_Schedule> Showing_Schedule { get; set; }
        public virtual DbSet<Showings> Showings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>()
                .Property(e => e.Admin_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Admins>()
                .Property(e => e.Admin_Password)
                .IsUnicode(false);

            modelBuilder.Entity<Cinemas>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.Cinemas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cinemas>()
                .HasMany(e => e.Showings)
                .WithRequired(e => e.Cinemas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Customer_Password)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Customer_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Customer_Avatar)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Movie_Ratings)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Movie_Time)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Movie_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Movie_Trailer)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Movie_Picture)
                .IsFixedLength();

            modelBuilder.Entity<Movies>()
                .HasMany(e => e.Movie_Ratings)
                .WithRequired(e => e.Movies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movies>()
                .HasMany(e => e.Showings)
                .WithRequired(e => e.Movies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<News>()
                .Property(e => e.News_Content)
                .IsUnicode(false);

            modelBuilder.Entity<Seats>()
                .Property(e => e.Row_Number)
                .IsFixedLength();

            modelBuilder.Entity<Seats>()
                .Property(e => e.Seat_Type)
                .IsFixedLength();

            modelBuilder.Entity<Showings>()
                .Property(e => e.Showing_Type)
                .IsFixedLength();

            modelBuilder.Entity<Showings>()
                .HasMany(e => e.Showing_Schedule)
                .WithRequired(e => e.Showings)
                .WillCascadeOnDelete(false);
        }
    }
}
