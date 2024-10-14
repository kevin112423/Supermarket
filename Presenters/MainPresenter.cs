    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp._repository;
using Supermarket_mvp.model;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.view;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCustomersView += ShowCustomersView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
        }

        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);  
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        private void ShowCustomersView(object? sender, EventArgs e)
        {

            ICustomersView view = CustomersView.GetInstance((MainView)mainView); // Asegúrate de que mainView sea un Form
            ICustomersRepository repository = new CustomersRepository(sqlConnectionString);
            new CustomersPresenter(view, repository);
            
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);

        }
    }
}
