using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SMIDA;
using System.Data.SqlClient;
using System.Configuration;
using SMIAPITEST001.Models;

namespace SMIAPITEST001.Controllers
{
    public class UserController : ApiController
    {
        DefaultConnection BD = new DefaultConnection();

        [HttpGet]
        public IEnumerable<SMI_User> Get()
        {
            return BD.SMI_User.ToList(); ;
        }
    }
}
