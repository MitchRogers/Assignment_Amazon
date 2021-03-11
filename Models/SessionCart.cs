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
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession Session { get; set; }
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            Cart cart = session?.GetJson<Cart>("Cart")
            ?? new Cart();
            cart.Session = session;
            return cart;
        }

        public override void AddBook(Book book, int quantity)
        {
            base.AddBook(book, quantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveBook(Book book)
        {
            base.RemoveBook(book);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
