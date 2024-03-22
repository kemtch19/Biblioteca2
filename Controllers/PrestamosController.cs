using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class PrestamosController : Controller{
        public IActionResult Index(){
            return View();
        }
        
    }
}