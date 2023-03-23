using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TempManager.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ch11Ex1TempManager.Controllers
{
    public class HomeController : Controller
    {
        private UserManagerContext data { get; set; }
        private Errors Errors { get; set; }
        public HomeController(UserManagerContext ctx) => data = ctx;

        public bool isEmpty()
        {
            return data.Temps.Count() == 0;
        }

        public bool isFull()
        {
            return data.Temps.Count() == 10;
        }

        //Index

        public ActionResult IndexViewData()
        {
            ViewData["Errors"] = Errors.checkedEmpty;
            ViewData["Errors"] = Errors.checkedfull;
            return View();
        }

        public ViewResult Index()
        {
            var temps = data.Temps.OrderBy(t => t).ToList();
            return View(temps);
        }

        //Add

        [HttpGet]
        [Authorize]
        public ViewResult Add()
        {
            return View(new Temp());
        }

        public RedirectToActionResult tryAdd()
        {
            if (!isFull())
            {
                return RedirectToAction("Add");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Temp temp, Histories History)
        {
            var tempExists = data.Temps.FirstOrDefault(t => t.FoodName == temp.FoodName);

            if(tempExists == null) //check for duplicates
            {
                if (ModelState.IsValid) //check if everything else is valid
                {
                    data.Temps.Add(temp);
                    data.History.Add(History);
                    data.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Please correct all errors.");
                    return View(temp);
                }
            }
            else
            {
                ModelState.AddModelError("", "Name already exists.");
                ModelState.AddModelError("", "Please correct all errors.");
                return View(temp);
            }
        }

        //Add Saved item

        [HttpGet]
        [Authorize]
        public ViewResult AddSaved()
        {
            //List<Histories> HistoriesList = new List<Histories>();
            var HistoriesList = data.History.OrderBy(t => t).ToList();
            ViewBag.L = HistoriesList;

            var savedItems = data.History.OrderBy(t => t).ToList();
            return View(new Histories());
        }


        [HttpPost]
        public ActionResult AddSavedValue(Temp temp)
        {
            var History = data.History.OrderBy(t => t.FoodName);
            var tempExists = data.Temps.FirstOrDefault(t => t == History);

            if (tempExists == null) //check for duplicates
            {
                data.Temps.Add(temp);
                //data.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AddSaved");
            }
        }

        //Delete

        [HttpGet]
        [Authorize]
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

        //Delete All

        [HttpGet]
        public ViewResult DeleteAll()
        {
            var temps = data.Temps.OrderBy(t => t).ToList();            
            return View(temps);            
        }

        [Authorize]
        public RedirectToActionResult tryDeleteAll()
        {
            if(!isEmpty())
            {
                return RedirectToAction("DeleteAll");
            }
            return RedirectToAction("Index");
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

        //Edit
        [Authorize]
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
            var tempExists = data.Temps.FirstOrDefault(t => t.FoodName == temp.FoodName);
            if (tempExists == null || tempExists.FoodName == temp.FoodName) //check for duplicates
            {
                if (ModelState.IsValid) //check if everything else is valid
                {
                    if(tempExists != null)
                    {
                        data.Remove(tempExists);
                        data.Add(temp);
                    }
                    else
                        data.Update(temp);

                    data.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Please correct all errors.");
                    return View(temp);
                }
            }
            else
            {
                ModelState.AddModelError("", "Name already exists.");
                ModelState.AddModelError("", "Please correct all errors.");
                return View(temp);
            }

        }
        
        //Denied
        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }

        //Login

        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> validate(string username, string password, string returnUrl)
        {
            //if incorrect the Login ubove is expecting a returnUrl so this is nessesary
            ViewData["ReturnUrl"] = returnUrl;

            var temps = data.User.OrderBy(t => t).ToList();
            bool isMatch = false;
            string name = "";
            for(int i = 0; i < temps.Count(); i++)
            {
                if (username == temps.ElementAt(i).UserName && password == temps.ElementAt(i).Password)
                {
                    name = temps.ElementAt(i).Name;
                    isMatch = true;
                    break;
                }
            }
            //check if username and password match
            if(isMatch == true)
            {
                /*
                 * claims are properties that describe the user.
                 */ 
                var claims = new List<Claim>();

                //add claims to the user
                claims.Add(new Claim("username", username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, name));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                //redirect to another page
                return Redirect(returnUrl);
            }
            TempData["Error"] = "Error. Username or Password is invalid";
            //send back to login page if incorrect
            return View("login");
        }

        //logout

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        //Sign In

        [HttpGet]
        public ViewResult SignIn() => View(new Users());

        [HttpPost]
        public async Task<IActionResult> SignIn(Users temp)
        {
            if (ModelState.IsValid)
            {
                data.User.Add(temp);
                data.SaveChanges();

                //log the user in
                string returnUrl = "/home/index";

                var claims = new List<Claim>();

                //add claims to the user
                claims.Add(new Claim("username", temp.UserName));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, temp.UserName));
                claims.Add(new Claim(ClaimTypes.Name, temp.Name));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                //redirect to another page
                return Redirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors.");
                return View(temp);
            }
        }

        //Secured
        [Authorize(Roles ="Admin")]
        public IActionResult Secured()
        {
            return View();
        }
    }
}
