using cardapio_online.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cardapio_online
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly LanchoneteContext _context;

        public CardapioController(LanchoneteContext context)
        {
            _context = context;
        }

        // GET: api/cardapio
        [HttpGet]
        public async Task<IEnumerable<TB_Cardapio>> GetCardapios()
        {
            return await _context.Cardapios.ToListAsync();
        }

        // GET: api/cardapio/5
        [HttpGet("{id}")]
        public async Task<TB_Cardapio> GetCardapio(int id)
        {
            var cardapio = await _context.Cardapios.FindAsync(id);

            //if (cardapio == null)
            //{
            //    return NotFound();
            //}

            return cardapio;
        }

        // POST: api/cardapio
        [HttpPost("PostCardapio")]
        public async Task<IActionResult> PostCardapio(TB_Cardapio cardapio)
        {
            // Validação: Verificar se o campo 'Produto' não foi preenchido
            if (string.IsNullOrEmpty(cardapio.Produto))
            {
                // Mensagem de erro informando que o nome do prato não foi preenchido
                string mensagem = string.Format("Campo nome do prato não foi preenchido: {0} \r\n", cardapio.Produto);

                // Retorna 200 OK com a mensagem de erro (não é 400 BadRequest porque o erro não é crítico)
                BadRequest("mensagem");
            }

            // Se o nome do prato foi preenchido corretamente, continua o processo normal de adição
            _context.Cardapios.Add(cardapio);
            await _context.SaveChangesAsync();

            return Ok("Produto adicionado com sucesso!");

        }

        // PUT: api/cardapio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardapio(int id, TB_Cardapio cardapio)
        {
            // Validação: Verificar se o campo 'Produto' não foi preenchido
            if (string.IsNullOrEmpty(cardapio.Produto))
            {
                // Mensagem de erro informando que o nome do prato não foi preenchido
                string mensagem = string.Format("Campo nome do prato não foi preenchido: {0} \r\n", cardapio.Produto);

                // Retorna 200 OK com a mensagem de erro (não é 400 BadRequest porque o erro não é crítico)
                BadRequest("mensagem");
            }

            if (id != cardapio.IdCardapio)
            {
                return BadRequest();
            }

            _context.Entry(cardapio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardapioExists(id))
                {
                    return NotFound("Produto não localizado");
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // Retorna 204 NoContent após a atualização bem-sucedida
        }

        // DELETE: api/cardapio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardapio(int id)
        {
            var cardapio = await _context.Cardapios.FindAsync(id);
            if (cardapio == null)
            {
                return NotFound("Produto não localizado");
            }

            _context.Cardapios.Remove(cardapio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardapioExists(int id)
        {
            return _context.Cardapios.Any(e => e.IdCardapio == id);
        }
    }
}
