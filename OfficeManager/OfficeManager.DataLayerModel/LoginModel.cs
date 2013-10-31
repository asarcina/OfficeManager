using System;
using System.Runtime.Serialization;
using OfficeManager.DAL;

namespace OfficeManager.DataLayerModel
{
    [DataContract]
    public class LoginModel
    {
        [DataMember]
        public int LoginId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public DateTime Create { get; set; }
        [DataMember]
        public bool Enabled { get; set; }
        
    }
}
