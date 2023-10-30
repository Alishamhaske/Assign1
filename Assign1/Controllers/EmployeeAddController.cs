using Assign1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    public class EmployeeAddController : Controller
    {
        EmployeeAddDAL db;
        IConfiguration configuration;

        public EmployeeAddController(IConfiguration configuration) 
        {
            this.configuration= configuration;
            db = new EmployeeAddDAL(configuration);

        }
        // GET: EmployeeAddController
        public ActionResult Index()
        {
            return View(db.GetEmployeeAdds());
        }

        // GET: EmployeeAddController/Details/5
        public ActionResult Details(int id)
        {
           

            var emp = db.GetEmployeeAddById(id);
            return View(emp);
        }

        // GET: EmployeeAddController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeAddController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeAdd employeeAdd)
        {
            try
            {
                int result=db.AddEmployeeAdd(employeeAdd);
                if(result>=1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeAddController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeAddController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeAddController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeAddController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
