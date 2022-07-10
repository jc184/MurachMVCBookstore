using Microsoft.EntityFrameworkCore;
using MurachMVCBookstore.Models.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace MurachMVCBookstore.Models.DataLayer
{
    public class Data
    {
        private BookstoreContext context { get; set; }
        public Data(BookstoreContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Book> GetBooks(QueryOptions<Book> options)
        {
            IQueryable<Book> query = context.Books;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
                query = query.Where(options.Where);
            if (options.HasOrderBy)
                query = query.OrderBy(options.OrderBy);
            if (options.HasPaging)
                query = query.PageBy(options.PageNumber, options.PageSize);
            return query.ToList();
        }
    }
}
