using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopingcut.Models
{
    public class Product
    {

        [Key]

        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public double price { get; set; }
        [ValidateNaver]
        public String ImageUrl { get; set; }
      
        public int CategoryId { get; set; }
        [ValidateNaver]
        public Category Category { get; set; }


    }
}
