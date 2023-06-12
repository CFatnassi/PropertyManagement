using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Providers;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class RealEstate
    {
        public int Id { get; set; }

        [Display( Name= "FREKId", ResourceType = typeof(Resources.Resource))]
        public int FREKId { get; set; }
        public Guid Guid { get; set; }
        public Guid CoGuid { get; set; }

        [Display(Name = "UnitCount", ResourceType = typeof(Resources.Resource))]
        public int UnitCount { get; set; }
        public String Location { get; set; }
        public String Code { get; set; }
        public String Details { get; set; }
    }
}