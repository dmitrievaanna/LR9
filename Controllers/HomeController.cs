using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LR9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LR9.Models.DataText a)
        {
            if (ModelState.IsValid)
            {
                LR9.Models.DataList.dataList.Add(new Models.DataText()
                {
                    firstBox = a.firstBox,
                    secondBox = a.secondBox,
                    thirdBox = a.thirdBox
                });
                return Redirect("Index");
            }
            return View(a);
        }

        

        public IActionResult Error()
        {
            return View();
        }
    }
}
