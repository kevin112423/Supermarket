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

            LoadAllCustomersList();

            this.view.Show();
            
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            CustomersList = repository.GetAll();
            CustomersBindingSource.DataSource = CustomersList;
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
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersFirst_name = "";
            view.CustomersLast_name = "";
            view.CustomersDocument = "";
            view.CustomersAddress = "";
            view.CustomersPhone = "";
            view.CustomersBithrday = "";
            view.CustomersEmail = "";
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            var customersModel = new CustomersModel();
            customersModel.Id = Convert.ToInt32(view.CustomersId);
            customersModel.First_name = view.CustomersFirst_name;
            customersModel.Last_name = view.CustomersLast_name;
            customersModel.Doc_num= view.CustomersDocument;
            customersModel.Address = view.CustomersAddress;
            customersModel.Birtday = view.CustomersBithrday;
            customersModel.Phone = view.CustomersPhone;
            customersModel.Email = view.CustomersEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customersModel);
                if (view.IsEdit)
                {
                    repository.Edit(customersModel);
                    view.Message = "PayMode edited succefuly";
                }
                else
                {
                    repository.Add(customersModel);
                    view.Message = "PayMode added succefuly";
                }
                view.IsSuccessful = true;
                LoadAllCustomersList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void LoadAllCustomersList()
        {
            CustomersList = repository.GetAll();
            CustomersBindingSource.DataSource = CustomersList;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
