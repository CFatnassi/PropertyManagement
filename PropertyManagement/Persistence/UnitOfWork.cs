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

        public ICompanyRepo Company { get; private set; }
        public IUnitRepo Unit { get; private set; }
        public IOwnerRepo Owner { get; private set; }
        public IRealEstateRepo RealEstate { get; private set; }
        public IRealEstateKindRepo RealEstateKind { get; private set; }
        public IRentKindRepo RentKind { get; private set; }
        public IUnitKind UnitKind { get; private set; }
        
        
        public UnitOfWork(ApplicationDbContext context)
        {
            
            _context = context;
            Company = new CompanyRepo(context);
            Unit = new UnitRepo(context);
            Owner = new OwnerRepo(context);
            RealEstate = new RealEstateRepo(context);
            RealEstateKind = new RealEstateKind(context);
            UnitKind = new UnitKindRepo(context);
            RentKind = new RentKindRepo(context);

        }

        

        public void Complete()
        {
            _context.SaveChanges();
        }




    }
}