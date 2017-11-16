using System;
using System.ComponentModel.DataAnnotations;

namespace ERPTP.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

        [Required]
        [Display(Name = "Number Of Stock")]
        [Range(1, 20, ErrorMessage = "The field Number of Stock must be 1 to 20,")]
        public int NumberOfStock { get; set; }
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}