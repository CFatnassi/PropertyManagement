using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IUnitKind
    {
        void Add(UnitKind ObjToSave);
        void Update(UnitKind ObjtToUpdate);
        void Delete(int id);
        UnitKind GetMyUnitKind(int id);
        IEnumerable<UnitKind> getAll();

    }
}