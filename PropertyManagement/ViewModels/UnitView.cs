using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertyManagement.ViewModels
{
    public class UnitView
    {
        public int Id { get; set; }

        [Display(Name = "UnitKind", ResourceType = typeof(Resources.Resource))]
        public int FUnitKindId { get; set; }
        public Guid Guid { get; set; }
        public Guid FRealEstGuid { get; set; }
        public String NickName { get; set; }
        public float AreaSize { get; set; }
        public String Room { get; set; }
        public String Bathroom { get; set; }
        public String Kitchen { get; set; }

        public IEnumerable<UnitKind> UnitKinds { get; set; }
       
    }
}