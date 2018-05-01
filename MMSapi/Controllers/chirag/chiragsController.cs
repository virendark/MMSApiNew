using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMSapi.Controllers.chirag
{
    public class chiragsController : ApiController
    {
        [HttpGet]
        [Route("api/chirag/AllCity")]
        public List<string> City()
        {
            List<string> citys = new List<string>()
            {
                "Noida","Delhi","Bhopal","Ghaziabad"
            };
            return citys;
        }
        [HttpGet]
        [Route("api/chirag/Country")]
        public List<string> country()
        {
            List<string> countrys = new List<string>()
            {
                "India","US","China"
            };
            return countrys;
        }
    }

}
