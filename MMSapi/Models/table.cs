using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MMSapi.Models
{
    public class Supmi_GMSC_MST
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int ID { get; set; }
        public string Outlet_id { get; set; }
        public string MSC_FLAG { get; set; }
        public string LOC_CODE { get; set; }
        public string MSC_CODE { get; set; }
        public string MSC_DESC { get; set; }
        public string MSC_FDESC { get; set; }
        public string MSC_ADD1 { get; set; }
        public string MSC_ADD2 { get; set; }
        public string PS_ACC { get; set; }
        public string MSC_MFACT { get; set; }
        public string MSC_VTYPE { get; set; }
        public string MSC_VCODE { get; set; }
        public string MSC_UOM { get; set; }
        public string INCREMENT { get; set; }
        public string AUTO_REFNO { get; set; }
        public string ACC_CODE { get; set; }
        public string VOU_TYPE { get; set; }
        public string ITM_TXDSC { get; set; }
        public Nullable<float> TAX_ROUND { get; set; }
        public Nullable<float> DIS_ROUND { get; set; }
        public Nullable<float> ON_TOT { get; set; }
        public string DOC_TYPE { get; set; }
        public string FIN_DIR { get; set; }
        public string PRN_SNO { get; set; }
        public string CST_FRMRQ { get; set; }
        public string CST_FRMTYP { get; set; }
       
        public Nullable<System.DateTime> Gic_stdate { get; set; }
        public string ACC_TYPE { get; set; }
        public string LOC_LOT_NO { get; set; }
        public string PROD_LOC_YN { get; set; }
        public string Comp_Name_Tally { get; set; }
        public string City { get; set; }
        public string MSC_ADD3 { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string coutry { get; set; }
        public string MSC_Sname { get; set; }
      

    }
}