using CRUD_Application.Data;
using CRUD_Application.Models.Account;
using CRUD_Application.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD_Application.Controllers.Account
{
    public class AccountController : Controller
    {
        public readonly ApplicationContext context;
        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //get method
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginSignUpViewModel model)
        {
            return View();
        }
        [AcceptVerbs("Post","Get")]
        public IActionResult UserNameIsExist(string userName)
        {
            var data = context.Users.Where(e => e.UserName == userName).SingleOrDefault();
            if(data != null)
            {
                return Json($"Username{userName} already in use!");

            }
            else
            {
                return Json(true);
            }
        }
        //get method
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.Mobile,
                    IsActive = model.IsActive,



                };
                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "you are elligible to login, please fill own credential's then login!!";
                return RedirectToAction("Login");
            }
            else
            {
                TempData["errorMessage"] = "Empty form can't be submit";
                return View(model);
            }
            
        }
    }
}
