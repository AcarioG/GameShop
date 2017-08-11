using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class BuyGameViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Models.Console> Consoles { get; set; }
        public BuyGame BuyGame { get; set; }
        public BuyConsole BuyConsole { get; set; }
    }
}