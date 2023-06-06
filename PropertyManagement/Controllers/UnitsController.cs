using PropertyManagement.Models;
using PropertyManagement.Persistence;
using PropertyManagement.Repositories;
using PropertyManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropertyManagement.Controllers
{
    public class UnitsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitsController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: Units
        public ActionResult Index()
        {
            IEnumerable<Models.Units> obj = new List<Models.Units>();
            obj = _unitOfWork.Unit.getAll();
            return View(obj);
        }
        public ActionResult Create()
        {
            IEnumerable<Models.UnitKind> kinds = new List<Models.UnitKind>();
            kinds = _unitOfWork.UnitKind.getAll();
            UnitView objRView = new UnitView()
            {
                UnitKinds = kinds,
                UnitKindId = 0

            };

            return View(objRView);
        }
        public ActionResult Save(Models.Units unit)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.Unit.Add(unit);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.Units unit)
        {
            _unitOfWork.Unit.Update(unit);
            _unitOfWork.Complete();

            return View();
        }
        public ActionResult Delete(Guid guid)
        {
            _unitOfWork.Unit.Delete(guid);
            _unitOfWork.Complete();

            return View();
        }
    }
}