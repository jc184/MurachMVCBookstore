using MurachMVCBookstore.Models.DomainModels;

namespace MurachMVCBookstore.Models.DataLayer.Repositories
{
    public interface IBookstoreUnitOfWork
    {
        Repository<Book> Books { get; }
        Repository<Author> Authors { get; }
        Repository<BookAuthor> BookAuthors { get; }
        Repository<Genre> Genres { get; }

        void DeleteCurrentBookAuthors(Book book);
        void AddNewBookAuthors(Book book, int[] authorids);
        void Save();
    }
}
