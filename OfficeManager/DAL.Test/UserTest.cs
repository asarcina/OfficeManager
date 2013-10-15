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
        public UserModel newModel;

        [TestInitialize]
        public void Init()
        {
            IdUser = 2;
            ParamSearch = "Sarcina";
            LoginModel newLogin= new LoginModel
                                 {
                                     Create = DateTime.Now,Enabled = true,Password ="cifrata",UserName = "username"
                                 };
            newModel= new UserModel
                                {
                                    Login = newLogin,Name = "Tizio",Surname = "Caio",Sex = "M"
                                };
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
       
        [TestMethod]
        public void InsertNewUser()
        {
            UserManager manager = new UserManager();
            int inserted = manager.Insert(newModel);
            Assert.IsTrue(inserted>0);
            Console.WriteLine("Utente inserito correttamente {0}",inserted);
        }
    }
}
