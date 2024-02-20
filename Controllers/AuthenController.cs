using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerBalanceApi.Services.UsersService;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Azure;
using System.Text;


namespace CustomerBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {

        public static Users users = new Users();
        private readonly IConfiguration _configuration;
        private readonly IUsersService _usersService;

        public AuthenController(IConfiguration configuration, IUsersService usersService)
        {
            _configuration = configuration;
            _usersService = usersService;
        }

        [HttpGet, Authorize]
        public ActionResult<string>GetSingleUserByName()
        {
            return Ok(_usersService.GetSingleUserByName);
            // var UserName = User?.Identity?.Name;
            // var roleClaims = User?.FindAll(ClaimTypes.Role);
            // var roles = roleClaims?.Select(c => c.Value).ToList(); 

            //var roles2 = User?.Claims
            //.Where(c => c.Type == ClaimTypes.Role)
            //.Select(c => c.Value)//.ToList();
            //return Ok(new { UserName, roles, roles2 });
        }

        [HttpPost("register")]
        public ActionResult<Users> Register(UsersDTO request)
        {
            string passwordHash
            = BCrypt.Net.BCrypt.HashPassword(request.PasswordHash);

            users.Name = request.Name;
            users.Telephone = request.Telephone;
            users.EmailAddress = request.EmailAddress;
            users.Gender = request.Gender;
            users.UserName = request.UserName;
            users.PasswordHash = passwordHash;

            return Ok(users);
        }

        [HttpPost("login")]
        public ActionResult<Users> Login(UsersDTO request)
        {
            if (users.UserName != request.UserName)
            {
                return BadRequest("User not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.PasswordHash, users.PasswordHash))
            {
                string token = CreateToken(users);

                return Ok(token);
            }

            return BadRequest("Wrong password.");
        }

        private string CreateToken(Users users)
        {
            List<Claim> claims = new List<Claim>
            {
              new Claim(ClaimTypes.Name, users.UserName),
                new Claim(ClaimTypes.Role, "Admins"),
                new Claim(ClaimTypes.Role, "Users")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                             _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(30),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}




