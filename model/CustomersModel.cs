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
        [DisplayName("Customers Id")]
        public int Id { get; set; }

        [DisplayName("Customers Firt_Name")]
        [Required(ErrorMessage = "Product  firt_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string First_name { get; set; }

        [DisplayName("Customers Last_Name")]
        [Required(ErrorMessage = "Product  last_name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Last_name { get; set; }

        [DisplayName("Customers Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Doc_num { get; set; }

        [DisplayName("Customers Address")]
        [Required(ErrorMessage = "Product  address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Address { get; set; }

        [DisplayName("Customers Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Birtday { get; set; }

        [DisplayName("Customers Phone")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Phone { get; set; }

        [DisplayName("Customers Email")]
        [Required(ErrorMessage = "Product  Email is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product  name the must  be between 3 and 50  characters ")]
        public string Email { get; set; }
    }
}
