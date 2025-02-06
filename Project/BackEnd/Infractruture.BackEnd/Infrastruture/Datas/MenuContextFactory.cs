using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastruture.Datas
{
    public class MenuContextFactory : IDesignTimeDbContextFactory<MenuContext>
    {
        public MenuContext CreateDbContext(string[] args)
        {
            // Substitua pela sua string de conexão
            var optionsBuilder = new DbContextOptionsBuilder<MenuContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CardapioOnline;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MenuContext(optionsBuilder.Options);
        }
    }
}
