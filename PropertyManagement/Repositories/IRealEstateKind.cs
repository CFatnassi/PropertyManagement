using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IRealEstateKind
    {
        void Add(RealEstateKind ObjToSave);
        void Update(RealEstateKind ObjtToUpdate);
        void Delete(int id);
        RealEstateKind GetMyRealEstateKind(int id);
    }
}