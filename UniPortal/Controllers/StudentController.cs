using Microsoft.AspNetCore.Mvc;
using UniPortal.DbContexts;

namespace UniPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
         
            return View();
        }
        
        [Route("Student/{id:int}")]
        public IActionResult Details(int id)
        {
            // TODO FETCH DATA
            return View();
        }
        
        
    }
}
