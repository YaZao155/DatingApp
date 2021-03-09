using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;
        public UsersController(DataContext context)
        {
            this.context = context;
        }

        // Gets the ID of the user logging in
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await context.Users.ToListAsync();

           
        }

        // Gets the ID of the user logging in
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            return await context.Users.FindAsync(id);            
        }
    }
}