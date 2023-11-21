using BLL.Setups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HrProperty.Models;
using ACME.Controllers;

namespace ACME.Controllers_WebApi
{
    [RoutePrefix("api/Masjid")]
    public class MasjidApiController : BaseApiController
    {


        MASJID_BLL _objMsjdBLL;
        FL_MASJID _objmsjid;

        BaseController objbasecontroller;
        [Route("GetAllMAsjid")]
        [HttpGet]
        public IHttpActionResult GetAllMAsjid()
        {
            _objMsjdBLL = new MASJID_BLL();

            objbasecontroller = new BaseController();
            var Users = objbasecontroller.ConertToListof<FL_MASJID>(_objMsjdBLL.GEtALL());
            // bagService.GetAllBags();
            var response = new ResponseClass() { Status = true, ResponseObject = Users };
            return Ok(response);
        }
    }
}
