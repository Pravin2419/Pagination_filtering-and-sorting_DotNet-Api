using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Pagination_filtering_and_sorting.Models;
using Pagination_filtering_and_sorting.Service;

namespace Pagination_filtering_and_sorting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        
        [HttpGet]

        //public async Task<IActionResult<IEnumerable<User>> GetUser(int pageNUmber = 1, int pageSize=10, string filter ="", string sortOrder="name_asc"  )
        public async Task<IEnumerable<User>> UsersAsync(int pageNUmber = 1, int pageSize = 10, string filter = "", string sortOrder = "name_asc")
        {
            var users = await _userService.GetUsersAsync(pageNUmber, pageSize, filter, sortOrder);
            return users;
        }
    }
}

