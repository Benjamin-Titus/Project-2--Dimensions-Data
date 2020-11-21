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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //customize ASP.NET Identity Model and override the default if necessary
            //You can name ASP.NET tables and more
            //Add your customization after calling onModelCreating(builder)
        }
    }

}