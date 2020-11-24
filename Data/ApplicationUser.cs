using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_2__Dimensions_Data.Models
{
    public class ApplicationUser: IdentityUser 
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public int LastName { get; set; }
    }
}
