using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Project_2__Dimensions_Data.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;
using Project_2__Dimensions_Data.Models;
using Microsoft.AspNetCore.Identity;


namespace Project_2__Dimensions_Data.Controllers
{
         [Authorize(Roles = "user")]
        public class EmployeeController : Controller
        {    // GET: Controller
            public ActionResult Index()
            {
                return View();
            }

            [Authorize(Roles = "admin")]
            public ActionResult Auth()
            {
                return View();
            }
            [Authorize(Roles = "manager")]
            public ActionResult ManagerTest()
            {
                return View();
            }

            public async Task<ActionResult> ViewDataTestAsync()
            {
               
                return View();
            }

            [Authorize]
            public ActionResult AuthController()
            {
                return View();
            }

            public ActionResult Auth()
            {
                return RedirectToAction("Index");
            }

            // POST: Controller/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(IFormCollection collection)
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

            // GET: Controller/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: Controller/Edit/5
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

            // GET: Controller/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Controller/Delete/5
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
}
