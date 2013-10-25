using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OfficeManager.DataManager;

namespace OfficeManager.Services.Controllers
{
    public class UserController : ApiController
    {
        private UserManager _userManager = null;
        private LoginManager _loginManager = null;
        public UserController()
        {
            _userManager = new UserManager();
            _loginManager= new LoginManager();
        }
        public string Authenticate(string username, string password)
        {
            bool checkPassword = _loginManager.CheckPassword(username, password);
            if (!checkPassword) return string.Empty;
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            return Convert.ToBase64String(time.Concat(key).ToArray());
        }

        public bool IsAuthenticated(string token)
        {
            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            return when >= DateTime.UtcNow.AddHours(-24);
        }
    }
}
