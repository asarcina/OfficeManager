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

        public UserModel()
        {
            Login = new LoginModel();
        }
        
    }
}
