using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gshop.Models;

namespace Gshop.ViewModels
{
    public class CustomerIndexViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}