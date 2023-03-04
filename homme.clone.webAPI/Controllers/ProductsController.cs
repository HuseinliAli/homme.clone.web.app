using irshad.clone.business.Abstract;
using irshad.clone.core.Utilities.Results.Abstract;
using irshad.clone.entities.Concrete;
using irshad.clone.entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace irshad.clone.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService=productService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAllWithImages();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getAllWithoutImages")]
        public IActionResult GetAllWithoutImages()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [Route("byId/{id:int}")]
        [HttpGet]
        public IActionResult ById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [Route("byCatalogId/{id:int}")]
        [HttpGet]
        public IActionResult ByCatalogId(int id)
        {
            var result = _productService.GetByCatalogId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [Route("delete/{id:int}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _productService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        [Route("byCategoryId/{id:int}")]
        [HttpGet]
        public IActionResult ByCategoryId(int id)
        {
            var result = _productService.GetByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        [Route("bySubCategoryId/{id:int}")]
        [HttpGet]
        public IActionResult BySubCategoryId(int id)
        {
            var result = _productService.GetBySubCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [Route("byMaterialId/{id:int}")]
        [HttpGet]
        public IActionResult ByMaterialId(int id)
        {
            var result = _productService.GetByMaterialId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [Route("byColorId/{id:int}")]
        [HttpGet]
        public IActionResult ByColorId(int id)
        {
            var result = _productService.GetByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [Route("byUnitPrice/{min:decimal,max:decimal}")]
        [HttpGet]
        public IActionResult ByUnitPrice(decimal min, decimal max)
        {
            var result = _productService.GetByUnitPrice(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}

