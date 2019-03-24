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
    public class TreasuryController : ApiController
    {

        DefaultConnection BD = new DefaultConnection();

        [HttpGet]
        public IEnumerable<SMI_Treasury> Get() {            
            return BD.SMI_Treasury.ToList();;
        }

        [HttpGet]
        public SMI_Treasury Get(int id)
        {
            return BD.SMI_Treasury.FirstOrDefault(x=> x.Id == id) ;
        }

        [HttpPost]
        public bool Post(SMI_Treasury treasury) {
            BD.SMI_Treasury.Add(treasury);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool Put(SMI_Treasury treasury) {
            var updatetreasury = BD.SMI_Treasury.FirstOrDefault(x => x.Id == treasury.Id);
            updatetreasury.IDChurch = treasury.IDChurch;
            updatetreasury.IDUser = treasury.IDUser;
            updatetreasury.TreasuryMonth = treasury.TreasuryMonth;
            updatetreasury.TreasuryDate = null;
            BD.SMI_Treasury.Add(treasury);
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool Delete(int id) {
            var deletetreasury = BD.SMI_Treasury.FirstOrDefault(x => x.Id == id);
            BD.SMI_Treasury.Remove(deletetreasury);
            return BD.SaveChanges() > 0;
        }
    }
}
