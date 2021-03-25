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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbycustomerid")]
        public IActionResult GetByCustomerId(int customerid)
        {
            var result = _customerService.GetByCustomerId(customerid);
            return Ok(result);
        }

        [HttpGet("getcustomersbycompanyname")]
        public IActionResult GetCustomersByCompanyName(string companyname)
        {
            var result = _customerService.GetCustomersByCompanyName(companyname);
            return Ok(result);
        }

        [HttpGet("getbycustomeruserid")]
        public IActionResult GetByCustomerUserId(int customeruserid)
        {
            var result = _customerService.GetByCustomerUserId(customeruserid);
            return Ok(result);
        }

        [HttpGet("getcustomerdetails")]
        public IActionResult GetCustomerDetails()
        {
            var result = _customerService.GetCustomerDetails();
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Added(customer);
                return Ok(result);
        }

        [HttpPost("deleted")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Deleted(customer);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Updated(customer);
            return Ok(result);
        }
    }
}
