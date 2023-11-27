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
        public ActionResult AddArticle(int? id)
        {
            FL_MASJID objflmsjd = new FL_MASJID();
            if (id > 0)
            {
                objflmsjd.MAsjid_ID = 1;
                objflmsjd.Masjid_Location = "Key Ponts of namaz";
                objflmsjd.Masjid_Title = "Article Practice Namaz";
                objflmsjd.Masjid_Lat = Convert.ToDecimal(1.2);
                objflmsjd.Masjid_Lon = Convert.ToDecimal(1.2);
                objflmsjd.Masjid_Descr = "Description Of Masjid";
                objflmsjd.Masjid_Location = "New York";
                objflmsjd.Rating = Convert.ToDecimal(4);

            }
            return PartialView("_AddArticle", objflmsjd);
        }
    }
}