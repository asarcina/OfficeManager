using System;
using OfficeManager.DAL;

namespace OfficeManager.DataLayerModel
{

    public class LoginModel
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Create { get; set; }
        public bool Enabled { get; set; }
      
        public LoginModel(Login login)
        {
            if (login != null)
            {
            LoginId = login.LoginId;
            UserName = login.UserName;
            Password = login.Password;
            Create = login.Create;
            Enabled = login.Enabled; 
            }
            
        }
        public Login ToDal()
        {
            Login login = new Login();
            login.Create = Create;
            login.Enabled = Enabled;
            login.LoginId = LoginId;
            login.UserName = UserName;
            login.Password = Password;
            return login;
        }
        public LoginModel()
        {
        }
    }
}
