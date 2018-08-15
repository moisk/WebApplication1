using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ContactController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;            
        }
        public IActionResult Index()
        {
            var contact = applicationDbContext.Contacts.ToList();
            return View(contact);

        }
    }
}
