using ProductManagementWebApi.Entities;
using ProductManagementWebApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Data
{
    public class DataInitializer
    {
        public static void Initialize(MemoryDataBaseContext _memoryDataBaseContext)
        {

            var products = new List<Product>()
            {
                new Product(){ Code = "P001",
                               Name = "MASK ADULT Surgical 3 ply 50'S MEDICOS with box",
                               Category = "P001",
                               Brand = "Medicos",
                               Type = "Hygiene",
                               Description = "Colour: Blue (ear loop outside, ear loop inside- random assigned), Green, Purple, White, Lime Green, Yellow, Pink",
                               CreateDateTime = DateTime.Now,
                               CreateUserId = "Admin",
                },
                new Product(){ Code = "P002",
                               Name = "Party Cosplay Player Unknown Battlegrounds Clothes Hallowmas PUBG",
                               Category = "Men's Clothing",
                               Brand = "No Brand",
                               Type = "",
                               Description = "Suitable for adults and children.",
                               CreateDateTime = DateTime.Now,
                               CreateUserId = "Admin",
                },
                new Product(){ Code = "P003",
                               Name = "Samsung Note20 Phone",
                               Category = "Mobile & Gadgets",
                               Brand = "OEM",
                               Type = "Mobile Phones",
                               Description = "OEM Phone Models",
                               CreateDateTime = DateTime.Now,
                               CreateUserId = "Admin",
                },
            };

            _memoryDataBaseContext.Product.AddRange(products);
            _memoryDataBaseContext.SaveChanges();

        }
    }
}
