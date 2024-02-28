using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    [ApiController]
    [Route("/users")]

    public class UsersController : ControllerBase
    {
        private DataBaseContext dbcpontext;

        public UsersController(DataBaseContext dbcpontext)
        {
            this.dbcpontext = dbcpontext;
        }

        [HttpGet(Name = "GetUsers")]

        public async Task<IActionResult> Get([FromQuery] string? search)
        {
            if (search == null)
                return Ok(await dbcpontext.Users.ToListAsync());
            else
                return Ok(await dbcpontext.Users)
                    .Where(u => u.name.ToLower().Contains(search.ToLower()))
                    .ToListAsync();
        }
    }
}
