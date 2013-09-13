using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;

namespace DataModel
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public LoginModel Login { get; set; }

        public UserModel(User user)
        {

            UserId = user.UserId;
            Name = user.Name;
            Surname = user.Surname;
            Sex = user.Sex;
            Login= new LoginModel();
            Login.LoginId = user.Login.LoginId;
            Login.UserName = user.Login.UserName;
            Login.Password = user.Login.Password;
            Login.Create = user.Login.Create;
            Login.Enabled = user.Login.Enabled;
        }

        public UserModel()
        {
            Login = new LoginModel();
        }

    }
}
