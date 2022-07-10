using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MiniProject.Models
{
    public class Products
    {
        [Key]
        public int productID { get; set; }
        [Required(ErrorMessage ="Please Enter A Product Name ")]
        public string productName { get; set; }
        public decimal price { get; set; }
        public string brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        

    }
}
