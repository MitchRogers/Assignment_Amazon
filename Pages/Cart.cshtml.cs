using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_Amazon.Infrastructure;
using Assignment_Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_Amazon.Pages
{
    public class CartModel : PageModel
    {
        private AssignmentAmazonRepository repository;
        public CartModel(AssignmentAmazonRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnurl)
        {
            Book book = repository.books.FirstOrDefault(b => b.BookId == bookId);

            // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddBook(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { ReturnUrl = returnurl });
        }

        public IActionResult OnRemoveBook(long bookId, string returnUrl)
        {
            Cart.RemoveBook(Cart.Lines.First(b => b.Book.BookId == bookId).Book);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
