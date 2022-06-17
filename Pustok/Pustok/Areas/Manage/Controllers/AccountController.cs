using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Areas.Manage.ViewModel;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }
        /*public async Task<IActionResult> CreateAdmin()
        {
            AppUser admin = new AppUser
            {
                FullName = "Super Admin",
                UserName = "SPAdmin",

            };
            var result = await _userManager.CreateAsync(admin, "Hello123");
            if (!result.Succeeded)
            {
                return Ok(result.Errors);
            }
            return View();
        }*/
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminLoginViewModel admin) 
        {
            return Ok(admin);
        
        }
    }
}
