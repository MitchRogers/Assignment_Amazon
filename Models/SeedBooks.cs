﻿using Microsoft.AspNetCore.Builder;
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

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.books.Any())
            {
                context.books.AddRange(

                    new Book
                    {
                        title = "Les Miserables",
                        author = "Victor Hugo",
                        publisher = "Signet",
                        isbn = "978-0451419439",
                        category = "Fiction, Classic",
                        price = 9.95F
                    },

                    new Book
                    {
                        title = "Team of Rivals",
                        author = "Doris Kearns Goodwin",
                        publisher = "Simon & Schuster",
                        isbn = "978-0743270755",
                        category = "Non-Fiction, Biography",
                        price = 14.58F
                    },

                    new Book
                    {
                        title = "The Snowball",
                        author = "Alice Schroeder",
                        publisher = "Bantam",
                        isbn = "978-0553384611",
                        category = "Non-Fiction, Biography",
                        price = 21.54F
                    },

                    new Book
                    {
                        title = "American Ulysses",
                        author = "Ronald C. White",
                        publisher = "Random House",
                        isbn = "978-0812981254",
                        category = "Non-Fiction, Biography",
                        price = 11.61F
                    },

                    new Book
                    {
                        title = "Unbroken",
                        author = "Laura Hillenbrand",
                        publisher = "Random House",
                        isbn = "978-0812974492",
                        category = "Non-Fiction, Historical",
                        price = 13.33F
                    },

                    new Book
                    {
                        title = "The Great Train Robbery",
                        author = "Michael Crichton",
                        publisher = "Vintage",
                        isbn = "978-0804171281",
                        category = "Fiction, Historical-Fiction",
                        price = 15.95F
                    },

                    new Book
                    {
                        title = "Deep Work",
                        author = "Cal Newport",
                        publisher = "Grand Central Publishing",
                        isbn = "978-1455586691",
                        category = "Non-Fiction, Self-Help",
                        price = 14.99F
                    },

                    new Book
                    {
                        title = "It's Your Ship",
                        author = "Michael Abrashoff",
                        publisher = "Grand Central Publishing",
                        isbn = "978-1455523023",
                        category = "Non-Fiction, Self-Help",
                        price = 21.66F
                    },

                    new Book
                    {
                        title = "The Virgin Way",
                        author = "Richard Branson",
                        publisher = "Portfolio",
                        isbn = "978-1591847984",
                        category = "Non-Fiction, Business",
                        price = 29.16F
                    },

                    new Book
                    {
                        title = "Sycamore Row",
                        author = "John Grisham",
                        publisher = "Bantam",
                        isbn = "978-0553393613",
                        category = "Fiction, Thrillers",
                        price = 15.03F
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
