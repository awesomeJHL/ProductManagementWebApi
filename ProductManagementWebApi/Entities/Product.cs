using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string UpdateUserId { get; set; }
    }
}
