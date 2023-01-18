using Microsoft.AspNetCore.Mvc;
using party.Models;

namespace party.Controllers
{
    public class ThanksController : Controller
    {
        public IActionResult Index(Attendees attendees)
        {
            if (attendees.willAttend == "true") { 
                attenddata.AddGuest(attendees);
            return View("Thanks", attendees);
        }
            else return View("another day ", attendees);
            

            
        }
    }
}
