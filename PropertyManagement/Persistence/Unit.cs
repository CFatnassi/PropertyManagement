using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class Unit : IUnit
    {
        private readonly ApplicationDbContext _context;

        public Unit(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.Unit ObjToSave)
        {
            _context.Units.Add(ObjToSave);
        }

        public void Delete(Guid guid)
        {
            var D = _context.Units.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.Units.Remove(D);
            }
        }

        public Models.Unit GetMyUnits(Guid guid)
        {
            return _context.Units.FirstOrDefault(m => m.Guid == guid);
        }

        public void Update(Models.Unit ObjtToUpdate)
        {
            var D = _context.Units.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
                D.NickName = ObjtToUpdate.NickName;
                D.AreaSize = ObjtToUpdate.AreaSize;
                D.Room = ObjtToUpdate.Room;
                D.Bathroom = ObjtToUpdate.Bathroom;
                D.Kitchen = ObjtToUpdate.Kitchen;


            }
        }
    }
}