using System;
using OfficeManager.DAL;

namespace OfficeManager.DataLayerModel
{

    public class LoginModel
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Create { get; set; }
        public bool Enabled { get; set; }
        
    }
}
