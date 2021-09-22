using ProductManagementShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementShared.Interfaces
{
    public interface IProductService
    {
        List<ProductModel> GetProducts(string name = "", int id = 0);

        ProductModel GetProduct(int id);

        bool AddProduct(ProductModel model);

        bool UpdateProduct(ProductModel param, int id);

        bool DeleteProduct(int id);
    }
}
