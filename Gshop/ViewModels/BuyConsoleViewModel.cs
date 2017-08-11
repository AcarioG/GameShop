using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class BuyConsoleViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public BuyConsole BuyConsole { get; set; }
        public Customer Customer { get; set; }
        public Models.Console Console { get; set; }
    }
}