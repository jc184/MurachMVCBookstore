using MurachMVCBookstore.Models.DomainModels;
using MurachMVCBookstore.Models.Grid;
using System.Collections.Generic;

namespace MurachMVCBookstore.Models.ViewModels
{
    public class AuthorListViewModel
    {
        public IEnumerable<Author> Authors { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
    }
}
