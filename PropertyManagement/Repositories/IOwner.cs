using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IOwner
    {
        void Add(Owner ObjToSave);
        void Update(Owner ObjtToUpdate);
        void Delete(Guid guid);
        Owner GetMyOwner(Guid guid);
    }
}