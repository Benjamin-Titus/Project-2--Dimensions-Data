using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
 

namespace Project_2__Dimensions_Data.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "Username")]
        public string Username { get; set; }

        [Required,StringLength(50),Display(Name ="Email required")]
        public string EmailAddress { get; set; }

        [Required, StringLength(50), Display(Name = "Password required")]
        public string PasswordHash { get; set; }

        public string Role { get; set; } = "User";

        public bool Validated { get; set; } = false;
    }
}
