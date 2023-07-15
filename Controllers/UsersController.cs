using Microsoft.AspNetCore.Mvc;
using UsersApi.models;

namespace UsersApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserContext dbContext;
    public UserController(UserContext _dbContext) {
        dbContext = _dbContext;
    }

    [HttpGet]
    public async Task<List<User>> getUser() {
        await dbContext.Users.ToListAsync();
    }

    [HttpPost]
    public async Task<User> postUser([FromBody] UpdateNameDTO name, [FromBody] UpdateEmailDTO email) {
        await dbContext.Users.AddAsync(name);
        await dbContext.Users.AddAsync(email);

        return Nocontent();
    }

    [HttpDelete]
    public async Task<ActionResult> deleteUser([FromQuery] long Id)
    {
    var findUser = await dbContext.Users.FindAsync(Id);

    if (!findUser.Equals(null)) 
    {
        dbContext.TodoItems.Remove(findUser);
        return NoContent();
    }

    return NotFound();    
  }
}
