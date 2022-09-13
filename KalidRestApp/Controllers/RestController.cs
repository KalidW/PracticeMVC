using Microsoft.AspNetCore.Mvc;

namespace KalidRestApp.Controllers
{
    public class RestController : Controller
    {
        public IActionResult RestContent()
        {
            return View();
        }
    }
}
