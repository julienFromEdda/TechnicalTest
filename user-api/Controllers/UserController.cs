using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserApi.DataAccess;
using UserApi.Models.Request;
using UserApi.Models.Result;

namespace UserApi.Controllers;

/// <summary>
/// Contrôlleur utilisateur
/// </summary>
[ApiController]
[Route("users")]
public class UserController(UserDbContext context) : Controller
{
    /// <summary>
    /// Recherche des utilisateurs
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("search")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserResult))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Search([FromBody] UserRequest request)
    {
        if (request == null)
            return BadRequest("Request parameter is required.");

        var query = context.Users.AsQueryable();

        if (!string.IsNullOrEmpty(request.Term))
        {
            query = query.Where(item => item.Name.Contains(request.Term) || item.FirstName.Contains(request.Term));
        }

        var result = new UserResult
        {
             TotalCount = await query.CountAsync(),
             Results = await query.ToListAsync()
        };

        return Ok(result);
    }
}
