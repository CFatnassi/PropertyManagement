using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Repositories
{
    public interface IUnitOfWork
    {
         ICompany Company { get;}


        void Complete();
    }
}