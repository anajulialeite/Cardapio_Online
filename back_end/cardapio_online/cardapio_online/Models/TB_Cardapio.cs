using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cardapio_online
{
    [Table("TB_Cardapio")]
    public class TB_Cardapio
    {
        [Key]
        public int IdCardapio { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
