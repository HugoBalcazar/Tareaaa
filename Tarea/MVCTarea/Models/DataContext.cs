using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnectionS")
        {

        }

        public System.Data.Entity.DbSet<MVCTarea.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVCTarea.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<MVCTarea.Models.Sale> Sales { get; set; }
    }
}