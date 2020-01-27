using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication1.Models;

namespace MVCWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id = -1)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            IEnumerable<Employee> emp;
            //Employee employee;
            if (id == -1)
            {
                emp = from e in employeeContext.employee select e;
            }
            else
            {
                emp = (IEnumerable<Employee>)employeeContext.employee.Single(x => x.EmployeeID == id);
            }
            //List < Employee > employees = new List<Employee>()
            //{
            //    new Employee(){EmployeeId =101,Name="Ashutosh", Salary=500000,Department="IT"},
            //    new Employee(){EmployeeId =102,Name="Alok", Salary=500000,Department="Army"},
            //    new Employee(){EmployeeId =103,Name="Amit", Salary=500000,Department="CS"},
            //    new Employee(){EmployeeId =104,Name="Varun", Salary=500000,Department="EC"},
            //    new Employee(){EmployeeId =105,Name="Pravin", Salary=500000,Department="Test"}
            //};
            //ViewBag.Countries = new List<string>()
            //{
            //    "India",
            //    "US",
            //    "China",
            //    "Nepal"
            //};
            return View(emp);
        }
        public string GetDetails()
        {
            return "Hello From GetDetails method...";
        }
    }
}