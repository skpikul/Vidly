using System;

namespace ERPTP.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberOfStock { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }
}