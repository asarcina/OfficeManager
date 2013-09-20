using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;

namespace OfficeManager.DataLayerModel
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public int LoginId { get; set; }
        public LoginModel Login { get; set; }

        public UserModel(User user)
        {
            UserId = user.UserId;
            Name = user.Name;
            Surname = user.Surname;
            Sex = user.Sex;
            LoginId = user.LoginId;
            Login= new LoginModel(user.Login);
           
        }

        public UserModel()
        {
            Login = new LoginModel();
        }

        public User ToDal()
        {
            User result= new User();
            result.LoginId = this.LoginId;
            result.Name = this.Name;
            result.Surname = this.Surname;
            result.Sex = this.Sex;
            result.UserId = this.UserId;
            result.Login = this.Login.ToDal();
            return result;
        }

    }
}
