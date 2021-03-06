

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Controllers
{
    public class LoginMVCController : Controller
    {
        private readonly ILoginBLL _userServices;

        public LoginMVCController(ILoginBLL userServices)
        {
            _userServices = userServices;
        }


        // GET: LoginMVCController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginMVCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginMVCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginMVCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] string userName, string userPassword)
        {
            try
            {
                if (_userServices.CheckUserActive(userName, userPassword))
                {
                    if (userName == "Admin")
                    {
                        return Redirect("/Firm/Index");
                    }
                    else
                    {
                        return Redirect("/Donor/Index");
                    }

                }
                else
                {
                    TempData["Message"] = "User Was Not Active";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

      

        // POST: LoginMVCController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {
            try
            {
                _userServices.CheckIsActive(id);
                return Redirect("/Firm/Index");
            }
            catch
            {
                return Redirect("/Firm/Index");
            }
        }

        // GET: LoginMVCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginMVCController/Delete/5
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
