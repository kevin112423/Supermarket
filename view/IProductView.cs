using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.view
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductObservation { get; set; }
        string ProductFirt_name { get; set; }
        string ProductLast_name { get; set; }
        string ProductAddress { get; set; }
        int ProductPhone { get; set; }
        double ProductEmail { get; set; }

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

        void SetPayModeListBildingSource(BindingSource PayModeList);

        void Show();
    }
}
