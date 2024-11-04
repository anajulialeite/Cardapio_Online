using Microsoft.EntityFrameworkCore;

namespace cardapio_online.Models
{
    public class LanchoneteContext
    {
        // Construtor que aceita opções de configuração
        public LanchoneteContext(DbContextOptions<LanchoneteContext> options)
            : base(options)
        {
        }

        // Propriedade que representa a tabela TB_Cardapio
        public DbSet<Cardapio> Cardapios { get; set; }

        // Configurações adicionais podem ser feitas aqui
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura o nome da tabela no banco de dados
            modelBuilder.Entity<Cardapio>()
                .ToTable("TB_Cardapio");
        }
    }
}
