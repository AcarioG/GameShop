using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gshop.Models;
using Gshop.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Gshop.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Games
        public ActionResult Index()
        {
            var games = _context.Games.ToList();

            return View(games);
        }

        public ViewResult GameForm()
        {
            var genre = _context.Genres.ToList();
            var console = _context.Consoles.ToList();

            var viewModel = new GameFormViewModel
            {
                Game = new Game(),
                Genres = genre,
                Consoles = console

            };

            return View(viewModel);
        }

        public ActionResult Delete(int id)
        {
            var GameInDb = _context.Games.Single(c => c.Id == id);

            _context.Games.Remove(GameInDb);

            _context.SaveChanges();

            return RedirectToAction("index", "Games");

        }

        public ViewResult Details(int id)
        {
            var game = _context.Games.Include(c => c.Genre).Include(c => c.Console).SingleOrDefault(c => c.Id == id);


            return View(game);
        }

        public ActionResult Edit(int id)
        {

            var game = _context.Games.SingleOrDefault(c => c.Id == id);

            if (game == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel
            {
                Game = game,
                Genres = _context.Genres.ToList(),
                Consoles = _context.Consoles.ToList()

            };

            return View("GameForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Game game)
        {
            
            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel
                {
                    Game = game,
                    Genres = _context.Genres.ToList(),
                    Consoles = _context.Consoles.ToList()

                };
                return View("GameForm", viewModel);
            }

            if (game.Id == 0)
            {
                game.DateAdded = DateTime.Now;
                _context.Games.Add(game);

            }
            else
            {
                var GameInDb = _context.Games.Single(c => c.Id == game.Id);

                GameInDb.Name = game.Name;
                GameInDb.ReleaseDate = game.ReleaseDate;
                GameInDb.GenreId = game.GenreId;
                GameInDb.ConsoleId = game.ConsoleId;
                GameInDb.Price = game.Price;
                GameInDb.Stock = game.Stock;
                GameInDb.Link = game.Link;

            }
                _context.SaveChanges();
            

            return RedirectToAction("index", "Games");
        }
    }
}