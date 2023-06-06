using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PropertyManagement.Repositories
{
    public interface IUnitRepo
    {
        void Add(Units ObjToSave);
        void Update(Units ObjtToUpdate);
        void Delete(Guid guid);
        Units GetMyUnits(Guid guid);
        IEnumerable<Units> getAll();

    }
}