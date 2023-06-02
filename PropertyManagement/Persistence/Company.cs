using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class Company : ICompany
    {
        private readonly ApplicationDbContext _context;

        public Company (ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Models.Company ObjToSave)
        {
            _context.Companys.Add(ObjToSave);
        }

        public void Delete(Guid guid)
        {
            var D = _context.Companys.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.Companys.Remove(D);
            }
        }

        public Models.Company GetMyCompany(Guid guid)
        {
            return _context.Companys.FirstOrDefault(m => m.Guid == guid);
        }

        public void Update(Models.Company ObjtToUpdate)
        {
            var D = _context.Companys.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
                D.Name = ObjtToUpdate.Name;
                D.Adress = ObjtToUpdate.Adress;
                D.Country = ObjtToUpdate.Country;
                D.Email = ObjtToUpdate.Email;
             

            }
        }
    }
}