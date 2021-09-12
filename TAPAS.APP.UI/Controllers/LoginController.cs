using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAPAS.APP.UI.Models;


namespace TAPAS.APP.UI.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public IActionResult Authenticate(LoginDetailsViewModel loginDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                var User = DataStore.UserServiceClient.RegisteredUsers.AsQueryable().Where(q => q.UserName.Equals(loginDetailsViewModel.UserName)
                 && q.Password.Equals(loginDetailsViewModel.Password)).FirstOrDefault();

                if (User != null)
                {
                    TempData["LoggedInUser"] = User.UserName;
                    return RedirectToAction("Dashboard", "Home");
                }
               

                ModelState.AddModelError("InvalidCredentials", "Username/TenanId/Password combination is not valid.");
            }

            return RedirectToAction("~/Views/Home/Index.cshtml", loginDetailsViewModel);
        }
        [HttpGet]
        public IActionResult Authenticate()
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Authenticate(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
