using Microsoft.AspNetCore.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class TesteLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
