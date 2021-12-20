using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Sitecore.FakeDb;
using XAct.Library.Settings;

namespace ToDoApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        ToDoDAL dbToDo = new ToDoDAL();

        public IActionResult Index()
        {
            EmployeeTaskViewModel etvm = new EmployeeTaskViewModel();
            return View(etvm);
        }

        public IActionResult Details(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }

        public IActionResult CreateEmployee()
        {
            Employee e = new Employee();
            e.Name = "Cotton Hill";
            e.Title = "Retired Vet";
            e.HoursAvailible = 30;
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index");
        }

        //updates database with info from form
        public IActionResult Result(Employee e)
        {
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)

        {
            dbEmployee.DeleteEmployee(id);

            return RedirectToAction("Index");

        }




        public IActionResult EmployeeForm()
        {

            return View();
        }


        //public IActionResult Update(int id)

        //{
        //    List<Employee> students = db.GetEmployees();
        //    Employee e = students.Where(x => x.Id == id).ToList().First();
        //    e.HoursAvailible--;
        //    db.UpdateEmployee(e);

        //    return RedirectToAction("Index", "Home");




        //}




    }
}
