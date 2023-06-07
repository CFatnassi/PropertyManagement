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
    public class CompaniesController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: Companies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateNew()
        {

            return View();

        }
    }
}