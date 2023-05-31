using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class RealEstate
    {
        public int Id { get; set; }
        public int FREKId { get; set; }
        public Guid Guid { get; set; }
        public Guid CoGuid { get; set; }
        public int UnitCount { get; set; }
        public String Location { get; set; }
        public String Code { get; set; }
        public String Details { get; set; }
    }
}