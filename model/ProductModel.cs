using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Supermarket_mvp.model
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product  firt_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        public decimal Price { get; set; }
        [DisplayName("Product Stock")]
        public int  Stock{ get; set; }


    }
}
