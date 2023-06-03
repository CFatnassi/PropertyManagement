using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IUnitOfWork
    {
         ICompany Company { get;}
         IUnit Unit { get;}
         IOwner Owner { get;}
         IRealEstate RealEstate { get;}
         IRealEstateKind RealEstateKind { get;}
         IRentKind RentKind { get;}
         IUnitKind UnitKind { get;}


        void Complete();
    }
}