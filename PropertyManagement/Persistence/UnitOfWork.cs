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
        public IUnitRepo Unit { get; private set; }
        public IOwner Owner { get; private set; }
        public IRealEstate RealEstate { get; private set; }
        public IRealEstateKind RealEstateKind { get; private set; }
        public IRentKind RentKind { get; private set; }
        public IUnitKind UnitKind { get; private set; }
        
        
        public UnitOfWork(ApplicationDbContext context)
        {
            
            _context = context;
            Company = new Company(context);
            Unit = new UnitRepo(context);
            Owner = new Owner(context);
            RealEstate = new RealEstate(context);
            RealEstateKind = new RealEstateKind(context);
            UnitKind = new UnitKind(context);
            RentKind = new RentKind(context);

        }

        

        public void Complete()
        {
            _context.SaveChanges();
        }




    }
}