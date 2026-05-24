using Microsoft.AspNetCore.Mvc;
using Ubuntu.Models.ViewModels;

namespace Ubuntu.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View(new LoginViewModel());

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Email) || string.IsNullOrWhiteSpace(model.Password))
            {
                model.ErrorMessage = "Please enter your email and password.";
                model.HasError = true;
                return View(model);
            }
            if (model.Email == "merchant@ubuntu.co.za" && model.Password == "password")
                return RedirectToAction("Index", "Home");

            model.ErrorMessage = "Invalid email or password.";
            model.HasError = true;
            return View(model);
        }

        [HttpGet]
        public IActionResult Index() => View();
    }
}
