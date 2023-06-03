using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class RealEstate : IRealEstate
    {
        private readonly ApplicationDbContext _context;

        public RealEstate(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.RealEstate ObjToSave)
        {
            _context.RealEstates.Add(ObjToSave);
        }

        public void Delete(Guid guid)
        {
            var D = _context.RealEstates.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.RealEstates.Remove(D);
            }
        }

        public Models.RealEstate GetMyRealEstate(Guid guid)
        {
            return _context.RealEstates.FirstOrDefault(m => m.Guid == guid);
        }

        public void Update(Models.RealEstate ObjtToUpdate)
        {
            var D = _context.RealEstates.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
                D.UnitCount = ObjtToUpdate.UnitCount;
                D.Location = ObjtToUpdate.Location;
                D.Code = ObjtToUpdate.Code;
                D.Details = ObjtToUpdate.Details;


            }
        }
    }
}