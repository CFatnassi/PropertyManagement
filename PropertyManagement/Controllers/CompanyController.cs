using PropertyManagement.Helpers;
using PropertyManagement.Models;
using PropertyManagement.Persistence;
using PropertyManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyManagement.Controllers
{
    public class CompanyController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: Company
        public ActionResult Index()
        {
            IEnumerable<Models.Company> obj = new List<Models.Company>();
            obj= _unitOfWork.Company.GetAllCompany();
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Models.Company company)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.Company.Add(company);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid guid)
        {
            Models.Company obj = _unitOfWork.Company.GetMyCompany(guid);
            return View(obj);

        }
        [HttpPost]
        public ActionResult Update(Models.Company obj)
        {
            Models.Company objToUpdate = _unitOfWork.Company.GetMyCompany(obj.Guid);
            _unitOfWork.Company.Update(objToUpdate);
           
            _unitOfWork.Complete();
            return RedirectToAction("Index");

        }
       
        
        public ActionResult Delete(Guid guid)
        {
            Models.Company obj = _unitOfWork.Company.GetMyCompany(guid);
            
            _unitOfWork.Company.Delete(guid);
            _unitOfWork.Complete();
            return View(obj);

        }

    }
}