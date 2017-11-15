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
            var genre = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genre
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}