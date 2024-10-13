using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.view
{
    internal interface ICustomersView
    {
        string CustomersId { get; set; }
        string CustomersFirst_name { get; set; }
        string CustomersLast_name { get; set; }
        string CustomersDocument { get; set; }
        string CustomersAddress { get; set; }
        string CustomersBithrday{ get; set; }
        string CustomersPhone { get; set; }
        string CustomersEmail { get; set; }

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

        void SetCustomersListBildingSource(BindingSource CustomersList);

        void Show();
    }
}
