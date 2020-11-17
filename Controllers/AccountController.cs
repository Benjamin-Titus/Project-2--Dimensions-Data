using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_2__Dimensions_Data.Models;
using System.Data.SqlClient;

namespace Project_2__Dimensions_Data.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source= DESKTOP-9RRC9IL; database=AccountSetting;intergrated security =SSPI;"; 
        }
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                return View();
            }
            else
            {
                return View();
            }

            con.Close();

            return View();
        }
    }
}
