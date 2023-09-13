﻿using Bootcamp_Project.EF_Core;
using Bootcamp_Project.Models.Users;
using Bootcamp_Project.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
namespace Bootcamp_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService userService;
        private readonly ILogger<UsersController> logger;
        public UsersController(EF_DataContext context, ILogger<UsersController> logger)
        {
            userService = new UserService(context,logger);
            this.logger = logger;
        }

        // GET: api/<UsersController>
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        { 
            return userService.GetUsers();
        }


        // GET : api/<UserController>/GetUser/{id}
        [HttpGet("GetUser/{id}")]
        public IActionResult GetUser(int id)
        {
            return userService.GetUser(id);
        }


        //POST : api/<UserController>/register
        [HttpPost]
        [Route("register")]
        public IActionResult RegisterUser([FromBody] RegisterRequest data)
        {
                return userService.RegisterUser(data);
        }


        //POST : api/<UserController>/login
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser([FromBody] LoginRequest data)
        {
            Console.WriteLine("inside controller", data);
            return userService.LoginUser(data);
        }
    }
}
