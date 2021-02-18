using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public class AssignmentAmazonDBContext : DbContext
    {
        public AssignmentAmazonDBContext (DbContextOptions<AssignmentAmazonDBContext> options) : base (options)
        {

        }
        public DbSet<Book> books { get; set; }
    }
}
