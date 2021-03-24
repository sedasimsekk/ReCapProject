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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int carid)
        {
            var result = _carService.GetById(carid);
            return Ok(result);
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int brandid)
        {
            var result = _carService.GetCarsByBrandId(brandid);
            return Ok(result);
        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int colorid)
        {
            var result = _carService.GetCarsByColorId(colorid);
            return Ok(result);
        }
        
        [HttpGet("getcarsdetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Added(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
        [HttpPost("deleted")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Deleted(car);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Updated(Car car)
        {
            var result = _carService.Updated(car);
            return Ok(result);
        }

    }
}
 