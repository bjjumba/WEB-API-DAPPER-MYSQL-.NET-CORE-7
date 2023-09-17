using Microsoft.AspNetCore.Mvc;
using SONDA.Repositories;

namespace SONDA.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public readonly IUserRepository _userRepo;
    
    public UserController(IUserRepository _userRepo)
    {
        this._userRepo = _userRepo;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var _list = await this._userRepo.GetAll();
        if (_list != null)
        {
            return Ok(_list);
        }
        else
        {
            return NotFound();
        }
    }
   
}