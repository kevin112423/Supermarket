using Supermarket_mvp.model;
using Supermarket_mvp.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.model;
using Supermarket_mvp.view;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource CategoriesBindingSource;
        private IEnumerable<CategoriesModel> CategoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.CategoriesBindingSource = new BindingSource();


            this.view = view;
            this.repository = repository;
            this.view.AddNewEvent += AddNewCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.CancelEvent += CancelCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.SearchEvent += SearchCategories;

            this.view.SetCategoriesListBildingSource(CategoriesBindingSource);

            LoadAllCategoriesList();

            this.view.Show();

        }

        private void LoadAllCategoriesList()
        {
            CategoriesList = repository.GetAll();
            CategoriesBindingSource.DataSource = CategoriesList;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                CategoriesList = repository.GetByValue(this.view.SearchValue);
            }
            CategoriesBindingSource.DataSource = CategoriesList;
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            var payMode = (CategoriesModel)CategoriesBindingSource.Current;

            view.CategoriesId = payMode.Id.ToString();
            view.CategoriesName = payMode.Name;
            view.CategoriesDescription = payMode.Description;

            view.IsEdit = true;

        }

        private void CancelCategories(object? sender, EventArgs e)
        {
            CleanViewFields();

        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";

        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            var product = (ProductModel)CategoriesBindingSource.Current;

            view.CategoriesId = product.Id.ToString();
            view.CategoriesName = product.Name;
            view.CategoriesDescription = product.Price.ToString();
            view.IsEdit = true;

        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {


                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categories edited successfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categories added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoriesList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false ;
        }
    }
}
