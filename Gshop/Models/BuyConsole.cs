using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class BuyConsole
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Seleccione el nombre de un cliente.")]
        [Display(Name = "Nombre del Cliente")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Seleccione el nombre de la consola.")]
        [Display(Name = "Nombre de la consola")]
        public int ConsoleId { get; set; }
        public Console Console { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name = "Cantidad")]
        public int Stock { get; set; }

        [Display(Name = "Total")]
        public long Amount { get; set; }
    }
}