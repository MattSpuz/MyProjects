using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private UserManagerContext data { get; set; }
        public ValidationController(UserManagerContext ctx) => data = ctx;


        public JsonResult CheckName(string date)
        {
            Temp temp = data.Temps.FirstOrDefault(t => t.FoodName == date);

            if (temp == null)
                return Json(true);
            else
                return Json($"{date} is already in the database");
        }
    }
}
