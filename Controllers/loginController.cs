using Microsoft.AspNetCore.Mvc;

namespace HelloAptech.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(String username, String password)
        {
            if (username == "admin" && password == "123")
            {
                ViewBag.Message = "Đăng nhập thành công";
            }
            else
            {
                ViewBag.Message = "Sai username hoặc password";
            }
            return View();
        }
    }
}