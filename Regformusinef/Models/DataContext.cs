using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Regformusinef.Models
{
    public class DataContext : DbContext
    {
        public virtual DbSet<users> users { get; set; }
      
    }
}