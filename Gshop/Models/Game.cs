using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del juego.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Fecha de Registro")]
        public DateTime? DateAdded { get; set; }
        
        [Required(ErrorMessage = "Ingrese el precio.")]
        [Display(Name = "Precio")]
        public long Price { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de juegos.")]
        [Display(Name = "Cantidad")]
        public int Stock { get; set; }

        
        [Required(ErrorMessage = "Seleccione un genero.")]
        [Display(Name = "Género")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Seleccione una consola.")]
        [Display(Name = "Consola")]
        public int ConsoleId { get; set; }
        public Console Console { get; set; }

        [Url(ErrorMessage = "Ingrese una URL valida.")]
        [Display(Name = "Link de Imagen")]
        public string Link { get; set; }
    }
}