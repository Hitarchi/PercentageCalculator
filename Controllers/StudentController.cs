using Microsoft.AspNetCore.Mvc;
using StudentMarks.Data;
using StudentMarks.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarks.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] StudentModel model)
        {
            if (ModelState.IsValid)
            {
                await _context.SaveStudentData(model);
                return Json(new { success = true });
              
            }
            return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });
    
        }

        [HttpPost]
        public IActionResult GetLatestData([FromBody] StudentModel model)
        {
            return Json(model);
        }

        [HttpGet]
        public IActionResult MarksDistribution(StudentModel model)
        {
            return View(model);
        }
    }
}
