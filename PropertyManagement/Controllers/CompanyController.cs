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
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


    }
}