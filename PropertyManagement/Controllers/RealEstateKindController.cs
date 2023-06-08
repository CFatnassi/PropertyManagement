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
            return View();
        }

        [HttpGet]
        public JsonResult GetRealEstateKind()
        {
            try
            {


                var RealEstateData = _unitOfWork.RealEstateKind.getAll();

                return Json(RealEstateData, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new List<Models.RealEstateKind>(), JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult CreateNew()
        {
            try
            {

                var RealEstateKind = new Models.RealEstateKind();

                return PartialView(RealEstateKind);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult SaveNew(Models.RealEstateKind ObjToSave)
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

                _unitOfWork.RealEstateKind.Add(ObjToSave);
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

                var RealEstateData = _unitOfWork.RealEstateKind.GetMyRealEstateKind(Id);

                return PartialView(RealEstateData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Update(Models.RealEstateKind ObjToSave)
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

                _unitOfWork.RealEstateKind.Update(ObjToSave);
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

                var RealEstateData = _unitOfWork.RealEstateKind.GetMyRealEstateKind(Id);

                return PartialView(RealEstateData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Delete(Models.RealEstateKind ObjToSave)
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

                _unitOfWork.RealEstateKind.Delete(ObjToSave.Id);
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