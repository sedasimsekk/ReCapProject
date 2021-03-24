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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            return Ok(result);
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int brandid)
        {
            var result = _brandService.GetCarsByBrandId(brandid);
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Added(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("deleted")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Deleted(brand);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Updated(Brand brand)
        {
            var result = _brandService.Updated(brand);
            return Ok(result);
        }
    }
}
