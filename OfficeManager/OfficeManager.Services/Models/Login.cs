using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OfficeManager.DataLayerModel;

namespace OfficeManager.Services.Models
{
    [Serializable]
    public class Login
    {
        public Login(LoginModel login)
        {
            if (login == null) return;

            LoginId = login.LoginId;
            Username = login.UserName;
            Password = login.Password;
            Enabled = login.Enabled;
            Created = login.Create;
        }

        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public DateTime Created { get; set; }
    }
}