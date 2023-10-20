using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class EventsController : BaseController
    {
        // GET: Events
        public ActionResult Events()
        {
            return View();
        }

        public ActionResult AddEvent(int? id)
        {
            FL_MASJID objmsjidprop = new FL_MASJID();
            return PartialView("_AddEvent", objmsjidprop);

        }
    }
}