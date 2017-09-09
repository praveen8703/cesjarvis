using ApiAiSDK.Model;
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
        public JsonResult GetResponse([FromBody]AIRequest request)
        {
            AIResponse response = new AIResponse
            {
                Status = new ApiAiSDK.Model.Status {
                    Code = 200,
                    ErrorType = "success"
                },
                Id = Guid.NewGuid().ToString(),
                Lang = "english-us",
                Result = new ApiAiSDK.Model.Result {
                    Source = "AWS ces_jarvis",
                    Action = "testaction",
                    Fulfillment = new ApiAiSDK.Model.Fulfillment {
                        Speech = "I AM GROOT",
                        DisplayText = "I AM GROOT",
                        Source = "ces_getresponse"
                    }
                }
            };
            return Json(response);
        }
    }
}
