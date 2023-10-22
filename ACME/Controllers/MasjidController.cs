using BLL.Setups;
using HrProperty.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class MasjidController : BaseController
    {
        // GET: Masjid
        MASJID_BLL objmsjd;
        MasjidApiController _objapimsjid;
        public ActionResult Masjid()
        {
            
            _objapimsjid = new MasjidApiController();
            IHttpActionResult response = _objapimsjid.GetAllMAsjid();
            var content =response as OkNegotiatedContentResult<ResponseClass>;
            List<FL_MASJID> listmsjid = new List<FL_MASJID>();

            ResponseClass objres = (content.Content);
            var respose =objres.ResponseObject;
            if (respose.ToString().Length>0)
            {
                listmsjid = ((IEnumerable)respose).Cast<FL_MASJID>().ToList();
            }
            return View(listmsjid);
        }

        public ActionResult AddMasjid(int? id)
        {
            FL_MASJID objmsjidprop = new FL_MASJID();
            if (id > 0)
            {
                objmsjidprop.MAsjid_ID = 1;
                objmsjidprop.Masjid_Location = "New York";
                objmsjidprop.Masjid_Title = "New Masjid";
                objmsjidprop.Masjid_Lat = Convert.ToDecimal(1.2);
                objmsjidprop.Masjid_Lon = Convert.ToDecimal(1.2);
                objmsjidprop.Masjid_Descr = "Description Of Masjid";
                objmsjidprop.Masjid_Location = "New York";
                objmsjidprop.Rating = Convert.ToDecimal(4);

            }
            return PartialView("AddMasjid", objmsjidprop);

        }

        [System.Web.Http.HttpPost]
        public JsonResult AddUpdate(FL_MASJID objfrom)
        {
            try
            {
                return Json(new { Login = false, statuscode = 400, msg = "", url = "/Account/Login" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { Login = false, statuscode = 400, msg = ex.Message, url = "/Account/Login" }, JsonRequestBehavior.AllowGet);

            }
        }
    }
}