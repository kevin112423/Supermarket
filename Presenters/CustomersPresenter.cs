using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.model;
using Supermarket_mvp.view;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource CustomersBindingSource;
        private IEnumerable<CustomersModel> CustomersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.CustomersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.AddNewEvent += AddNewCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.CancelEvent += CancelCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.SearchEvent += SearchCustomers;

            this.view.SetCustomersListBildingSource(CustomersBindingSource);

            
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                CustomersList = repository.GetByValue(this.view.SearchValue);
            }
            CustomersBindingSource.DataSource = CustomersList;
        }

        private void CancelCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
