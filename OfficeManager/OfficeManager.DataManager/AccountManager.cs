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
        public int CheckAccount(UserModel account)
        {
            int result = 0;
            //TODO
            //if (account != null && account.Login != null)
            //{
            //    try
            //    {
            //        UserManager user = new UserManager();
            //        user = account.ToDal();
            //        UserManager insert = user.Insert();
            //        result = insert.UserId;
            //    }
            //    catch (Exception e)
            //    {
            //        throw;
            //    }
            //}
            return result;
        }
    }
}
