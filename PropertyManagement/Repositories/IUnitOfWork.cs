using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IUnitOfWork
    {
         ICompanyRepo Company { get;}
        IUnitRepo Unit { get; }
        IOwnerRepo Owner { get;}
         IRealEstateRepo RealEstate { get;}
         IRealEstateKindRepo RealEstateKind { get;}
         IRentKindRepo RentKind { get;}
         IUnitKind UnitKind { get;}


        void Complete();
    }
}