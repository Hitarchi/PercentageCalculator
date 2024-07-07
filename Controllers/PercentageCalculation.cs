using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMarks.Data;
using System.Data;

namespace StudentMarks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PercentageCalculation : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PercentageCalculation(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> CalculatePercentage()
        {
            decimal percentage = 0;
            var connection = _context.Database.GetDbConnection();
            try
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "CALL usp_GetStudentDetails()";
                    command.CommandType = CommandType.Text;

                    var result = await command.ExecuteScalarAsync();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal parsedPercentage))
                    {
                        percentage = parsedPercentage;
                    }
                }
            }
            finally
            {
                await connection.CloseAsync();
            }

            return Ok(new { percentage });
        }
    }
}
