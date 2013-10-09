using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OfficeManager.DataLayerModel;
using OfficeManager.DataManager;
using OfficeManager.Services.Models;

namespace OfficeManager.Services.Controllers
{
    public class LoginController : ApiController
    {
        /// <summary>
        /// Restituisce i dati della login associata all'identificativo associato
        /// </summary>
        /// <param name="id">Id Login</param>
        /// <returns></returns>
        public Login GetLoginById(int id)
        {
           throw new NotImplementedException();
        }

        public List<Login> GetLogins()
        {
            throw new NotImplementedException();
        } 
    }
}
