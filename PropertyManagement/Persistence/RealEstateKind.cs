using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class RealEstateKind : IRealEstateKindRepo
    {
        private readonly ApplicationDbContext _context;

        public RealEstateKind(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.RealEstateKind ObjToSave)
        {
            _context.RealEstateKinds.Add(ObjToSave);
        }

        public void Delete(int id)
        {
            var D = _context.RealEstateKinds.FirstOrDefault(m => m.Id == id);
            if (D != null)
            {
                _context.RealEstateKinds.Remove(D);
            }
        }

        public Models.RealEstateKind GetMyRealEstateKind(int id )
        {
            return _context.RealEstateKinds.FirstOrDefault(m => m.Id == id);
        }

        public void Update(Models.RealEstateKind ObjtToUpdate)
        {
            var D = _context.RealEstateKinds.FirstOrDefault(m => m.Id == ObjtToUpdate.Id);
            if (D != null)
            {
                D.ArName = ObjtToUpdate.ArName;
                D.EngName = ObjtToUpdate.EngName;
                D.Code = ObjtToUpdate.Code;
               


            }
        }
        public IEnumerable<Models.RealEstateKind> getAll()
        {
            return _context.RealEstateKinds.ToList();
        }
    }
}