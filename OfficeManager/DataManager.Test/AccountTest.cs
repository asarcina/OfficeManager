using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeManager.DataManager;
using OfficeManager.DataLayerModel;

namespace DataManager.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CheckAccount()
        {
            AccountManager m = new AccountManager();
            UserModel user = new UserModel();
            user.Name = "alessandro";
            user.Surname = "asfsafas";
            user.Sex = "M";
            user.Login.Create = DateTime.Now;
            user.Login.Enabled = true;
            user.Login.Password = "password";
            user.Login.UserName = "username";
            int insertAcount = m.CheckAccount(user);
        }
    }
}
