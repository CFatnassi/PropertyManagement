using PropertyManagement.Helpers;
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
    [Authorize]
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
            return View();
        }

        [HttpGet]
        public JsonResult GetRealEstate()
        {
            try
            {


                var RealEstateData = _unitOfWork.RealEstate.getAll();

                return Json(RealEstateData, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new List<RentKind>(), JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult CreateNew()
        {
            try
            {

                var RealEstate = new RealEstate();

                return PartialView(RealEstate);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult SaveNew(RealEstate ObjToSave)
        {
            MsgUnit Msg = new MsgUnit();
            try
            {
                if (!ModelState.IsValid)
                {

                    string Err = " ";
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    foreach (ModelError error in errors)
                    {
                        Err = Err + error.ErrorMessage + "  ";
                    }

                    Msg.Msg = Resources.Resource.SomthingWentWrong + " " + Err;
                    Msg.Code = 0;
                    return Json(Msg, JsonRequestBehavior.AllowGet);

                }

                ObjToSave.Guid = Guid.NewGuid();

                _unitOfWork.RealEstate.Add(ObjToSave);
                _unitOfWork.Complete();
                Msg.Msg = Resources.Resource.AddedSuccessfully;
                Msg.Code = 1;
            }
            catch (Exception ex)
            {

                Msg.Msg = Resources.Resource.SomthingWentWrong + " " + ex.Message.ToString();
                Msg.Code = 0;

            }

            return Json(Msg, JsonRequestBehavior.AllowGet);
        }






        public ActionResult Modify(Guid Id)
        {
            try
            {

                var RealEstateData = _unitOfWork.RealEstate.GetMyRealEstate(Id);

                return PartialView(RealEstateData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Update(RealEstate ObjToSave)
        {
            MsgUnit Msg = new MsgUnit();
            try
            {


                if (!ModelState.IsValid)
                {

                    string Err = " ";
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    foreach (ModelError error in errors)
                    {
                        Err = Err + error.ErrorMessage + "  ";
                    }

                    Msg.Msg = Resources.Resource.SomthingWentWrong + " " + Err;
                    Msg.Code = 0;
                    return Json(Msg, JsonRequestBehavior.AllowGet);

                }

                _unitOfWork.RealEstate.Update(ObjToSave);
                _unitOfWork.Complete();
                Msg.Msg = Resources.Resource.UpdatedSuccessfully;
                Msg.Code = 1;
            }
            catch (Exception ex)
            {

                Msg.Msg = Resources.Resource.SomthingWentWrong + " " + ex.Message.ToString();
                Msg.Code = 0;

            }

            return Json(Msg, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Remove(Guid Id)
        {
            try
            {

                var RealEstateData = _unitOfWork.RealEstate.GetMyRealEstate(Id);

                return PartialView(RealEstateData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Delete(RealEstate ObjToSave)
        {
            MsgUnit Msg = new MsgUnit();
            try
            {


                if (!ModelState.IsValid)
                {

                    string Err = " ";
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    foreach (ModelError error in errors)
                    {
                        Err = Err + error.ErrorMessage + "  ";
                    }

                    Msg.Msg = Resources.Resource.SomthingWentWrong + " " + Err;
                    Msg.Code = 0;
                    return Json(Msg, JsonRequestBehavior.AllowGet);

                }

                _unitOfWork.RealEstate.Delete(ObjToSave.Guid);
                _unitOfWork.Complete();
                Msg.Msg = Resources.Resource.DeletedSuccessfully;
                Msg.Code = 1;
            }
            catch (Exception ex)
            {

                Msg.Msg = Resources.Resource.SomthingWentWrong + " " + ex.Message.ToString();
                Msg.Code = 0;

            }




            return Json(Msg, JsonRequestBehavior.AllowGet);



        }
    }
}