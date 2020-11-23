using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__Dimensions_Data.Models
{
    public class AspNetRoleClaims
    {
            public int Id { get; set; }
            public int RoleId { get; set; }
            public int ClaimType { get; set; }
            public int ClaimValue { get; set; }
    }
}
