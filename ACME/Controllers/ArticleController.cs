using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACME.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Article()
        {
            return View();
        }
        public ActionResult AddArticle()
        {
            FL_MASJID objflmsjd = new FL_MASJID();
            return PartialView("_AddArticle", objflmsjd);
        }
    }
}