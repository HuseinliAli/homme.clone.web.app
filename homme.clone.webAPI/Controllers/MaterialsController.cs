using irshad.clone.business.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homme.clone.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private IMaterialService _materialService;

        public MaterialsController(IMaterialService materialService)
        {
            _materialService=materialService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _materialService.GetAll();
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
            var result = _materialService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Material material)
        {
            var result = _materialService.Add(material);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Material material)
        {
            var result = _materialService.Update(material);
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
            var result = _materialService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
