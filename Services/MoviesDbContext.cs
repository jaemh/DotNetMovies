using Microsoft.EntityFrameworkCore;
using Movies.Model;


namespace Movies.Services
{

    public class MoviesDbContext : DbContext
    {
        //Objects from Model classes is mapped to a tables.
        public DbSet<MovieDetails> MovieDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<BookingTable> BookingTables { get; set; }

        public MoviesDbContext(
            DbContextOptions<MoviesDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}