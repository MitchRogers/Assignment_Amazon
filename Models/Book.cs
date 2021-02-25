using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    //Book object to store book info -- PK auto set to bookId
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        // regex to validate the correct isbn format
        [Required(ErrorMessage = "You must enter a valid ISBN number. XXX-XXXXXXXXXX")]
        [RegularExpression(@"([0-9]{3})[-]([0-9]{10}$")]
        public string Isbn { get; set; }
        [Required]
        public string Category1 { get; set; }
        public string? Category2 { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int NumPages { get; set; }
    }
}
