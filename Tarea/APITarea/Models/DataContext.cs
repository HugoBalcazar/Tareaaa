using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnectionS")
        {

        }

        public System.Data.Entity.DbSet<APITarea.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<APITarea.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<APITarea.Models.Sale> Sales { get; set; }
    }
}