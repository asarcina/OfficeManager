using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;
using OfficeManager.DataLayerModel;

namespace OfficeManager.DataManager
{
    public class AccountManager
    {
        public int InsertAccount(UserModel account)
        {
            int result = 0;
            if (account != null && account.Login != null)
            {
                try
                {
                    User user = new User();
                    user = account.ToDal();
                    User insert = user.Insert();
                    result = insert.UserId;
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return result;
        }

        public LoginModel GetLoginById(int id)
        {
             using (DataContext db = new DataContext())
             {
                 Login login = db.Logins.FirstOrDefault(i => i.LoginId == id);
                 LoginModel result = new LoginModel(login);
                 return result;
             }
        }

        public List<LoginModel> GetLogins()
        {
            using (DataContext db = new DataContext())
            {
                List<Login> logins = db.Logins.ToList();
                List<LoginModel> result= new List<LoginModel>();
                foreach (Login login in logins)
                {
                    result.Add(new LoginModel(login));
                }
               
                return result;
            }
        }
    }
}
