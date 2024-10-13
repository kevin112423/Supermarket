using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.model
{
    internal interface ICustomersRepository
    {
        void Add(CustomersModel customersModel);
        void Edit(CustomersModel customersModel);
        void Delete(CustomersModel customersModel);

        IEnumerable<CustomersModel> GetAll();
        IEnumerable<CustomersModel> GetByValue(String value);
    }
}
