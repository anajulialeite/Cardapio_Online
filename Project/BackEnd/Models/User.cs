using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Informe o email válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha obrigatória")]
        [MinLength(6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string Password { get; set; } = string.Empty;

        //definimos como padrão um usuário normal
        public Role Roles { get; set; } = Role.User;

        public enum Role 
        {
            User,
            Admin
        }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
