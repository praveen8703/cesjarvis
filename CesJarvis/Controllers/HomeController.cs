using CesJarvis.Models.Request;
using CesJarvis.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CesJarvis.Controllers
{
    [Route("ces")]
    public class HomeController : Controller
    {
        [Route("getresponse")]
        [HttpPost]
        public JsonResult GetResponse([FromBody]RequestBody request)
        {
            ResponseBody response = new ResponseBody
            {
                displayText = "I AM GROOT",
                speech = "I AM GROOT",
                source = "ces_getresponse"
            };
            return Json(response);
        }
    }
}
