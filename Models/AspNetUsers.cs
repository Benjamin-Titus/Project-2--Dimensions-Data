using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__Dimensions_Data.Models
{
    public class AspNetUsers
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string EmailCornfirmed { get; set; }
        public string Password { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberConfirmed { get; set; }
        public string TwoFactorEnabled { get; set; }
        public string LookoutEnd { get; set; }
        public string LookoutEnabled { get; set; }
        public string AccessFailedCount { get; set; }
        public string Name { get; set; }
    }
}
