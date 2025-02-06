using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruture.Datas
{
    public  class MenuContext :IdentityDbContext <User>
    {
        public  MenuContext (DbContextOptions <MenuContext> options) : base (options)
        { 

        }

        public DbSet <User> User { get; set; }
      

    }
}
