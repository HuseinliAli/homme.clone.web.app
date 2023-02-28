using irshad.clone.business.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homme.clone.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        private ISubCategoryService _subCategoryService;

        public SubCategoriesController(ISubCategoryService subCategoryService)
        {
            _subCategoryService=subCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _subCategoryService.GetAll();
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
            var result = _subCategoryService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(SubCategory subCategory)
        {
            var result = _subCategoryService.Add(subCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(SubCategory subCategory)
        {
            var result = _subCategoryService.Update(subCategory);
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
            var result = _subCategoryService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
