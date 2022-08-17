using CRUD_Application.Data;
using CRUD_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD_Application.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;
        public EmployeeController(ApplicationContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model )
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    City = model.City,
                    province = model.province,
                    Salary = model.Salary
                };
                context.Employees.Add(employee);
                context.SaveChanges();
                TempData["error"] = "Record Saved!";
                return RedirectToAction("Index");

            }
            else
            {
                TempData["message"] = "empty field can't submit";
                return View(model);
            }
            
        }
        public IActionResult Delete(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            TempData["error"] = "Record Deleted";
            return RedirectToAction("Index");
        }
        //get
        public IActionResult Edit(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            var result = new Employee()
            {
                Name = emp.Name,
                City=emp.City,
                province = emp.province,
                Salary = emp.Salary
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            var emp = new Employee()
            {
                Id = model.Id,
                Name = model.Name,
                City = model.City,
                province = model.province,
                Salary = model.Salary
            };
            context.Employees.Update(emp);
            context.SaveChanges();
            TempData["error"] = "Record updated";

            return RedirectToAction("Index");
        }

    }
}
