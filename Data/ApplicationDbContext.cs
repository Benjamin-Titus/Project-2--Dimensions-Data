#pragma warning disable CS0234 // The type or namespace name 'EntityFrameworkCore' does not exist in the namespace 'Microsoft.AspNetCore.Identity' (are you missing an assembly reference?)
#pragma warning restore CS0234 // The type or namespace name 'EntityFrameworkCore' does not exist in the namespace 'Microsoft.AspNetCore.Identity' (are you missing an assembly reference?)
using Microsoft.EntityFrameworkCore;
using Project_2__Dimensions_Data.Data;


namespace Project_2__Dimensions_Data.Data
{
#pragma warning disable CS0246 // The type or namespace name 'IdentityDbContext' could not be found (are you missing a using directive or an assembly reference?)
    public class ApplicationDbContext : IdentityDbContext
#pragma warning restore CS0246 // The type or namespace name 'IdentityDbContext' could not be found (are you missing a using directive or an assembly reference?)
    {


#pragma warning disable CS0311 // The type 'Project_2__Dimensions_Data.Data.ApplicationDbContext' cannot be used as type parameter 'TContext' in the generic type or method 'DbContextOptions<TContext>'. There is no implicit reference conversion from 'Project_2__Dimensions_Data.Data.ApplicationDbContext' to 'Microsoft.EntityFrameworkCore.DbContext'.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS0311 // The type 'Project_2__Dimensions_Data.Data.ApplicationDbContext' cannot be used as type parameter 'TContext' in the generic type or method 'DbContextOptions<TContext>'. There is no implicit reference conversion from 'Project_2__Dimensions_Data.Data.ApplicationDbContext' to 'Microsoft.EntityFrameworkCore.DbContext'.
            : base(options)
        {

        }

    }
}
