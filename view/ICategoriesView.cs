using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.view
{
    internal interface ICategoriesView
    {
        int CategoriesId { get; set; }
        string CategoriesName { get; set; }
        string CategoriesDescription { get; set; }

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

        void SetProductListBildingSource(BindingSource CategoriesList);

        void Show();
    }
}
