using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class NamazController : BaseController
    {
        // GET: Namaz
        public ActionResult Namaz()
        {
            return View();
        }


        public ActionResult AddNamaz()
        {
            FL_MASJID objflmsjd = new FL_MASJID();
            return PartialView("_AddNamaz", objflmsjd);
        }
    }
}