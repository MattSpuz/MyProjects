using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TempManager.Models;
using System.Threading.Tasks;

namespace Ch11Ex1TempManager.Controllers
{
    public class HomeController : Controller
    {
        private TempManagerContext data { get; set; }
        public HomeController(TempManagerContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var temps = data.Temps.OrderBy(t => t).ToList();
            return View(temps);
        }

        [HttpGet]
        public ViewResult Add() => View(new Temp());

        [HttpPost]
        public IActionResult Add(Temp temp)
        {
            if (ModelState.IsValid)
            {
                data.Temps.Add(temp);
                data.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors.");
                return View(temp);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var temp = data.Temps.Find(id);
            return View(temp);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Temp temp)
        {
            data.Remove(temp);
            data.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult DeleteAll()
        {
            var temps = data.Temps.OrderBy(t => t).ToList();
            return View(temps);
        }

        [HttpPost]
        public RedirectToActionResult DeleteAllF()
        {
            var temps = data.Temps.OrderBy(t => t).ToList();
            for (int i = temps.Count; i > 0; i--)
            {
                data.Remove(temps.ElementAt(i - 1));
            }
            data.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temp = await data.Temps.FindAsync(id);
            if (temp == null)
            {
                return NotFound();
            }
            return View(temp);
        }

        [HttpPost]
        public IActionResult Edit(int id, Temp temp)
        {
            //add replace it
            if (ModelState.IsValid)
            {
                data.Update(temp);
                data.SaveChanges();

                return RedirectToAction("Index");
            }
            //change nothing and return if needed
            else
            {
                ModelState.AddModelError("", "Please correct all errors.");
                return View(temp);
            }
        }


    }
}
