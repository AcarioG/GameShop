using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir tu nombre")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "El email debe tener el formarto ejemplo@correo.com.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe introducir un Telefono.")]
        [Phone(ErrorMessage = "Debe tener el siguite formato xxx-xxx-xxxx")]
        [Display(Name = "Telefono")]
        public string Telephone { get; set; }
        
        [Required(ErrorMessage = "Debe introducir tu direccicón.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Min18YearsIfAMember]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? BirthDay { get; set; }

        [Display(Name = "Tipo de Membresia")]
        [Required(ErrorMessage = "Selecciona un tipo de membresia")]
        public byte MembershipTypeId { get; set; }
        public MembershipType MembershioType { get; set; }
    }
}
/*
 * [RegularExpression("^([0-9]{3})(-[0-9]{3)(-[0-9]{4})$", ErrorMessage = "Ingrese un numero de formato Valido")]

[MaxLength(12, ErrorMessage = "Ingrese un numero de telefono válido.")]
[MinLength(10, ErrorMessage = "Ingrese un numero de telefono válido.")]
*/