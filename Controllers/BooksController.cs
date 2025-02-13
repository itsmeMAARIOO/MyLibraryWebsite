using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MyLibraryWebsite.BAL.Services;
using MyLibraryWebsite.DAL.Models;
using MyLibraryWebsite.Views.ViewModels;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace MyLibraryWebsite.Controllers;

public class BooksController(BookService _bookService):Controller
{
    [Route("books")]
    public async Task<IActionResult> Display()
    {
        List<Book> books = await _bookService.DisplayBook();
        List<BookViewModel> allBooks = [];
        foreach (var book in books)
        {
            var viewModel = new BookViewModel 
            {
                Name = book.Name,
                Author = book.Author,
                Quantity = book.Quantity,
                IsBorrowed = book.IsBorrowed
            };
            allBooks.Add(viewModel);
        }

        return View("~/Views/Books/Index.cshtml", allBooks);
    }
}
