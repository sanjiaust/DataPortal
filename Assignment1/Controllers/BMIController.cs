using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        public ActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateBMI(BMIViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("BMICalculator", model);
            }

            // Calculate BMI
            double heightInMeters = ((model.Feet * 12) + model.Inches) * 0.0254;
            double bmi = model.Weight / (heightInMeters * heightInMeters);

            ViewBag.BMI = bmi;

            return View("BMICalculator", model);
        }
    }
}
