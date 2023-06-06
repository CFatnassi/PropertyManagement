using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IRealEstateRepo
    {
        void Add(RealEstate ObjToSave);
        void Update(RealEstate ObjtToUpdate);
        void Delete(Guid guid);
        RealEstate GetMyRealEstate(Guid guid);
        IEnumerable<RealEstate> getAll();
    }
}