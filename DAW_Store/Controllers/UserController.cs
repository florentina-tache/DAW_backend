using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAW_Store.Data;
using DAW_Store.DTOs;
using DAW_Store.Models;
using DAW_Store.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace DAW_Store.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly DAW_Store_context _context;

        public UserController(IUserService userService, DAW_Store_context context)
        {
            _userService = userService;
            _context = context;
        }

        //GET
        [HttpGet("byId")]
        public IActionResult GetById(Guid Id)
        {
            return Ok(_userService.GetUserByUserId(Id));
        }

        [HttpGet("allUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }


        [HttpGet("byname")]
        public IActionResult GetAllUsersByName(string name)
        {
            return Ok(_userService.GetAllUsersByName(name));
        }


        //POST
        [HttpPost("create")]
        public IActionResult Create(RegisterUserDTO user)
        {
            _userService.CreateUser(user);
            return Ok();
        }

        //PUT
        [HttpPut("updateUser")]
        public IActionResult Update(RegisterUserDTO user, Guid id)
        {
            _userService.UpdateUser(user, id);
            return Ok();
        }


        //DELETE
        [HttpDelete]
        public IActionResult DeleteById(Guid Id)
        {
            _userService.DeleteUserById(Id);
            return Ok();
        }
    }
}