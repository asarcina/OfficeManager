using System;
using System.Collections.Generic;
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
    }
}
