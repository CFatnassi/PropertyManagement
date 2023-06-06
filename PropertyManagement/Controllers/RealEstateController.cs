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
    public class RealEstateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RealEstateController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: RealEstate
        public ActionResult Index()
        {
            IEnumerable<Models.RealEstate> obj = new List<Models.RealEstate>();
            obj = _unitOfWork.RealEstate.getAll();
            return View(obj);
        }
        public ActionResult Create()
        {
            IEnumerable<Models.RealEstateKind> kinds = new List<Models.RealEstateKind>();
            kinds = _unitOfWork.RealEstateKind.getAll();
            RealEstateView objRView = new RealEstateView()
            {
                RealEstateKind = kinds,
                RealEstateKindId = 0

            };

            return View(objRView);
            
        }
        public ActionResult Save(Models.RealEstate RealEstate)
        {
            //MsgUnit msg = new MsgUnit();
            _unitOfWork.RealEstate.Add(RealEstate);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(Models.RealEstate RealEstate)
        {
            _unitOfWork.RealEstate.Update(RealEstate);
            _unitOfWork.Complete();

            return View();
        }
        public ActionResult Delete(Guid guid)
        {
            _unitOfWork.RealEstate.Delete(guid);
            _unitOfWork.Complete();

            return View();
        }
    }
}