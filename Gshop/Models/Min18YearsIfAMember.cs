using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gshop.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknow 
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDay == null)
                return new ValidationResult("Se requiere una fecha.");

            var age = DateTime.Today.Year - customer.BirthDay.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("El cliente debe tener al menos 18 años de edad.");
        }
    }
}