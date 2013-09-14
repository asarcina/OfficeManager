using System;
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
            user.Name = "rrrrrr";
            user.Surname = "rrrrrrrrr";
            user.Sex = "M";
            user.Login = new Login
            {
                Create = DateTime.Now,UserName = "ttt",Password = "xxxx",Enabled = true
            };
            Login l = new Login();
            
            using (DataContext db = new DataContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                l = user.Login;
                db.Logins.Remove(l);
                db.Users.Remove(user);
                db.SaveChanges();
            }
            
            Console.WriteLine("Test Insert Login Terminated");
        }
    }
}
