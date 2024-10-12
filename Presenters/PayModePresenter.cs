using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.view;
using Supermarket_mvp.model;
using Supermarket_mvp.Presenters.Common;


namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource PayModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            PayModeBindingSource = new BindingSource();
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
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(view.SearchValue);
            }
            PayModeBindingSource.DataSource = payModeList;
        }

        private void CancelPayMode(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payModel = (PayModeModel)PayModeBindingSource.Current;

            view.PayModeId = payModel.Id.ToString();
            view.PayModeName = payModel.Name.ToString();
            view.PayModeObservation = payModel.Observation.ToString();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePaymode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common. ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited succefuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added succefuly";
                }
                view.IsSuccessful = true;
                LoadAllPayModeList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }


        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";

        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}

