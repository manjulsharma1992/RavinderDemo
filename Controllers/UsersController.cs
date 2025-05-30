using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserServiceAPI.Models;
using UserServiceAPI.Services;

namespace UserServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        // GET: api/users
        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _userService.GetAllUsers();
        }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
                return NotFound();
            return user;
        }

        // POST: api/users
        [HttpPost]
        public IActionResult Create(User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }
    }
}