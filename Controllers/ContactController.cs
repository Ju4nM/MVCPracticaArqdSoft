using Microsoft.AspNetCore.Mvc;
using MVCPracticaArqdSoft.Data;
using MVCPracticaArqdSoft.Models;

namespace MVCPracticaArqdSoft.Controllers {
    public class ContactController : Controller {

        ContactData contactData = new ContactData();
        public IActionResult ViewContacts () {
            var contacts = contactData.FindAll();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult CreateNewContact () {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewContact (ContactModel newContact) {
            bool result = contactData.SaveOne(newContact);
            if (result) return View("ViewContacts");
            return View();
        }
    }
}
