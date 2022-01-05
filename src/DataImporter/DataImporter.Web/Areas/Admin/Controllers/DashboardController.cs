using DataImporter.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataImporter.Web.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            return View(model);
        }
    }
}
