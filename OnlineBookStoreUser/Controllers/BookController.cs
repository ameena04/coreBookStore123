using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreUser.Models;

namespace OnlineBookStoreUser.Controllers
{
    public class BookController : Controller
    {
        Book_Store_DbContext context = new Book_Store_DbContext();
        public IActionResult PublicationIndex()
        {
            var publicationList = context.Books.ToList();
            return View(publicationList);
        }
    }
}