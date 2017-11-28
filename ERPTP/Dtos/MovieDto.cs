using System;
using System.ComponentModel.DataAnnotations;

namespace ERPTP.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public DateTime? AddedDate { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The field Number of Stock must be 1 to 20,")]
        public int? NumberOfStock { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}