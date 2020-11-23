using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__Dimensions_Data.Models
{
    public class AspNetUserClaims
    {
        public int EmpId { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public int ClaimValue { get; set; }
    }
}
