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
            return View();
        }

        [HttpGet]
        public JsonResult GetUnits()
        {
            try
            {


                var UnitData = _unitOfWork.Unit.getAll();

                return Json(UnitData, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new List<Units>(), JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult CreateNew()
        {
            try
            {

                var Unit = new Units();

                return PartialView(Unit);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult SaveNew(Units ObjToSave)
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

                _unitOfWork.Unit.Add(ObjToSave);
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

                var UnitData = _unitOfWork.Unit.GetMyUnits(Id);

                return PartialView(UnitData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Update(Units ObjToSave)
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

                _unitOfWork.Unit.Update(ObjToSave);
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





        public ActionResult Remove(Guid Id)
        {
            try
            {

                var UnitData = _unitOfWork.Unit.GetMyUnits(Id);

                return PartialView(UnitData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Delete(Units ObjToSave)
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

                _unitOfWork.Unit.Delete(ObjToSave.Guid);
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
    }
}