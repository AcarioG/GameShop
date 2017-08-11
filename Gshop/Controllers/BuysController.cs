using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gshop.Models;
using Gshop.ViewModels;
using System.Data.Entity;

namespace Gshop.Controllers
{
    public class BuysController : Controller
    {
        private ApplicationDbContext _context;

        public BuysController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Buys
        public ActionResult Manager()
        {
            var customers = _context.Customers.ToList();
            var games = _context.Games.ToList();
            var consoles = _context.Consoles.ToList();

            var viewModel = new BuyGameViewModel
            {
                BuyGame = new BuyGame(),
                Customers = customers,
                Consoles = consoles,
                Games = games
            };

            return View(viewModel);
        }

        public ActionResult BuyList()
        {
            var customers = _context.Customers.ToList();
            var games = _context.Games.ToList();
            var consoles = _context.Consoles.ToList();
            var genres = _context.Genres.ToList();
            var buygames = _context.BuyGames.ToList().OrderByDescending(x => x.Id);
            var buyconsoles = _context.BuyConsoles.ToList().OrderByDescending(x => x.Id);

            var viewModel = new BuyListViewModel
            {
                Customers = customers,
                Games = games,
                Consoles = consoles,
                Genres = genres,
                BuyGames = buygames,
                BuyConsoles = buyconsoles
            };

            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult MakeBuy(BuyGame buygame)
        {

            if (!ModelState.IsValid)
            {

                return View("Manager", buygame);
            }

            var viewModel = new BuyGame2ViewModel
            {
                BuyGame = new BuyGame(),
                Customer = _context.Customers.Single(c => c.Id == buygame.CustomerId),
                Game = _context.Games.Single(c => c.Id == buygame.GameId),
                Genres = _context.Genres.ToList(),
                Consoles = _context.Consoles.ToList(),
                MembershipTypes = _context.MembershipTypes.ToList()

            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(BuyGame buygame)
        {
            
            buygame.DateAdded = DateTime.Now;

            _context.BuyGames.Add(buygame);

            var game = _context.Games.SingleOrDefault(x => x.Id == buygame.GameId);

            if (game.Stock != 0)
            {
                game.Stock = game.Stock - buygame.Stock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        //Console Options

        [ValidateAntiForgeryToken]
        public ActionResult MakeBuyC(BuyConsole buyconsole)
        {

            if (!ModelState.IsValid)
            {

                return View("Manager", buyconsole);
            }

            var viewModel = new BuyConsoleViewModel
            {
                BuyConsole = new BuyConsole(),
                Console = _context.Consoles.Single(c=> c.Id == buyconsole.ConsoleId),
                Customer = _context.Customers.Single(c => c.Id == buyconsole.CustomerId),
                MembershipTypes = _context.MembershipTypes.ToList()

            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveC(BuyConsole buyconsole)
        {

            buyconsole.DateAdded = DateTime.Now;

            _context.BuyConsoles.Add(buyconsole);

            var console = _context.Consoles.SingleOrDefault(x => x.Id == buyconsole.ConsoleId);

            if (console.Stock != 0)
            {
                console.Stock = console.Stock - buyconsole.Stock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

    }
}
