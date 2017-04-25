using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LR9.Models;
using Microsoft.EntityFrameworkCore;

namespace LR9.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.dataText.ToList());
        }

        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(DataText _datatext)
        {
            if (ModelState.IsValid)
            {
                _context.dataText.Add(_datatext);
                _context.SaveChanges();
                return Redirect("Index");
            }
            return View();
        }

        

       
        public IActionResult Delete(int _id)
        {
            DataText data = _context.dataText.FirstOrDefault(x => x.Id == _id);
            if (data != null)
            {
                _context.dataText.Remove(data);
                _context.SaveChanges();
            }
            return Redirect("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
