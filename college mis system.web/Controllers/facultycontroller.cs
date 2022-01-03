using college_mis_system.web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace college_mis_system.web.Controllers
{
    public class facultycontroller : Controller
    {
        public IActionResult Index()
        {
            List<FacultyModel> model = GetFaculties();
            return View(model);
        }

        private List<FacultyModel> GetFaculties()
        {
            List<FacultyModel> model = new List<FacultyModel>();
            model.Add(new FacultyModel { Id = 1, Name = "BCA", Seats = 30, TotalFee = 5000 });
            model.Add(new FacultyModel { Id = 2, Name = "Bsc csit", Seats = 45, TotalFee = 7000 });
            model.Add(new FacultyModel { Id = 3, Name = "BBA", Seats = 55, TotalFee = 6500 });
            model.Add(new FacultyModel { Id = 4, Name = "BBM", Seats = 35, TotalFee = 5500 });

            return model;
        }
        [HttpGet]
        public IActionResult Create()

        {
            return View();


        }

        [HttpPost]
        public IActionResult Create(FacultyModel model)
        {
            //to do
            // save to db


            Console.WriteLine(model.Name);

            return RedirectToAction("Index");



        }


            
    
    }

}
