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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            return Ok(result);
        }

        [HttpGet("getrentalsbycarid")]
        public IActionResult GetRentalsByCarId(int carid)
        {
            var result = _rentalService.GetRentalsByCarId(carid);
            return Ok(result);
        }

        [HttpGet("getrentalsbycustomerid")]
        public IActionResult GetRentalsByCustomerId(int customerid)
        {
            var result = _rentalService.GetRentalsByCustomerId(customerid);
            return Ok(result);
        }

        [HttpGet("getrentaldetails")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentalDetails();
            return Ok(result);
        }

        [HttpGet("getbyrentalid")]
        public IActionResult GetByRentalId(int rentalid)
        {
            var result = _rentalService.GetByRentalId(rentalid);
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Added(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleted")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Deleted(rental);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Updated(rental);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
