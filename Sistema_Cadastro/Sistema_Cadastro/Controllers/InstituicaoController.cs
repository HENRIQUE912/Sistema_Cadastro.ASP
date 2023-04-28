using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Cadastro.Controllers
{
    public class InstituicaoController : Controller
    {
        // GET: InstituicaoController
        public ActionResult Index()
        {
            return View( );
        }

        // GET: InstituicaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InstituicaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstituicaoController/Create
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

        // GET: InstituicaoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstituicaoController/Edit/5
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

        // GET: InstituicaoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InstituicaoController/Delete/5
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
