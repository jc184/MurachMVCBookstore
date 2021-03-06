using MurachMVCBookstore.Models.DomainModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MurachMVCBookstore.Areas.Admin.Models
{
    public class SearchViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        [Required(ErrorMessage = "Please enter a search term.")]
        public string SearchTerm { get; set; }

        public string Type { get; set; }
        public string Header { get; set; }
    }
}
