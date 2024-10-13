using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.model
{
    internal interface ICategoriesRepository
    {
        void Add(CategoriesModel categoriesModel);
        void Edit(CategoriesModel categoriesModel);
        void Delete(int id);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(String value);
    }
}
