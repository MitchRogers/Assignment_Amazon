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
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string publisher { get; set; }
        // regex to validate the correct isbn format
        [Required(ErrorMessage = "You must enter a valid ISBN number. XXX-XXXXXXXXXX")]
        [RegularExpression(@"([0-9]{3})[-]([0-9]{10}$")]
        public string isbn { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public float price { get; set; }
    }
}
