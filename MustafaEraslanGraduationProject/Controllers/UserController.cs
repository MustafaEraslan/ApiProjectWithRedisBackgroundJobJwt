﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/user")]//route verdim
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MoviesContext context;
        private readonly IConfiguration configuration;

        public UserController(MoviesContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        [HttpGet("login")]
        public string Login(string Username, string Password)
        {
            var user = context.Users.FirstOrDefault(x => x.Username == Username && x.Password == Password);

            if (user != null)
            {
                return GenerateToken(user.Username);
            }

            return "";
        }

        private string GenerateToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration["Application:JWTSecret"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = "ARVATO",
                Issuer = "ARVATO.Issuer.Development",
                Subject = new ClaimsIdentity(new Claim[]
                 {
                            
                            new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role , "Administrator")
                 }),

                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
