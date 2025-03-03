using Microsoft.AspNetCore.Mvc;

namespace BigBrother.Controllers
{
    public class BaoCaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
