using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasosUso;
using Dominio.InterfacesRepositorio;
using WebMVC.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace WebMVC.Controllers
{
    public class PlantasController : Controller
    {

        public IManejadorPlanta ManejadorPlanta { get; set; }

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public PlantasController(IManejadorPlanta manejadorPlanta)
        {
            ManejadorPlanta = manejadorPlanta;
        }

        public IActionResult Plantas()
        {
            return View();
        }

        // GET: PlantaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlantaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlantaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantaController/Create
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

        // GET: PlantaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlantaController/Edit/5
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

        // GET: PlantaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlantaController/Delete/5
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
