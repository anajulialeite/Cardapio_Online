using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class User : IdentityUser
    {
        

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
