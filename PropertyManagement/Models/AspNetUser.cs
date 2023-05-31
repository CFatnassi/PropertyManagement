using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class AspNetUser
    {
        public int Id { get; set; }
        public String UserKind { get; set; }
        public Guid CoGuid { get; set; }
    }
}