using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWebApp.Controllers
{
    public class HomeController : ApiController
    {
        [Route("get-employee")]
        public IHttpActionResult GetEmployee()
        {
            List<String> somthing = new List<string>();
            somthing.Add("Trest");
            somthing.Add("Calc");
            somthing.Add("Break");
            return Ok(somthing);
        }

        [Route("get-employees")]
        public IHttpActionResult GetEmployees()
        {
            List<String> somthing = new List<string>();
            somthing.Add("Trest");
            somthing.Add("Calc");
            somthing.Add("Break");
            return Ok(somthing);
        }
    }
}
