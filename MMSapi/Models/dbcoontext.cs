using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;


namespace MMSapi.Models
{
    public class dbcoontext: DbContext
    {
        public static string condata = @"data source=DESKTOP-85TN7KT; Initial Catalog=Cloud_neolite; User ID=sa; Password=master;";
        public dbcoontext()
            :base(condata)
        {

        }
        public DbSet<Supmi_GMSC_MST> Supmi_GMSC_MST { get; set; }
    }
}