using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class GameFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Models.Console> Consoles { get; set; }
        public Game Game { get; set; }
    }
}