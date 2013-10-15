using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeManager.DAL;
using OfficeManager.DataLayerModel;
using OfficeManager.LowMapper;

namespace LowMapper.Test
{
    [TestClass]
    public class MappingTest
    {
        User user;
        private UserModel userModel;
        [TestInitialize]
        public void Init()
        {
            user = new User();
            userModel = new UserModel();
            user.UserId = 102;
            user.Name = "Test999";
            user.Surname = "Test9999999";
            user.Sex = "M";
            user.Login = new Login();
            user.Login.Create = DateTime.Now;
            user.Login.Enabled = true;
            user.Login.LoginId = 100;
            user.Login.Password = "xxxxxxx";
            user.Login.UserName = "username9999";

            userModel.UserId = 102;
            userModel.Name = "Test999";
            userModel.Surname = "Test9999999";
            userModel.Sex = "M";
            userModel.Login = new LoginModel();
            userModel.Login.Create = DateTime.Now;
            userModel.Login.Enabled = true;
            userModel.Login.LoginId = 100;
            userModel.Login.Password = "xxxxxxx";
            userModel.Login.UserName = "username9999";


        }
        [TestMethod]
        public void MapUserIntoModelUser()
        {
            DownMapper sut = new DownMapper();
            UserModel model = sut.Mapping<UserModel>(user);
            string output = model.ToString();
            Console.WriteLine(output);
        }
    }
}
