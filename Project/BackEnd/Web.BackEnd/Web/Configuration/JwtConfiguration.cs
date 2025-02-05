using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BackEnd.Configuration
{
    public class JwtConfiguration
    {
        public string Key { get; set; } = string.Empty;

        public string Issues {  get; set; } = string.Empty;

        public string Audience {  get; set; } = string.Empty;

        public SymmetricSecurityKey SecurityKey()
        {
            var CoddingSecret = Encoding.UTF8.GetBytes(Key);
            return new SymmetricSecurityKey(CoddingSecret);
        }
    }
}
