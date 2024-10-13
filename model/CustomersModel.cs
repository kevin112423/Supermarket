using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.model
{
    internal class CustomersModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Firt_Name")]
        [Required(ErrorMessage = "Product  firt_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Firt_name { get; set; }

        [DisplayName("Product Last_Name")]
        [Required(ErrorMessage = "Product  last_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Last_name { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Document { get; set; }

        [DisplayName("Product Address")]
        [Required(ErrorMessage = "Product  address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Address { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Bithrday { get; set; }

        [DisplayName("Product Phone")]
        public string Phone { get; set; }

        [DisplayName("Product Email")]
        [Required(ErrorMessage = "Product  Email is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Email { get; set; }
    }
}
