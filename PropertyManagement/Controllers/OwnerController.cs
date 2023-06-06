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
    public class OwnerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OwnerController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: Owner
        public ActionResult Index()
        {
            IEnumerable<Models.Owner> obj = new List<Models.Owner>();
            obj = _unitOfWork.Owner.getAll();
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Models.Owner Owner)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.Owner.Add(Owner);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.Owner owner)
        {
            _unitOfWork.Owner.Update(owner);
            _unitOfWork.Complete();

            return View();
        }
       
        public ActionResult Delete(Guid guid)
        {
            _unitOfWork.Owner.Delete(guid);
            _unitOfWork.Complete();

            return View();
        }
    }
}