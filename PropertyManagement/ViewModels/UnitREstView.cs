using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.ViewModels
{
    public class UnitREstView
    {
        public int Id { get; set; }

        
        public int FUnitKindId { get; set; }
        public Guid Guid { get; set; }
        public Guid FRealEstGuid { get; set; }
        public String NickName { get; set; }

        public float AreaSize { get; set; }
        public String Room { get; set; }
        public String Bathroom { get; set; }
        public String Kitchen { get; set; }

        public IEnumerable<RealEstate>RealEstates{get; set; }
        public int RealEstateId { get; set; }

    }
}