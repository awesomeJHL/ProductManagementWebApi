using ProductManagementShared.Interfaces;
using ProductManagementShared.Models;
using ProductManagementWebApi.Entities;
using ProductManagementWebApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Services
{
    public class ProductService : IProductService
    {
        public static readonly string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        private readonly MemoryDataBaseContext _dbcontext;

        public ProductService(MemoryDataBaseContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public ProductModel GetProduct(int id)
        {
            var product = GetProducts("", id);
            return product.FirstOrDefault();
        }

        public List<ProductModel> GetProducts(string name = "", int id = 0)
        {
            var result = _dbcontext.Product.Select(x => new ProductModel 
                                                                        {  Id = x.Id
                                                                        , Code = x.Code
                                                                        , Name = x.Name
                                                                        , Category = x.Category
                                                                        , Brand = x.Brand
                                                                        , Type = x.Type
                                                                        , Description = x.Description
                                                                        , CreateDateTime = x.CreateDateTime.ToString(DATE_TIME_FORMAT)
                                                                        , CreateUserId = x.CreateUserId 
                                                                        , UpdateDateTime = x.UpdateDateTime != DateTime.MinValue ? x.UpdateDateTime.ToString(DATE_TIME_FORMAT) : string.Empty
                                                                        , UpdateUserId = x.CreateUserId 

            })
                .Where(x => x.Name.Contains(!string.IsNullOrWhiteSpace(name) ? name : x.Name))
                .Where(x => x.Id == (id != 0 ? id : x.Id))
            .ToList();

            return result;
        }

        public bool AddProduct(ProductModel model)
        {
            var entity = new Product()
            {
                Code = model.Code,
                Name = model.Name,
                Category = model.Category,
                Brand = model.Brand,
                Type = model.Type,
                Description = model.Type,
                CreateDateTime = DateTime.Now,
                CreateUserId = model.CreateUserId
            };

            _dbcontext.Product.Add(entity);
            return _dbcontext.SaveChanges() > 0 ? true : false ;             
        }

        public bool UpdateProduct(ProductModel param, int id)
        {
            var entity = GetProductEntity(id);

            if (entity == null) return false;

            if (!string.IsNullOrWhiteSpace(param.Name))
                entity.Name = param.Name;

            if (!string.IsNullOrWhiteSpace(param.Category))
                entity.Category = param.Category;

            if (!string.IsNullOrWhiteSpace(param.Brand))
                entity.Brand = param.Brand;

            if (!string.IsNullOrWhiteSpace(param.Type))
                entity.Type = param.Type;

            if (!string.IsNullOrWhiteSpace(param.Description))
                entity.Description = param.Description;

            entity.UpdateDateTime = DateTime.Now;
            entity.UpdateUserId = param.UpdateUserId;

            _dbcontext.Product.Update(entity);

            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public bool DeleteProduct(int id)
        {
            var entity = GetProductEntity(id);

            if (entity == null) return false;

            _dbcontext.Product.Remove(entity);
            _dbcontext.SaveChanges();

            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public Product GetProductEntity(int id)
        {
            return _dbcontext.Product.Find(id);
        }
    }
}
