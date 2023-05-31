using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Company
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Adress { get; set; }
        public Guid Guid { get; set; }
        public String Status { get; set; }
        public String Logo { get; set; }
        public String Country { get; set; }
    }
}