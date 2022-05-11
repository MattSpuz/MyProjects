using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext data { get; set; }
        public ValidationController(TempManagerContext ctx) => data = ctx;


        public JsonResult CheckName(string date)
        {
            //DateTime dt = DateTime.Parse(date);
            Temp temp = data.Temps.FirstOrDefault(t => t.FoodName == date);

            if (temp == null)
                return Json(true);
            else
                return Json($"{date} is already in the database");
        }
    }
}
