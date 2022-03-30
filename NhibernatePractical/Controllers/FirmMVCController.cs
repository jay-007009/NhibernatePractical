using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Controllers
{
    public class FirmMVCController : Controller
    {

        private readonly IFirm _firmServices;

        public FirmMVCController(IFirm firmServices)
        {
            _firmServices = firmServices;
        }
        // GET: FirmMVCController
        public ActionResult Index()
        {
            return View(_firmServices.GetAllFirm());
        }

        // GET: FirmMVCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FirmMVCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirmMVCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FirmDTO firms)
        {
            try
            {
                var result = _firmServices.CreateFirm(firms);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: FirmMVCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FirmMVCController/Edit/5
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

        // GET: FirmMVCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FirmMVCController/Delete/5
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
