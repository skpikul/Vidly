using System;
using System.ComponentModel.DataAnnotations;

namespace ERPTP.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Number Of Stock")]
        public int NumberOfStock { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }
}