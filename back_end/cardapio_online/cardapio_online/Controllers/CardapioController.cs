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
            _context.Cardapios.Add(cardapio);
            var retorno = await _context.SaveChangesAsync();

            return Ok();

            //return CreatedAtAction("GetCardapio", new { id = cardapio.IdCardapio }, cardapio);
        }

        // PUT: api/cardapio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardapio(int id, TB_Cardapio cardapio)
        {
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
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/cardapio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardapio(int id)
        {
            var cardapio = await _context.Cardapios.FindAsync(id);
            if (cardapio == null)
            {
                return NotFound();
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
