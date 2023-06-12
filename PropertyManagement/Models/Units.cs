using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Units
    {
        public int Id { get; set; }

        [Display(Name = "FUnitKindId", ResourceType = typeof(Resources.Resource))]
        public int FUnitKindId { get; set; }
        public Guid Guid { get; set; }

        [Display(Name = "FRealEstGuid", ResourceType = typeof(Resources.Resource))]
        public Guid FRealEstGuid { get; set; }
        public String NickName { get; set; }

        [Display(Name = "AreaSize", ResourceType = typeof(Resources.Resource))]
        public float AreaSize { get; set; }
        public String Room { get; set; }
        public String Bathroom { get; set; }
        public String Kitchen { get; set; }
    }
}