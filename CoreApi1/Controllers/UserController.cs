using CoreApi1.Interface;
using CoreApi1.Model;
using CoreApi1.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace CoreApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUser _userService;

        public UserController(IUser userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet("GetUserList")]

        public async Task<ActionResult<List<User>>> GetUserListsAsync()
        {
            try
            {
                List<User> userList = await _userService.GetUserList();
                return Ok(userList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("GetUserListById/{ID}")]
        public async Task<ActionResult<User>> GetUserListByIdAsync(Guid ID)
        {
            try
            {
                User user = await _userService.GetUserListById(ID);
                if (user == null)
                    return NotFound($"User with ID {ID} not found");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("InsertUser")]
        public ActionResult<bool> InsertUser(User user)
        {
            try
            {
                bool result = _userService.InsertUserData(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPut("UpdateUser")]
        public ActionResult<bool> UpdateUser(User user)
        {
            try
            {
                bool result = _userService.UpdateUserData(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete("DeleteUser/{ID}")]
        public ActionResult<bool> DeleteUserByID(Guid ID)
        {
            try
            {
                bool result = _userService.DeleteUserData(ID);
                if (!result)
                    return NotFound($"User with ID {ID} not found");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}

