using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MMSapi.Models;
namespace MMSapi.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/v1/Getuser/{name}")]
        public IHttpActionResult GetUsers()
        {
            return Ok();
        }
    }
}
