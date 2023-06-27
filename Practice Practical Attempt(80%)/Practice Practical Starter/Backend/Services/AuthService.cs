using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Dtos;
using Backend.Models;
using Microsoft.IdentityModel.Tokens;

namespace Backend.Services
{
  public class AuthService
  {
    private readonly IConfiguration config;
    private readonly AppDbContext db;

    public AuthService(IConfiguration config, AppDbContext db)
    {
      this.config = config;
      this.db = db;
    }

    public LoginResponse Login(LoginRequest request)
    {  
      // create new login response
        var response = new LoginResponse();
      // TODO: Implement login validation logic here.
      // check for duplicate users with same username and throw error if true
var user = db.AppUsers.SingleOrDefault(u => u.Username == request.Username);

// if user does not exist
if(user == null){
response.Message = "Invalid Username or Password";
return response;
}
// if password for user does not match user password 
if(user.Password != request.Password) { 
  response.Message = "Invalid Username or Password";
return response;
}

    // generate token if correct username and assword is entered
     var token = GenerateUserToken(user);
     // add information to be added to response

    response.Token = token;
 response.Message = "Sucess";
 response.UserGroup = user.GroupId.ToString();
      return response;
    }

    private string GenerateUserToken(AppUser user)
    {
      var issuer = config["JwtSettings:Issuer"];
      var audience = config["JwtSettings:Audience"];

      var notBefore = DateTime.Now;
      var expires = DateTime.Now.AddHours(8);
      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtSettings:Key"]!));
      var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      var claims = new List<Claim>
       {
        new Claim("group",user.GroupId.ToString())
       };
      //   TODO: Add appropriate claims to the 'claims' list above.
//claims.Add(new Claim("group",user.GroupId.ToString()))
      var jwt = new JwtSecurityToken(
        issuer,
        audience,
        claims,
        notBefore,
        expires,
        signingCredentials);

      var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

      return encodedJwt;
    }
  }
}