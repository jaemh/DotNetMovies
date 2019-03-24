using Microsoft.AspNetCore.Mvc;
using Movies.Services;

namespace Movies.Controllers
{

    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private MoviesDbContext _context;

        public MoviesController(MoviesDbContext context)
        {
            _context = context;
        }

        public IActionResult GetMovies()
        {
            return Ok(_context.MovieDetails);
        }
    }
}