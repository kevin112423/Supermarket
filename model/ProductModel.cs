using System;
using System.Collections.Generic;
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
        [Required(ErrorMessage ="Product  name is required")]
        [StringLength(50, MinimumLength = 3 , ErrorMessage ="Product  name the must  be between 3 and 50  characters ")]
        public string Name { get; set; }

        [DisplayName("Product Firt_Name")]
        [Required(ErrorMessage = "Product  firt_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Firt_name { get; set; }

        [DisplayName("Product Last_Name")]
        [Required(ErrorMessage = "Product  last_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Last_name { get; set; }

        [DisplayName("Product Address")]
        [Required(ErrorMessage = "Product  address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Address { get; set; }

        [DisplayName("Product Phone")]
        public int Phone { get; set; }

        [DisplayName("Product Email")]
        [Required(ErrorMessage = "Product  Email is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public double Email { get; set; }
    }
}
