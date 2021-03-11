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

        public IActionResult Index(string category, int pageNum = 1)
        {
            // pass the repos books to the view to display
            return View(new BookListViewModel
            {
                Books = _repository.books
                    .Where(b => category == null || (b.Category1 == category || b.Category2 == category))
                    .OrderBy(b => b.BookId)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize)
                ,
                // 
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    BooksPerPage = PageSize,
                    TotalNumBooks = category == null ? _repository.books.Count() : _repository.books.Where(b => b.Category1 == category).Count()
                },
                CurrentCategory = category
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
