using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MMSapi.Models;
using MMSapi.DAL;
namespace MMSapi.Controllers.Location
{
    public class LocationsController : ApiController
    {
        IRepository<Supmi_GMSC_MST> _Supmi_GMSC_MST;
        [HttpGet]
        [Route("api/v1/GetLocation/")]
        public dynamic Locationall()
        {
            try
            {
                _Supmi_GMSC_MST = new Repository<Supmi_GMSC_MST>();

                var countloc = _Supmi_GMSC_MST.getall().Count();
                if (countloc <= 1)
                {

                    var locdata= _Supmi_GMSC_MST.getall().Select(x => new Supmi_GMSC_MST { LOC_CODE = x.LOC_CODE, MSC_DESC = x.MSC_DESC }).ToArray();
                    //  var refno=
                   // select ref_flag,*from Supmi_TRN_TYP_MST where OUTLET_ID = 'A01' and LOC_CODE = 'L001' and TRN_TYPE = 'TR'
//select top 1 GREF_NO from Supmi_led_tran where LEFT(TRN_TYPE, 2) = 'TR' and outlet_id = 'A01' and IT_LC_CODE = 'L001' order by GREF_NO desc

                    List<RefClass> locwithrefdata = new List<RefClass>();
                    RefClass refc = new RefClass();

                    refc.LocId = locdata[0].LOC_CODE;
                    refc.LocName = locdata[0].MSC_DESC;
                    return "";
                }
                else
                {
                    return "Select Dropdown list";
                }
                }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
    public class RefClass
    {
        public string LocId { get; set; }
        public string LocName { get; set; }
        public string RefNo { get; set; }
    }
}
