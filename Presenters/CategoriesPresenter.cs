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
        private ICategoriesView view ;
        private ICategoriesRepository repository;
        private BindingSource CategoriesBindingSource;
        private IEnumerable<CategoriesModel> CategoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.CategoriesBindingSource  = new BindingSource();
              

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
            throw new NotImplementedException();
        }

        private void CancelCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
