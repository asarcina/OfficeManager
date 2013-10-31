using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;

namespace OfficeManager.DataLayerModel
{
    [DataContract]
    public class UserModel
    {
        public int UserId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public int LoginId { get; set; }
        [DataMember]
        public LoginModel Login { get; set; }

        public UserModel()
        {
            Login = new LoginModel();
        }
        
    }
}
