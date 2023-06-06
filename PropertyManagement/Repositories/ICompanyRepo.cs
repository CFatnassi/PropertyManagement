using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface ICompanyRepo
    {
        void Add(Company ObjToSave);
        void Update(Company ObjtToUpdate);
        void Delete(Guid guid);
        Company GetMyCompany(Guid guid);
        IEnumerable<Company> GetAllCompany();
     
        
        

    }
}