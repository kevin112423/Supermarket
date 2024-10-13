﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.model
{
    internal interface IProductRepository
    {
        void Add(ProductModel  productModel);
        void Edit(ProductModel productModel);
        void Delete(ProductModel productModel);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(String value);
    }
}
