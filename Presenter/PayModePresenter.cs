using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.view;
using Supermarket_mvp.model;

namespace Supermarket_mvp.Presenter
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource PayModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.PayModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.AddNewEvent += AddNewPayMode;
            this.view.SaveEvent += SavePaymode;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.CancelEvent += CancelPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.SearchEvent += SearchPayMode;

            this.view.SetPayModeListBildingSource(PayModeBindingSource);

            LoadAllPayModeList();
            this.view.Show();
        }

        private void LoadAllPayModeList()
        {
            payModeList = repository.GetAll();
            PayModeBindingSource.DataSource = payModeList;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            PayModeBindingSource.DataSource = payModeList;
        }

        private void CancelPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePaymode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
 }

