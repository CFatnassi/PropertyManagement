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
    public class UnitKindController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitKindController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: UnitKind
        public ActionResult Index()
        {
            IEnumerable<Models.UnitKind> obj = new List<Models.UnitKind>();
            obj = _unitOfWork.UnitKind.getAll();
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Models.UnitKind kind)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.UnitKind.Add(kind);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.UnitKind kind)
        {
            _unitOfWork.UnitKind.Update(kind);
            _unitOfWork.Complete();

            return View();
        }
        public ActionResult Delete(int id)
        {
            _unitOfWork.UnitKind.Delete(id);
            _unitOfWork.Complete();

            return View();
        }
    }
}