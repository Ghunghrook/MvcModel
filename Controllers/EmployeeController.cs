using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModel.Models;

namespace MvcModel.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(e => e.DepartmentId == departmentId).ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee =  employeeContext.Employees.Single(emp => emp.Id == id);

            //Employee employee = new Employee()
            //{
            //    EmployeeId = 101,
            //    FirstName = "ghun",
            //    LastName = "khare",
            //    Gender = "female",
            //    Salary = 10000
            //};

            return View(employee);
        }
    }
}