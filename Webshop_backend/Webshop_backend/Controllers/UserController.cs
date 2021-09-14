using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Webshop_backend.Db;
using Webshop_Backend.JWT;
using static Webshop_backend.Db.Klase;

namespace Webshop_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext context;
        private readonly IJwtAuthManager jwtAuthManager;

        public UserController(MyDbContext context, IJwtAuthManager jwtAuthManager)
        {
            this.context = context;
            this.jwtAuthManager = jwtAuthManager;
        }

        [HttpGet("login")]
        public loginResult Login(string email, string password)
        {
            var user = context.zaposlenici.FirstOrDefault(z => z.Email == email && z.Password == password);
            if (user == null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Email, email)
                };
                var jwtResult = jwtAuthManager.GenerateTokens(email, claims, DateTime.Now);
                var loginResult = new loginResult
                {
                    zaposlenik = user,
                    AccessToken = jwtResult.AccessToken,
                    RefreshToken = jwtResult.RefreshToken.TokenString

                };
                return loginResult;
            }
            return null;
        }

    }
    public class loginResult
    {
        public Zaposlenik zaposlenik { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
