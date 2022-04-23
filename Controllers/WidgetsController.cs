using Microsoft.AspNetCore.Mvc;

namespace OBSTools.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult CurrentSong()
        {
            return View();
        }
    }
}
