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
    public class CompanyController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCompany()
        {
            try
            {

                var CompanyData = _unitOfWork.Company.GetAllCompany();

                return Json(CompanyData, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new List<Company>(), JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult CreateNew()
        {
            try
            {

                var Company = new Company();

                return PartialView(Company);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult SaveNew(Company ObjToSave)
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
                ObjToSave.UserId = User.Identity.GetUserId();
                ObjToSave.CreateDate = DateTime.Now;

                _unitOfWork.Company.Add(ObjToSave);
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

                var CompanyData = _unitOfWork.Company.GetMyCompany(Id);

                return PartialView(CompanyData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Update(Company ObjToSave)
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

                _unitOfWork.Company.Update(ObjToSave);
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

                var CompanyData = _unitOfWork.Company.GetMyCompany(Id);

                return PartialView(CompanyData);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
                return View("Error");
            }
        }
        [HttpPost]
        public JsonResult Delete(Company ObjToSave)
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

                _unitOfWork.Company.Delete(ObjToSave.Guid);
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