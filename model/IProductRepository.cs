using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.model
{
    internal interface IProductRepository
    {
        void Add(PayModeModel payModeModel);
        void Edit(PayModeModel payModeModel);
        void Delete(PayModeModel payModeModel);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(String value);
    }
}
