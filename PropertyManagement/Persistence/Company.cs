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
            _context.Companies.Add(ObjToSave);
        }

        public void Delete(Guid? guid)
        {
            var D = _context.Companies.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.Companies.Remove(D);
            }
        }

        public Models.Company GetMyCompany(Guid? guid)
        {
            return _context.Companies.FirstOrDefault(m => m.Guid == guid);
        }
        public IEnumerable<Models.Company> getAll()
        {
            return _context.Companies.ToList();
        }

        public void Update(Models.Company ObjtToUpdate)
        {
            var D = _context.Companies.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
                D.Id = ObjtToUpdate.Id;
                D.Name = ObjtToUpdate.Name;
                D.Email = ObjtToUpdate.Email;
                D.Adress = ObjtToUpdate.Adress;
                D.Guid = ObjtToUpdate.Guid;
                D.Status = ObjtToUpdate.Status;
                D.Logo = ObjtToUpdate.Logo;
                D.Country = ObjtToUpdate.Country;
                D.UserId = ObjtToUpdate.UserId;
                D.CreateDate = ObjtToUpdate.CreateDate;            

            }
        }
    }
}