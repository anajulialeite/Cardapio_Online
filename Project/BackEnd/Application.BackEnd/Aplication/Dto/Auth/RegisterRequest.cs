using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
namespace Aplication.Dto.Auth
{
    public class RegisterRequestDto
    {
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public UserRoleEnums.Role Role { get; set; }= UserRoleEnums.Role.user;
    }
}
