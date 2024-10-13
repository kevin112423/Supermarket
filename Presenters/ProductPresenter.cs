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

            this.view.AddNewEvent += AddNewProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.CancelEvent += CancelProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.SearchEvent += Searchproduct;

            this.view.SetProductListBildingSource(ProductBindingSource);

            LoadAllProductList();

            this.view.Show();
        }

        private void LoadAllProductList()
        {
            ProductList = repository.GetAll();
            ProductBindingSource.DataSource = ProductList;
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)ProductBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.IsEdit = true;

        }

        private void Searchproduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                ProductList = repository.GetByValue(this.view.SearchValue);
            }
            ProductBindingSource.DataSource = ProductList;
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)ProductBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfuly";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }

        }

        private void CancelProduct(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var productModel = new ProductModel();
            productModel.Id = Convert.ToInt32(view.ProductId);
            productModel.Name = view.ProductName;
            productModel.Price = Convert.ToDecimal(view.ProductPrice);
            productModel.Stock = Convert.ToInt32(view.ProductStock);

            try
            {
                new Common.ModelDataValidation().Validate(productModel);
                if (view.IsEdit)
                {
                    repository.Edit(productModel);
                    view.Message = "PayMode edited succefuly";
                }
                else
                {
                    repository.Add(productModel);
                    view.Message = "PayMode added succefuly";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
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
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "0";
            view.ProductStock = "0";
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
           view.IsEdit = false;
        }
    }
}
