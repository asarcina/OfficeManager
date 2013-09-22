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
            AccountManager accountManager = new AccountManager();
            LoginModel loginById = accountManager.GetLoginById(id);
            Login result = new Login(loginById);
            return result;
        }

        public List<Login> GetLogins()
        {
            AccountManager accountManager = new AccountManager();
            List<LoginModel> logins=accountManager.GetLogins();
            List<Login> result= new List<Login>();
            foreach (LoginModel login in logins)
            {
                result.Add(new Login(login));
            }
            return result;
        } 
    }
}
