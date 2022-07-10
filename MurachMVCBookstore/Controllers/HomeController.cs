using Microsoft.AspNetCore.Mvc;
using MurachMVCBookstore.Models;
using MurachMVCBookstore.Models.DataLayer;
using MurachMVCBookstore.Models.DataLayer.Repositories;
using MurachMVCBookstore.Models.DomainModels;
using System;

namespace MurachMVCBookstore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }
        public HomeController(BookstoreContext ctx) => data = new Repository<Book>(ctx);

        public ViewResult Index()
        {
            // get a book at random
            var random = data.Get(new QueryOptions<Book>
            {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }

        public ContentResult Register()
        {
            return Content("Registration has not been implemented yet. It is implemented in chapter 16.");
        }

    }
}
