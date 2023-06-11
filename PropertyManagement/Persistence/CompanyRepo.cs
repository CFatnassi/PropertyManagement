using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add( Company ObjToSave)
        {
            _context.Companies.Add(ObjToSave);
        }

        public void Delete(Guid  guid)
        {
            var D = _context.Companies.FirstOrDefault(m => m.Guid == guid);
            if (D != null)
            {
                _context.Companies.Remove(D);
            }
        }

        public  Company GetMyCompany(Guid guid)
        {
            return _context.Companies.FirstOrDefault(m => m.Guid == guid);
        }
        public IEnumerable<Company> GetAllCompany()
        {
            return _context.Companies.ToList();
        }

        public void Update( Company ObjtToUpdate)
        {
            var D = _context.Companies.FirstOrDefault(m => m.Guid == ObjtToUpdate.Guid);
            if (D != null)
            {
               
                D.Name = ObjtToUpdate.Name;
                D.Email = ObjtToUpdate.Email;
                D.Adress = ObjtToUpdate.Adress;
             
                D.Status = ObjtToUpdate.Status;
             
                D.Country = ObjtToUpdate.Country;
           
                      

            }
        }
    }
}