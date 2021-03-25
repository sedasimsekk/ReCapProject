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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userid)
        {
            var result = _userService.GetByUserId(userid);
            return Ok(result);
        }

        [HttpGet("getbyfirstname")]
        public IActionResult GetByFırstName(string firstname)
        {
            var result = _userService.GetByFırstName(firstname);
            return Ok(result);
        }

        [HttpPost("added")]
        public IActionResult Add(User user)
        {
            var result = _userService.Added(user);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleted")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Deleted(user);
            return Ok(result);
        }

        [HttpPost("updated")]
        public IActionResult Update(User user)
        {
            var result = _userService.Updated(user);
            return Ok(result);
        }


    }
}
