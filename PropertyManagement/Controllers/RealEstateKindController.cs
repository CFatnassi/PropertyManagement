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
    public class RealEstateKindController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RealEstateKindController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: RealEstateKind
        public ActionResult Index()
        {
            IEnumerable<Models.RealEstateKind> obj = new List<Models.RealEstateKind>();
            obj = _unitOfWork.RealEstateKind.getAll();
            return View(obj);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Models.RealEstateKind kind)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.RealEstateKind.Add(kind);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.RealEstateKind kind)
        {
            _unitOfWork.RealEstateKind.Update(kind);
            _unitOfWork.Complete();

            return View();
        }
        public ActionResult Delete(int id)
        {
            _unitOfWork.RealEstateKind.Delete(id);
            _unitOfWork.Complete();

            return View();
        }
    }
}