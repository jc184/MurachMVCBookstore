using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MurachMVCBookstore.Models.DomainModels
{
    public class Genre
    {
        [StringLength(10)]
        [Required(ErrorMessage = "GenreId is required")]
        [Remote("CheckGenre", "Validation", "Admin")] // include 'Admin' area name
        public string GenreId { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Genre name is required")]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}