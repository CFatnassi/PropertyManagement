using PropertyManagement.Models;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICompany Company { get; private set; }
        public IUnit Unit { get; private set; }
        
        
        public UnitOfWork(ApplicationDbContext context)
        {
            
            _context = context;
            Company = new Company(context);
            Unit = new Unit(context);

        }

        

        public void Complete()
        {
            _context.SaveChanges();
        }




    }
}