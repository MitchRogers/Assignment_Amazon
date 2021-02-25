using Assignment_Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment_Amazon.Models.ViewModels;

namespace Assignment_Amazon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AssignmentAmazonRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, AssignmentAmazonRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            // pass the repos books to the view to display
            return View(new BookListViewModel
            {
                Books = _repository.books
                    .OrderBy(b => b.BookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                , PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    BooksPerPage = PageSize,
                    TotalNumBooks = _repository.books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
