using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            return Ok(result);
        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int colorid)
        {
            var result = _colorService.GetCarsByColorId(colorid);
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Added(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("deleted")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Deleted(color);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Updated(Color color)
        {
            var result = _colorService.Updated(color);
            return Ok(result);
        }
    }
}
