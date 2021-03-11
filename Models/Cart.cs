using Assignment_Amazon.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public ISession Session { get; internal set; }

        public virtual void AddBook(Book book, int quantity)
        {
            CartLine line = Lines
                            .Where(b => b.Book.BookId == book.BookId)
                            .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveBook(Book book) =>
            Lines.RemoveAll(b => b.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeCartBalance() => 
            (decimal)Lines.Sum(s => s.Book.Price * s.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
