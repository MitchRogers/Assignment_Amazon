using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public interface AssignmentAmazonRepository
    {
        IQueryable<Book> books { get; }
    }
}
