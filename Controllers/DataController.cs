using Microsoft.AspNetCore.Mvc;
using Project_2__Dimensions_Data.Models;

namespace Project_2__Dimensions_Data.Controllers
{
    public class DataController : Controller
    {
        [Authorize]
        public class DataController : Controller
        {
            private readonly ILogger<HomeController> logger;
            private readonly Employee employee;

            public DataController(ILogger<HomeController> _logger, Employees employee)
            {
                logger = _logger;
                dataLogic = _dataLogic;
            }

           
            [Route("data/index")]
            [Route("data/{page}")]
            [Route("data/index/{page}")]
            public async Task<IActionResult> Index(int page, string searchString, string cat)
            {

                int pageTemp = (page > 0 ? page : 1);
                var items = new List<Employees>();
                if (string.IsNullOrEmpty(searchString))
                {
                    //searchString = ViewData["query"].ToString();
                }
                if (string.IsNullOrEmpty(searchString))
                {
                    items = await Employees.GetAllRecords(pageTemp, 15);
                }
                else
                {
                    items = await Employees.GetAllRecords(pageTemp, 15, searchString, cat);
                }
                var pages = await Employees.GetCount();
                ViewData["query"] = searchString;
                ViewData["pages"] = (int)(pages / 15);
                ViewData["page"] = pageTemp;
                return View(items);
            }

            [Authorize(Roles = "manager,admin")]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [Authorize(Roles = "manager,admin")]
            public async Task<IActionResult> Create(DataItem model)
            {
                if (ModelState.IsValid)
                {
                    //add here
                    await Employees.InsertRecord(model);
                }
                return View();
            }

            [Route("data/details/{id}")]
            public async Task<IActionResult> Details(string id)
            {
                var data = await Employess.GetRecordById(new ObjectId(id));
                return View(data);
            }

            [Route("data/Delete/{id}")]
            [Authorize(Roles = "manager,admin")]
            public async Task<IActionResult> Delete(string id)
            {
                var data = await Employees.GetRecordById(new ObjectId(id));
                return View(data);
            }

            [Route("data/Delete/{id}")]
            [HttpPost]
            public IActionResult DeletePost(string id)
            {
                if (ModelState.IsValid)
                {
                    Employees.DeleteRecord(new ObjectId(id));
                    return RedirectToAction("index");
                }
                ViewData["error"] = "Invalid model";
                return View();
            }

            [Route("data/Update/{Id}")]
            [Authorize(Roles = "manager,admin")]
            public async Task<IActionResult> Update(string Id)
            {
                var data = await Employees.GetRecordById(new UserId(Id));
                return View(data);
            }

            [Route("data/Update/{Id}")]
            [HttpPost]
            [Authorize(Roles = "manager,admin")]
            public IActionResult Update(string Id, Employees model)
            {
                if (ModelState.IsValid)
                {
                    Employees.UpsertRecord(new UserId(Id), model);
                    return RedirectToAction("index");
                }
                ViewData["error"] = "Invalid model";
                return View();
            }
        }
    }
}
}
