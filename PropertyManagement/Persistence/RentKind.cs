using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class RentKind : IRentKind
    {
        private readonly ApplicationDbContext _context;

        public RentKind(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.RentKind ObjToSave)
        {
            _context.RentKinds.Add(ObjToSave);
        }

        public void Delete(int id)
        {
            var D = _context.RentKinds.FirstOrDefault(m => m.Id == id);
            if (D != null)
            {
                _context.RentKinds.Remove(D);
            }
        }

        public Models.RentKind GetMyRentKind(int id)
        {
            return _context.RentKinds.FirstOrDefault(m => m.Id == id);
        }

        public void Update(Models.RentKind ObjtToUpdate)
        {
            var D = _context.RentKinds.FirstOrDefault(m => m.Id == ObjtToUpdate.Id);
            if (D != null)
            {
                D.ArName = ObjtToUpdate.ArName;
                D.EngName = ObjtToUpdate.EngName;
                D.Code = ObjtToUpdate.Code;             
            }
        }
        public IEnumerable<Models.RentKind> getAll()
        {
            return _context.RentKinds.ToList();
        }
    }
}