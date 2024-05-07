using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        Asp8Context context = new Asp8Context();
        public IActionResult Index()

        {
            var employees = context.Employees.ToList();
            return View("Index", employees);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        public IActionResult Store(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return Redirect("Index");
        }
    }
}
