using ACME.Controllers;
using BLL.Setups;
using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACME.Controllers_WebApi
{
    [RoutePrefix("api/Azkar")]
    public class AzkarApiController : BaseApiController
    {
        
        Azkar_BLL _objazkardBLL;
       // Azkar_Property _objazkarproperty;

        BaseController objbasecontroller;
        [Route("AddUpdate")]
        [HttpPost]
        public IHttpActionResult AddUpdate(Azkar_Property _objazkarproperty)
        {
            _objazkardBLL = new Azkar_BLL(_objazkarproperty);
            if (_objazkardBLL.AddUpdate())
            {
                var response = new ResponseClass() { Status = true, ResponseObject = _objazkarproperty };
                return Ok(response);
            }
            else
            {
                var response = new ResponseClass() { Status = true, ResponseObject = _objazkarproperty };
                return Ok(response);
            }

            
           
            
        }

        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            _objazkardBLL = new Azkar_BLL();
            if (_objazkardBLL.GetAll().Rows.Count>0)
            {
                objbasecontroller = new BaseController();

                var AzkarList=objbasecontroller.ConvertToListof<Azkar_Property>(_objazkardBLL.GetAll());
                
                var response = new ResponseClass() { Status = true, ResponseObject = AzkarList };
                return Ok(response);
            }
            else
            {
                var response = new ResponseClass() { Status = true, ResponseObject = "" };
                return Ok(response);
            }




        }

        [Route("Delete")]
        [HttpPost]
        public IHttpActionResult Delete(Azkar_Property _objazkarproperty)
        {
            _objazkardBLL = new Azkar_BLL(_objazkarproperty);
            if (_objazkardBLL.Delete())
            {
                var response = new ResponseClass() { Status = true, ResponseObject = _objazkarproperty };
                return Ok(response);
            }
            else
            {
                var response = new ResponseClass() { Status = true, ResponseObject = _objazkarproperty };
                return Ok(response);
            }




        }
    }
}
