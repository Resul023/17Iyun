using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var setting = _context.Settings.ToDictionary(x => x.Key, y => y.Value);
            
            return View(setting);
        }
        public IActionResult Edit(string key) 
        {
            var setting = _context.Settings.FirstOrDefault(x => x.Key == key);
            if (setting==null)
            {
                return NotFound();
            }
           
            return View(setting);
        
        }

        [HttpPost]
        public IActionResult Edit(Setting setting) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isExists = _context.Settings.FirstOrDefault(x => x.Key == setting.Key && x.Value == setting.Value);
            if (isExists == null)
            {
                return NotFound();
            }
            isExists.Value = setting.Value;
            isExists.Key = setting.Key;
            _context.SaveChanges();
            return RedirectToAction("index");

        }
    }
}
