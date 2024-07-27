using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Username and password are required.";
                return View();
            }

            if (username == "sanji" && password == "sanji51")
            {
                Session["UserId"] = username;
                return RedirectToAction("Index", "Details");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password!";
                return View();
            }
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            Session["UserId"] = null;
            return RedirectToAction("Login");
        }
    }
}
