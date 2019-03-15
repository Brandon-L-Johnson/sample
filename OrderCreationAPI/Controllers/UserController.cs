using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OrderCreationManagers;

namespace OrderCreationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager _userManager;
        
        [HttpGet(Name = "ListUsers")]
        public async Task<IActionResult> ListVaults()
        {
            var listOfUsers = await _userManager.ListUsers();

            return Ok(listOfUsers);
        }

        [HttpGet("{UserIdentifier}", Name = "RetrieveUser")]
        public async Task<IActionResult> Retrieve()
        {
            var user = _userManager.RetrieveUser(GetUserIdentifierFromRoute());

            return Ok(user);
        }

        [HttpDelete("{UserIdentifier}", Name = "DeleteUser")]
        public async Task<IActionResult> Delete()
        {
            await _userManager.DeleteUser(GetUserIdentifierFromRoute());

            return Ok();
        }

        private Guid GetUserIdentifierFromRoute()
        {
            var routeData = HttpContext.GetRouteData();
            var userIdentifier = routeData.Values["UserIdentifier"].ToString();

            return Guid.Parse(userIdentifier);
        }
    }
}