using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MurachMVCBookstore.Models.DomainModels
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; }

        [Range(0.0, 1000000.0, ErrorMessage = "Price must be between 0.0 and 1000000.0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string GenreId { get; set; }

        public Genre Genre { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
