using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CustomerBalanceApi.Models;
using CustomerBalanceApi.Data;
using CustomerBalanceApi.Services;
using CustomerBalanceApi.Services.UsersService;
using System.Net.Mail;



namespace CustomerBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            return await _usersService.GetAllUsers();
        }

        [HttpGet("GetSingleUserByName/{Name}")]
        public async Task<ActionResult<Users>> GetSingleUserByName(string name)
        {
            var result = await _usersService.GetSingleUserByName(name);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByTelephone/{Telephone}")]
        public async Task<ActionResult<Users>> GetSingleUserByTelephone(string telephone)
        {
            var result = await _usersService.GetSingleUserByTelephone(telephone);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<Users>> GetSingleUserByEmailAddress(string emailaddress)
        {
            var result = await _usersService.GetSingleUserByEmailAddress(emailaddress);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByGender/{Gender}")]
        public async Task<ActionResult<Users>> GetSingleUserByGender(string gender)
        {
            var result = await _usersService.GetSingleUserByGender(gender);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByUserName/{UserName}")]
        public async Task<ActionResult<Users>> GetSingleUserByUserName(string username)
        {
            var result = await _usersService.GetSingleUserByUserName(username);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<Users>> GetSingleUserByPasswordHash(string passwordhash)
        {
            var result = await _usersService.GetSingleUserByPasswordHash(passwordhash);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Users>>> AddUsers(Users users)
        {
            var result = await _usersService.AddUsers(users);
            return Ok(result);
        }

        [HttpPut("UpdateUserByName/{Name}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByName(string name, Users request)
        {
            var result = await _usersService.UpdateUserByName(name, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByTelephone(string telephone, Users request)
        {
            var result = await _usersService.UpdateUserByTelephone(telephone, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByEmailAddress(string emailaddress, Users request)
        {
            var result = await _usersService.UpdateUserByEmailAddress(emailaddress, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByGender/{Gender}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByGender(string gender, Users request)
        {
            var result = await _usersService.UpdateUserByGender(gender, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByUserName/{UserName}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByUserName(string username, Users request)
        {
            var result = await _usersService.UpdateUserByUserName(username, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPut("UpdateUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<List<Users>>> UpdateUserByPasswordHash(string passwordhash, Users request)
        {
            var result = await _usersService.UpdateUserByPasswordHash(passwordhash, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByName/{Name}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByName(string name)
        {
            var result = await _usersService.DeleteUserByName(name);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByTelephone(string telephone)
        {
            var result = await _usersService.DeleteUserByTelephone(telephone);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByEmailAddress/{EmailAddress}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByEmailAddress(string emailaddress)
        {
            var result = await _usersService.DeleteUserByEmailAddress(emailaddress);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByGender/{Gender}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByGender(string gender)
        {
            var result = await _usersService.DeleteUserByGender(gender);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByUserName/{UserName}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByUserName(string username)
        {
            var result = await _usersService.DeleteUserByUserName(username);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteUserByPasswordHash/{PasswordHash}")]
        public async Task<ActionResult<List<Users>>> DeleteUserByPasswordHash(string passwordhash)
        {
            var result = await _usersService.DeleteUserByPasswordHash(passwordhash);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }
    }
}

    
    
