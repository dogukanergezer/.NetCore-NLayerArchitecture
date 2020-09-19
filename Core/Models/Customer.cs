using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public char[] IdentityNumber { get; set; }
        public string Country { get; set; }
        public char[] Phone { get; set; }
        public bool IsActive { get; set; }
    }
}
