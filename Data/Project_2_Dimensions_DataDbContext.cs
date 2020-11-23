using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2__Dimensions_Data.Data
{
    public class Project_2_Dimensions_DataDbContext : IdentityDbContext
    {
        public Project_2_Dimensions_DataDbContext(DbContextOptions<Project_2_Dimensions_DataDbContext> options)
           : base(options)
        {

        }
       
    }
}

