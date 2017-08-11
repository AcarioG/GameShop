using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class BuyGame2ViewModel
    {

        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Models.Console> Consoles { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public BuyGame BuyGame { get; set; }
        public Customer Customer { get; set; }
        public Game Game { get; set; }
    }
}