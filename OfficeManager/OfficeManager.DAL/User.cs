using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace OfficeManager.DAL
{
    public class User
    {
        public int UserId { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Surname { get; set; }

        [Required()]
        public string Sex { get; set; }

        public int LoginId { get; set; }

        [ForeignKey("LoginId")]
        public Login Login { get; set; }
    }
}
