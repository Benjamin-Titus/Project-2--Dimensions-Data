using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__Dimensions_Data.Models
{
    public class AspNetUserLogins
    {
        public string EmailAddress { get; set; }
        public int ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }
    }
}
