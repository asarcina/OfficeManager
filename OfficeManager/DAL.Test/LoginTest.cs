﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeManager.DAL;

namespace DAL.Test
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void InsertLogin()
        {
            Console.WriteLine("Test Insert Login");
            User user = new User();
            user.Name = "Alessandro";
            user.Surname = "Sarcina";
            user.Login = new Login
            {
                Create = DateTime.Now,UserName = "alex",Password = "xxxx",Enabled = true
            };
            using (DataContext db = new DataContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            Console.WriteLine("Test Insert Login Terminated");
        }
    }
}
