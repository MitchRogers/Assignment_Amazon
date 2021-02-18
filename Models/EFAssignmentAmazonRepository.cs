using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public class EFAssignmentAmazonRepository : AssignmentAmazonRepository
    {
        private AssignmentAmazonDBContext _context;

        //constructor
        public EFAssignmentAmazonRepository (AssignmentAmazonDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> books => _context.books;
    }
}
