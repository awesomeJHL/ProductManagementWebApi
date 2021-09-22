using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementShared.Models
{
    public class ApiResponseModel : BaseResponseModel
    {
        private readonly static string successMessage = "success";
        public object Data { get; set; }

        public ApiResponseModel()
        {
            this.Success = "Y";
            this.Message = successMessage;
            this.Data = null;
            this.SentDate = DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss");
        }

        public ApiResponseModel(object payload, string message = "", string success = "Y")
        {
            this.Success = success == "Y" ? "Y" : "N";
            this.Message = message == string.Empty ? successMessage : message;
            this.Data = payload;
            this.SentDate = DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss");
        }
    }
}
