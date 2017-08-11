using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class BuyListViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Models.Console> Consoles { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<BuyConsole> BuyConsoles { get; set; }
        public IEnumerable<BuyGame> BuyGames { get; set; }
    }
}