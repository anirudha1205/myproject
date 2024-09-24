using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AppDbContext appDbContext;

        public AccountsController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Signup(User adduser)
        {
            adduser.Id=adduser.Id;
            appDbContext.Userss.Add(adduser);
            appDbContext.SaveChanges();
            return View();

        }
    }
}
