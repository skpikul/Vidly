using ERPTP.Models;
using ERPTP.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ERPTP.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = _context.Movies.Include(c=>c.Genre).ToList();
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            return View(movie);
        }

        public ActionResult Save()
        {
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel()
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
                return View(viewModel);
            }
                
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var moviesInDb = _context.Movies.Single(m => m.Id == movie.Id);
                moviesInDb.Name = movie.Name;
                moviesInDb.AddedDate = movie.AddedDate;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.NumberOfStock = movie.NumberOfStock;
                moviesInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();
            var movieList = _context.Movies.Include(c => c.Genre).ToList();
            return View("Random", movieList);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("Save", viewModel);
        }
    }
}