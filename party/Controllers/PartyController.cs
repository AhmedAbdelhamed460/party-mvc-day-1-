using Microsoft.AspNetCore.Mvc;
using party.Models;

namespace party.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult start()
        {
            return View();
        }
        public IActionResult Addform()
        {

            return View();
        }
       


    }
}
