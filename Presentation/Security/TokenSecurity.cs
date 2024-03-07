using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IA.Configuration
{
    public class TokenSecurity
    {
        private readonly IOptions<JwtSettings>? _jwtConfig;

        public TokenSecurity(IOptions<JwtSettings>? jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }

        public string? CreateToken(string userName)
        {
            var tokenHandle = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig?.Value.SecretKey);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, userName) }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtConfig.Value.ExpirationMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),
            };

            var acessToken = tokenHandle.CreateToken(tokenDescription);

            return tokenHandle.WriteToken(acessToken);
        }
    }
}