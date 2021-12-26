using Microsoft.AspNetCore.Mvc;

namespace My_Covid_App.Controllers
{
    public class HomeController : ApiController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
