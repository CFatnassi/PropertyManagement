using Microsoft.AspNet.Identity;
using PropertyManagement.Helpers;
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
    [Authorize]
    public class RentKindsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public RentKindsController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: RentKinds
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetRentKinds()
        {
            try
            {
                var userId = User.Identity.GetUserId();

                var RentData = _unitOfWork.RentKind.getAll();

                return Json(RentData, JsonRequestBehavior.AllowGet);
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


                var userId = User.Identity.GetUserId();



                var RentKind = new RentKind();

                return PartialView(RentKind);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult SaveNew(RentKind ObjToSave)
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
                 
                _unitOfWork.RentKind.Add(ObjToSave);
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






        public ActionResult Modify(int Id)
        {
            try
            {

                var RendData = _unitOfWork.RentKind.GetMyRentKind(Id);

                return PartialView(RendData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Update(RentKind ObjToSave)
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

                _unitOfWork.RentKind.Update(ObjToSave);
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





        public ActionResult Remove(int Id)
        {
            try
            {

                var RendData = _unitOfWork.RentKind.GetMyRentKind(Id);

                return PartialView(RendData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Delete(RentKind ObjToSave)
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

                _unitOfWork.RentKind.Delete(ObjToSave.Id);
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