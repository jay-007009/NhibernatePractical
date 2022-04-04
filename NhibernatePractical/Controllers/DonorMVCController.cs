using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Controllers
{
    public class DonorMVCController : Controller
    {

        private readonly IDonorBLL _donorServices;

        public DonorMVCController(IDonorBLL donorServices)
        {
            _donorServices = donorServices;
        }
        // GET: DonorMVCController
        public ActionResult Index()
        {
            return View(_donorServices.GetAllDonor());
        }

        // GET: DonorMVCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonorMVCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonorMVCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DonorDTO donor)
        {
            try
            {
                _donorServices.CreateDonor(donor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonorMVCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonorMVCController/Edit/5
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

        // GET: DonorMVCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_donorServices.GetDonorWithId(id));
        }

        // POST: DonorMVCController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, DonorDTO donor)
        {
            try
            {
                _donorServices.DeleteDonor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
