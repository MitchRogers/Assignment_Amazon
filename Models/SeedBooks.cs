using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public class SeedBooks
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            AssignmentAmazonDBContext context = application.ApplicationServices.
            CreateScope().ServiceProvider.GetRequiredService<AssignmentAmazonDBContext>();

            // if there is pending info/migrations for db
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            // if there are no books in the db 
            if (!context.books.Any())
            {
                context.books.AddRange(

                    // add new books from prof Hilton's list
                    // bookId will be auto generated
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        Isbn = "978-0451419439",
                        Category1 = "Fiction",
                        Category2 = "Classic",
                        Price = 9.95F,
                        NumPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-0743270755",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 14.58F,
                        NumPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        Isbn = "978-0553384611",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 21.54F,
                        NumPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        Isbn = "978-0812981254",
                        Category1 = "Non-Fiction",
                        Category2 = "Biography",
                        Price = 11.61F,
                        NumPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        Isbn = "978-0812974492",
                        Category1 = "Non-Fiction",
                        Category2 = "Historical",
                        Price = 13.33F,
                        NumPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        Isbn = "978-0804171281",
                        Category1 = "Fiction",
                        Category2 = "Historical-Fiction",
                        Price = 15.95F,
                        NumPages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455586691",
                        Category1 = "Non-Fiction",
                        Category2 = "Self-Help",
                        Price = 14.99F,
                        NumPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455523023",
                        Category1 = "Non-Fiction",
                        Category2 = "Self-Help",
                        Price = 21.66F,
                        NumPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        Isbn = "978-1591847984",
                        Category1 = "Non-Fiction",
                        Category2 = "Business",
                        Price = 29.16F,
                        NumPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        Isbn = "978-0553393613",
                        Category1 = "Fiction",
                        Category2 = "Thrillers", 
                        Price = 15.03F,
                        NumPages = 642
                    },

                    new Book
                    {
                        Title = "Shoe Dog",
                        AuthorFirst = "Phil",
                        AuthorLast = "Knight",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-1508211808",
                        Category1 = "Non-Fiction",
                        Category2 = "Sports",
                        Price = 10.89F,
                        NumPages = 422
                    },

                    new Book
                    {
                        Title = "The Millionaire Next Door",
                        AuthorFirst = "Thomas J.",
                        AuthorLast = "Stanley",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-0743517843",
                        Category1 = "Financial",
                        Category2 = "Self-Help",
                        Price = 8.89F,
                        NumPages = 272
                    },

                    new Book
                    {
                        Title = "Principles",
                        AuthorFirst = "Ray",
                        AuthorLast = "Dalio",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-1508243243",
                        Category1 = "Financial Investing",
                        Category2 = "Business",
                        Price = 15.03F,
                        NumPages = 642
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
