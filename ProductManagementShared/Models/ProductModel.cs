using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagementShared.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(4)]
        public string Code { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Category { get; set; }
        //public string CategoryName { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        //public string BrandName { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        //public string TypeName { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public string CreateDateTime { get; set; }
        public string CreateUserId { get; set; }
        public string UpdateDateTime { get; set; }
        public string UpdateUserId { get; set; }
    }
}
