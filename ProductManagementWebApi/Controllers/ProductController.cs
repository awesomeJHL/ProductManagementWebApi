using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManagementShared.Interfaces;
using ProductManagementShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Controllers
{
    public class ProductController : BaseController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        // Search Product list
        [HttpGet("management/list/{name?}")]
        public IActionResult GetProducts(string name)
        {
            var result = _productService.GetProducts(name);
            return Ok(new ApiResponseModel(result));
        }

        // Search Product single
        [HttpGet("management/{id}")]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.GetProduct(id);
            return Ok(new ApiResponseModel(result));
        }

        // ADD Product
        [HttpPost("management")]
        public IActionResult AddProduct(ProductModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _productService.AddProduct(model);
            return Ok(new ApiResponseModel(_productService.GetProducts()));
        }

        // Update Product
        [HttpPatch("management/{id}")]
        public IActionResult UpdateProduct(ProductModel model, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _productService.UpdateProduct(model, id);
            return Ok(new ApiResponseModel(_productService.GetProducts()));
        }

        // Delete Product
        [HttpDelete("management/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok(new ApiResponseModel(_productService.GetProducts()));
        }

    }
}
