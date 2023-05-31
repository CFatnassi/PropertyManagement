using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public String FullName { get; set; }
        public int IdentityID { get; set; }
        public int Phone1 { get; set; }
        public int Phone2 { get; set; }
        public String Email { get; set; }
        public String Adress { get; set; }
    }
}