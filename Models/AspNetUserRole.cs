using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_2__Dimensions_Data.Models
{
    public class AspNetUserRole
    {
        [Key, Display(Name = "ID")]
        public UserId Id;
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
