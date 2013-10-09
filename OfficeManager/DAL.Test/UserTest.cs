using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeManager.DataLayerModel;
using OfficeManager.DataManager;

namespace DAL.Test
{
    [TestClass]
    public class UserTest
    {
        public int IdUser;
        public string ParamSearch;

        [TestInitialize]
        public void Init()
        {
            IdUser = 2;
            ParamSearch = "Sarcina";
        }
        
        [TestMethod]
        public void GetById()
        {
            UserManager manager = new UserManager();
            UserModel userById = manager.GetUserById(IdUser);
            Assert.IsNotNull(userById);
        }

        [TestMethod]
        public void GetUsers()
        {
            UserManager manager = new UserManager();
            List<UserModel> usersList=manager.GetUsers();
            Assert.IsNotNull(usersList);
            foreach (UserModel model in usersList)
            {
                Console.WriteLine(model.UserId);
            }
        }

        [TestMethod]
        public void FindUserBySurName()
        {
            UserManager manager = new UserManager();
            List<UserModel> usersList = manager.GetUserBySurname(ParamSearch);
            Assert.IsNotNull(usersList);
            foreach (UserModel model in usersList)
            {
                Console.WriteLine(model.Surname);
            }
        }
    }
}
