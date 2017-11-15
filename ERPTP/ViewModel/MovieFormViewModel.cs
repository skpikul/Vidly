using ERPTP.Models;
using System.Collections.Generic;

namespace ERPTP.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}