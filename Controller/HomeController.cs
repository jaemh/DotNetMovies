using Microsoft.AspNetCore.Mvc;


namespace Movies.Controllers
{

    [Route("/home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }

}