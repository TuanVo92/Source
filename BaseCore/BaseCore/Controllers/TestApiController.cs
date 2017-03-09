using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseCore.Controllers
{
    public class TestApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage getData()
        {
            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
