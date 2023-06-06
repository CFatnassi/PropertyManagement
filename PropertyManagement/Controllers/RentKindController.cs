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
    public class RentKindController : Controller
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public RentKindController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: RentKind
        public ActionResult Index()
        {
            IEnumerable<Models.RentKind> obj = new List<Models.RentKind>();
            obj = _unitOfWork.RentKind.getAll();
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Models.RentKind kind)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.RentKind.Add(kind);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.RentKind kind)
        {
            _unitOfWork.RentKind.Update(kind);
            _unitOfWork.Complete();

            return View();
        }
        public ActionResult Delete(int id)
        {
            _unitOfWork.RentKind.Delete(id);
            _unitOfWork.Complete();

            return View();
        }
    }
}