using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementShared.Models
{
    public class BaseResponseModel
    {
        public string Success { get; set; }
        public string Message { get; set; }
        public string SentDate { get; set; }
    }
}
