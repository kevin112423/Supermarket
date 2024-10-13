using Supermarket_mvp.model;
using Supermarket_mvp.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource ProductBindingSource;
        private IEnumerable<ProductModel> ProductList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.ProductBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.AddNewEvent += AddNewCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.CancelEvent += CancelCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.SearchEvent += SearchCustomers;

            this.view.SetProductListBildingSource(ProductBindingSource);

            LoadAllCustomersList();

            this.view.Show();
        }

        private void LoadAllCustomersList()
        {
            ProductList = repository.GetAll();
            ProductBindingSource.DataSource = ProductList;
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
                ProductList = repository.GetByValue(this.view.SearchValue);
            }
            ProductBindingSource.DataSource = ProductList;
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelCustomers(object? sender, EventArgs e)
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
