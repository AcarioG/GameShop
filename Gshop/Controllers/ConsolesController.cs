using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gshop.Models;

namespace Gshop.Controllers
{
    public class ConsolesController : Controller
    {
        private ApplicationDbContext _context;

        public ConsolesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Consoles
        public ActionResult Index()
        {
            var consoles = _context.Consoles.ToList();

            return View(consoles);
        }

        public ViewResult Details(int id)
        {
            var consoles = _context.Consoles.SingleOrDefault(c => c.Id == id);


            return View(consoles);
        }

        public ViewResult ConsoleForm()
        {
            var console = new Models.Console();

            return View(console);
        }

        public ActionResult Edit(int id)
        {

            var console = _context.Consoles.SingleOrDefault(c => c.Id == id);

            if (console == null)
                return HttpNotFound();
            
            return View("ConsoleForm", console);
        }

        public ActionResult Delete(int id)
        {
            var ConsoleInDb = _context.Consoles.Single(c => c.Id == id);

            _context.Consoles.Remove(ConsoleInDb);

            _context.SaveChanges();

            return RedirectToAction("index", "Consoles");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Models.Console console)
        {

            if (!ModelState.IsValid)
            {

                return View("ConsoleForm", console);
            }

            if (console.Id == 0)
            {
                console.DateAdded = DateTime.Now;
                _context.Consoles.Add(console);

            }
            else
            {
                var ConsoleInDb = _context.Consoles.Single(c => c.Id == console.Id);

                ConsoleInDb.Name = console.Name;
                ConsoleInDb.Company = console.Company;
                ConsoleInDb.Price = console.Price;
                ConsoleInDb.Stock = console.Stock;

            }
            _context.SaveChanges();

            return RedirectToAction("index", "Consoles");
        }
    }
}