using Microsoft.AspNetCore.Mvc;

namespace ASP_LR6.Controllers
{

    
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Error()
            {
                return View();
            }
        }


}
