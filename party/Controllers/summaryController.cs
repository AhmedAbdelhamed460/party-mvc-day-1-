using Microsoft.AspNetCore.Mvc;
using party.Models;

namespace party.Controllers
{
    public class summaryController : Controller
    {
        public IActionResult Index()
        {
            return View("summary",attenddata.getAll());
        }
    }
}
