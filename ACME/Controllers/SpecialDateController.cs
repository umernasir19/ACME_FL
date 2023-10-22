using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class SpecialDateController : BaseController
    {
        // GET: SpecialDate
        public ActionResult SpecialDate()
        {
            return View();
        }

        public ActionResult AddSpecialDate(int? id)
        {
            FL_MASJID objmsjidprop = new FL_MASJID();
            if (id > 0)
            {
                objmsjidprop.MAsjid_ID = 1;
                objmsjidprop.Masjid_Location = "New York";
                objmsjidprop.Masjid_Title = "Event Title Name";
                objmsjidprop.Masjid_Descr = "New Event Description";
                objmsjidprop.Masjid_Lat = Convert.ToDecimal(1.2);
                objmsjidprop.Masjid_Lon = Convert.ToDecimal(1.2);
                objmsjidprop.Masjid_Descr = "Description Of Event";
                objmsjidprop.Masjid_Location = "New York";
                objmsjidprop.Rating = Convert.ToDecimal(4);

            }
            return PartialView("_AddSpecialDate", objmsjidprop);
        }
    }
}