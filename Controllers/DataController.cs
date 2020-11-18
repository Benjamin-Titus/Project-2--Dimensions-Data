using Microsoft.AspNetCore.Mvc;

namespace Project_2__Dimensions_Data.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
