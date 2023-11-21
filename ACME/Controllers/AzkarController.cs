using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class AzkarController : BaseController
    {
        // GET: Azkar
        public ActionResult Azkar()
        {
            return View();
        }

        public JsonResult AdUpdate(FormCollection objform)
        {
            var model = new Azkar_Property();
            UpdateModel<Azkar_Property>(model);
            if (ModelState.IsValid)
            {
                
            }
            else
            {

            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddAzkar(int? id)
        {
           Azkar_Property objazkar = new Azkar_Property();
            if (id > 0)
            {
                //objflmsjd.MAsjid_ID = 1;
                //objflmsjd.Masjid_Location = "English meaning of this azkar is bjfbdak";
                //objflmsjd.Masjid_Title = "SubhanALLAH";
                //objflmsjd.Masjid_Lat = Convert.ToDecimal(1.2);
                //objflmsjd.Masjid_Lon = Convert.ToDecimal(1.2);
                //objflmsjd.Masjid_Descr = "Urdu Meaning";
                //objflmsjd.Masjid_Location = "New York";
                //objflmsjd.Rating = Convert.ToDecimal(4);

            }
            return PartialView("_AddAzkar", objazkar);
        }
    }
}