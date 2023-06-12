using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class UnitKindRepo : IUnitKindRepo
    {
        private readonly ApplicationDbContext _context;

        public UnitKindRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.UnitKind ObjToSave)
        {
            _context.UnitKinds.Add(ObjToSave);
        }

        public void Delete(int id)
        {
            var D = _context.UnitKinds.FirstOrDefault(m => m.Id == id);
            if (D != null)
            {
                _context.UnitKinds.Remove(D);
            }
        }

        public Models.UnitKind GetMyUnitKind(int id)
        {
            return _context.UnitKinds.FirstOrDefault(m => m.Id == id);
        }

        public void Update(Models.UnitKind ObjtToUpdate)
        {
            var D = _context.UnitKinds.FirstOrDefault(m => m.Id == ObjtToUpdate.Id);
            if (D != null)
            {
                D.ArName = ObjtToUpdate.ArName;
                D.EngName = ObjtToUpdate.EngName;
                


            }
        }
        public IEnumerable<Models.UnitKind> getAll()
        {
            return _context.UnitKinds.ToList();
        }
    }
}