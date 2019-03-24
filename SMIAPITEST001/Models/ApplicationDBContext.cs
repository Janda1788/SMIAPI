using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMIDA;
using System.Data.Entity;

namespace SMIAPITEST001.Models
{
    public class ApplicationDBContext : DbContext
    {       
        public ApplicationDBContext () : base ("DefaultConnection"){
            
        }

        public DbSet<SMI_Treasury> Treasury { get; set; }
    }
}