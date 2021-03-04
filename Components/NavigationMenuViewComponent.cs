using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment_Amazon.Models;

namespace Assignment_Amazon.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private AssignmentAmazonRepository repository;
        public NavigationMenuViewComponent(AssignmentAmazonRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.books
                .Select(b => b.Category1)
                .Distinct()
                .OrderBy(b => b));
        }
    }
}
