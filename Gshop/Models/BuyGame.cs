using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class BuyGame
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Seleccione el nombre de un cliente.")]
        [Display(Name = "Nombre del Cliente")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Seleccione el nombre de un juego.")]
        [Display(Name = "Nombre del Juego")]
        public int GameId { get; set; }
        public Game Game { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Cantidad")]
        public int Stock { get; set; }

        [Display(Name = "Total")]
        public long Amount { get; set; }
    }
}