using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Project_2__Dimensions_Data.Models;

namespace Project_2__Dimensions_Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public DbSet<Employees> DimensionsData { get; set; }
        public DbSet<ApplicationUser> ApplicationUser {get;set;}
    }
}

