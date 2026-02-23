using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Timeouts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplicationConFiltro.Models;

namespace WebApplicationConFiltro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public authController(IConfiguration configuration)
        {


        }

        [HttpPost("login")]
        public ActionResult Login(Autenticazione account)
        {
            if (account.Username == "admin" && account.Password == "admin")
            {
                account.Profilo = "admin";
            }
            else
            {
                if (account.Username == "Utente" && account.Password == "Utente")
                {
                    account.Profilo = "utente";
                }
                else
                {
                    if (account.Tipo == null)
                    {
                        return BadRequest("account non valido");
                    }

                }


                //scrivere algortmo per la reale autenticazione
                return Ok();
            }
            List<Claim> claims = new List<Claim>()
    {
              new Claim(JwtRegisteredClaimNames.Sub,account.Username), //il sub lo definisce il cliente
              new Claim("UserType", account.Tipo),
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),//identificativo univoco
              new Claim("Email","email dell'utente"),
              new Claim("ruolo","2")

            };
            // definisco la chiave x la cifratura del mio algoritmo
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("la mia mia chiave"));
            string chiave = _configuration.GetSection("key").ToString();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(chiave));
            //abbino la mia chiave all algoritmo
            var credenziali = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //creo il token
            string issuer = _configuration.GetSection("issuer").ToString();
            string audience = _configuration.GetSection("audience").ToString();
            var mioTokenJwt = new JwtSecurityToken(issuer: issuer, audience: audience,//issuer e audience stabiliti in program.cs
            claims: claims,
            expires: DateTime.Now.AddMinutes(20),
            signingCredentials: credenziali
            );
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(mioTokenJwt)
            });
        }
    }
} 
   

