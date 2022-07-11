using MurachMVCBookstore.Models.DomainModels;

namespace MurachMVCBookstore.Models.DataLayer.Repositories
{
    public interface IBookstoreUnitOfWork
    {
        IRepository<Book> Books { get; }
        IRepository<Author> Authors { get; }
        IRepository<BookAuthor> BookAuthors { get; }
        IRepository<Genre> Genres { get; }

        void DeleteCurrentBookAuthors(Book book);
        void AddNewBookAuthors(Book book, int[] authorids);
        void Save();
    }
}
