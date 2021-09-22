using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Entities
{
    public class CommonCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string UpdateUserId { get; set; }
    }
}
