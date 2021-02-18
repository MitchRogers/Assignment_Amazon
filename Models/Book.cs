using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Amazon.Models
{
    public class Book
    {
        [Key]        
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string publisher { get; set; }
        [Required]
        public string isbn { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public float price { get; set; }
    }
}
