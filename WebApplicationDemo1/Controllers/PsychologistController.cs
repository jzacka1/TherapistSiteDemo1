using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo1.Helpers;
using WebApplicationDemo1.ViewModel;

namespace WebApplicationDemo1.Controllers
{
    public class PsychologistController : Controller
    {
        // GET: Psychologist
        public async Task<ActionResult> Home()
        {
            return View();
        }

        public async Task<ActionResult> About()
        {
            return View();
        }

        public async Task<ActionResult> Contact()
        {
            return View();
        }

        //Must include
        [HttpPost]
        public async Task<ActionResult> Contact(Contacts contact)
        {
            if (ModelState.IsValid)
            {
                using (EmailHelper em = new EmailHelper())
                {
                    await em.SendEmailAsync(contact, "YOUREMAIL@EMAIL.COM");
                }
            }

            return RedirectToAction("Home", "Psychologist", null);
        }
    }
}