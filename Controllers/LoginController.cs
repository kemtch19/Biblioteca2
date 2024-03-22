using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class LoginController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}