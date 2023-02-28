using irshad.clone.business.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homme.clone.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private ICatalogService _catalogService;

        public CatalogsController(ICatalogService catalogService)
        {
            _catalogService=catalogService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _catalogService.GetAll();
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
            var result = _catalogService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Catalog catalog)
        {
            var result = _catalogService.Add(catalog);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Catalog catalog)
        {
            var result = _catalogService.Update(catalog);
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
            var result = _catalogService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
