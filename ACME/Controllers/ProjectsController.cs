using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class ProjectsController : BaseController
    {
        // GET: Projects
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult AddProjects()
        {
            FL_MASJID objflmsjd = new FL_MASJID();
            return PartialView("_AddProjects", objflmsjd);
        }
    }
}