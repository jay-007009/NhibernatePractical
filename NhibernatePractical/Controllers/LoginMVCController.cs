﻿

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Controllers
{
    public class LoginMVCController : Controller
    {
        private readonly ILogin _userServices;

        public LoginMVCController(ILogin userServices)
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

        // GET: LoginMVCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginMVCController/Edit/5
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