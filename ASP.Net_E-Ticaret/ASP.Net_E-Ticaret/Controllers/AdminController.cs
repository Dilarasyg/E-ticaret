using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_E_Ticaret.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
