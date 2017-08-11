using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class Console
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la consola.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la compañia.")]
        [Display(Name = "Compañia")]
        public string Company { get; set; }
        
        [Display(Name = "Fecha de Registro")]
        public DateTime? DateAdded  { get; set; }

        [Required(ErrorMessage = "Ingrese el precio.")]
        [Display(Name = "Precio")]
        public long Price { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de consolas.")]
        [Display(Name = "Cantidad")]
        public int Stock { get; set; }

    }
}