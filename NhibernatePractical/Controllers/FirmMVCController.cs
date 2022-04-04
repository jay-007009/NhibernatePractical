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
    public class FirmMVCController : Controller
    {

        private readonly IFirmBLL _firmServices;

        public FirmMVCController(IFirmBLL firmServices)
        {
            _firmServices = firmServices;
        }
        // GET: FirmMVCController
        public ActionResult Index()
        {
            TempData["Message"] = "Welcome";
            return View(_firmServices.GetAll());
        }

        // GET: FirmMVCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FirmMVCController/Create
        public ActionResult Create()
        {
            return View(_firmServices.GetCity());
        }

        // POST: FirmMVCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FirmDTO firms)
        {
            try
            {
                var result = _firmServices.Create(firms);
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
            return View(_firmServices.GetWithId(id));
        }

        // POST: FirmMVCController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] FirmDTO firm)
        {
            try
            {
                _firmServices.Update(id, firm);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Edit));
            }
        }

        // GET: FirmMVCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_firmServices.GetWithId(id));
        }

        // POST: FirmMVCController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FirmDTO firm)
        {
            try
            {
                _firmServices.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Delete));
            }
        }
    }
}
