using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;

namespace DataModel
{
    public class LoginModel
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Create { get; set; }
        public bool Enabled { get; set; }
        public UserModel User { get; set; }

        public LoginModel(Login login)
        {
            LoginId = login.LoginId;
            UserName = login.UserName;
            Password = login.Password;
            Create = login.Create;
            Enabled = login.Enabled;
            User= new UserModel();
            User.Name = login.User.Name;
            User.Sex = login.User.Sex;
            User.Surname = login.User.Surname;
            User.UserId = login.User.UserId;
        }

        public LoginModel()
        {
            User= new UserModel();
        }
    }
}
