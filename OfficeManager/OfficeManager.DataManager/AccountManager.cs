using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using OfficeManager.DAL;

namespace OfficeManager.DataManager
{
    public class AccountManager
    {
        public int InsertAcount(UserModel account)
        {
            int result = 0;
            if (account!= null && account.Login != null)
            {
                try
                {
                    User user = new User();
                    user.Name = account.Name;
                    user.Surname = account.Surname;
                    user.Sex = account.Sex;
                    user.Login=new Login();
                    user.Login.UserName = account.Login.UserName;
                    user.Login.Password = account.Login.Password;

                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
            return result;
        }
    }
}
