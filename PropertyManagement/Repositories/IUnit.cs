using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PropertyManagement.Repositories
{
    public interface IUnit
    {
        void Add(Unit ObjToSave);
        void Update(Unit ObjtToUpdate);
        void Delete(Guid guid);
        Unit GetMyUnits(Guid guid);
    }
}