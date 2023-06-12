using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public Guid Guid { get; set; }
        public int Status { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }

        public string UserId { get; set; }

        [Display(Name = "CreateDate", ResourceType = typeof(Resources.Resource))]
        public DateTime CreateDate { get; set; }
         
    }
}