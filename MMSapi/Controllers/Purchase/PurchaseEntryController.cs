using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MMSapi.Models;
namespace MMSapi.Controllers.Purchase
{
    public class PurchaseEntryController : ApiController
    {
        [HttpPost]
        [Route("api/mms/Save")]
        public IHttpActionResult Savedata(Usermodels um)
        {
            try
            {
                var sd = um.Desination;

                return Ok(um.Name);
            }
            catch(Exception ex)
            {
               
                return Ok(ex.StackTrace);
            }
        }
    }
}
