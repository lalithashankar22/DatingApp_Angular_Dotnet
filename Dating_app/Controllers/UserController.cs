using Dating_app.DB_Context;
using Dating_app.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating_app.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly DA_DBContextClass dbcontext;

        public UserController(DA_DBContextClass dB_Context)
        {
            dbcontext = dB_Context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserClass>>> GetAllUsers()
        {
            var users = await dbcontext.User.ToListAsync();
            return users;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<AppUserClass>> GetSingleUser(int id) 
        {
            var user = await dbcontext.User.SingleOrDefaultAsync(x => x.Id == id);
            return user;
        }
    }
}
