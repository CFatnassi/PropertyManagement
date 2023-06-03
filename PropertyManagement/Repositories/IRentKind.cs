using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IRentKind
    {
        void Add(RentKind ObjToSave);
        void Update(RentKind ObjtToUpdate);
        void Delete(int id);
        RentKind GetMyRentKind(int id);
    }
}