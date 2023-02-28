using irshad.clone.business.Abstract;
using irshad.clone.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homme.clone.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService=colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
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
            var result = _colorService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
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
            var result = _colorService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
