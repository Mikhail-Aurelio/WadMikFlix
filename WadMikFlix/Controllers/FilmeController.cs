using Microsoft.AspNetCore.Mvc;
using WadMikFlix.Context;

namespace WadMikFlix.Controllers
{
    public class FilmeController : Controller
    {
        private readonly AppDbContext _context;
        public FilmeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var teste = _context.Filmes;
            return View(teste);
        }
    }
}
