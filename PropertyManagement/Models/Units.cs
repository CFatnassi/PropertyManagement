using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Units
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
    }
}