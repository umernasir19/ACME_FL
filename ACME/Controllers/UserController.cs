using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using BLL.Setups;
using HrProperty.Models;
using ACME.Controllers_WebApi;

namespace ACME.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : BaseApiController
    {

        User_BLL _objUserBLL;
        User_Property _objuser;

        BaseController objbasecontroller;
        [Route("GetAllusers")]
        [HttpGet]
        public IHttpActionResult GetAllusers()
        {
            _objUserBLL = new User_BLL();
            
            objbasecontroller = new BaseController();
            var Users = objbasecontroller.ConvertToListof<User_Property>(_objUserBLL.GetAllUsers());
            // bagService.GetAllBags();
            var response = new ResponseClass() { Status = true, ResponseObject = Users };
            return Ok(response);
        }

        [Route("Login")]
        [HttpPost]
        public IHttpActionResult VerifyUser(LoginProperty objlogin)
        {
            _objuser = new User_Property()
            {
                UserName=objlogin.email,
                Password=objlogin.password
            };
            _objUserBLL = new User_BLL(_objuser);

            objbasecontroller = new BaseController();
            var Users = objbasecontroller.ConvertToListof<User_Property>(_objUserBLL.GetUserByIDPass());
            // bagService.GetAllBags();
            var response = new ResponseClass() { Status = true, ResponseObject = Users };
            return Ok(response);
        }




    }
}
