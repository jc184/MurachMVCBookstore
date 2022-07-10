using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MurachMVCBookstore.Models.DomainModels
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Author's first name is required.")]
        [StringLength(200)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Author's last name is required.")]
        [StringLength(200)]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
