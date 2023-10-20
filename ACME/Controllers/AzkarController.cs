using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class AzkarController : Controller
    {
        // GET: Azkar
        public ActionResult Azkar()
        {
            return View();
        }

        public ActionResult AddAzkar()
        {
            FL_MASJID objflmsjd = new FL_MASJID();
            return PartialView("_AddAzkar", objflmsjd);
        }
    }
}