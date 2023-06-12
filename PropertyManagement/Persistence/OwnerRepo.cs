using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class OwnerRepo : IOwnerRepo
    {
        private readonly ApplicationDbContext _context;

        public OwnerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.Owner ObjToSave)
        {
            _context.Owners.Add(ObjToSave);
        }

        public void Delete(Guid guid)
        {
            var D = _context.Owners.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.Owners.Remove(D);
            }
        }

        public Models.Owner GetMyOwner(Guid guid)
        {
            return _context.Owners.FirstOrDefault(m => m.Guid == guid);
        }

        public void Update(Models.Owner ObjtToUpdate)
        {
            var D = _context.Owners.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
                D.FullName = ObjtToUpdate.FullName;
                D.Phone1 = ObjtToUpdate.Phone1;
                D.Phone2 = ObjtToUpdate.Phone2;
                D.Email = ObjtToUpdate.Email;
                D.Adress = ObjtToUpdate.Adress;


            }
        }
        public IEnumerable<Models.Owner> getAll()
        {
            return _context.Owners.ToList();
        }
    }
}