using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OfficeManager.DAL
{
    public class Login
    {
        public int LoginId { get; set; }

        [Required()]
        public string UserName { get; set; }

        [Required()]
        public string Password { get; set; }

        [Required()]
        public DateTime Create { get; set; }

        [Required()]
        public bool Enabled { get; set; }
    }
}
