using Microsoft.AspNetCore.Mvc;

namespace MVCPronia.Areas.ProniaAdmin.Controllers
{
    public class HomeController : Controller
    {
        [Area("ProniaAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
