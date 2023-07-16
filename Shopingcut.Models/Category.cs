using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopingcut.Models
{
    public class Category
    {

        [Key]

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [DisplayName("DisplayOrder")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
