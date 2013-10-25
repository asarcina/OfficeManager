using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;
using OfficeManager.LowMapper;

namespace OfficeManager.DataManager
{
    public class LoginManager
    {
        private readonly DownMapper mapper;

        public LoginManager()
        {
            mapper = new DownMapper();
        }

        public bool LoginExist(Login checkLogin)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                List<Login> logins = uow.LoginRepository.Get(l => l.UserName.Equals(checkLogin.UserName, StringComparison.InvariantCultureIgnoreCase)).ToList();
                return logins.Count > 0;
            }
        }

        public bool CheckPassword(string username, string password)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Login login = uow.LoginRepository.Get(l => l.UserName.Equals(username, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                if (login != null && login.Password == password)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
