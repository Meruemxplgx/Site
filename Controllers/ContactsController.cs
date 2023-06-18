using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using shop_test.Models;

namespace shop_test.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // Contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid) 
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
