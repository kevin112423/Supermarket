using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.view
{
    internal interface IProductView
    {
            public string ProductId { get; set; }
            public string ProductName { get; set; }

            public string ProductPrice { get; set; }

            public string ProductStock { get; set; }



            string SearchValue { get; set; }
            bool IsEdit { get; set; }
            bool IsSuccessful { get; set; }
            string Message { get; set; }

            event EventHandler SearchEvent;
            event EventHandler AddNewEvent;
            event EventHandler DeleteEvent;
            event EventHandler SaveEvent;
            event EventHandler CancelEvent;
            event EventHandler EditEvent;

            void SetProductListBildingSource(BindingSource ProductList);

            void Show();
    }
}
