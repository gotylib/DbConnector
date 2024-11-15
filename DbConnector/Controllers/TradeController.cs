using DbConnector.Core;
using DbConnector.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbConnector.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeController : ControllerBase
    {
        private readonly ApplicationDbContextcs _dbContext;

        public TradeController(ApplicationDbContextcs dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("AddTrades")]
        public ActionResult AddTrades([FromBody] IList<Trade> trades)
        {
            if (trades == null || !trades.Any())
            {
                return BadRequest("Торги не могут быть пустыми.");
            }

            try
            {
                // Вставьте ваши трейды в базу данных
                _dbContext.Traids.AddRange(trades); // добавляем несколько трейдов
                _dbContext.SaveChanges(); // сохраняем изменения

                return Ok(trades); // возвращаем добавленные трейды
            }
            catch (Exception ex)
            {
                // Обработка исключений
                return StatusCode(500, $"Ошибка при добавлении трейдов: {ex.Message}");
            }
        }

    }
}
