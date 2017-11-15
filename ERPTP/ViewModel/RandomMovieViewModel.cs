using ERPTP.Models;
using System.Collections.Generic;

namespace ERPTP.ViewModel
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
    }
}