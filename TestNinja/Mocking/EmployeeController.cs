using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage _storage;
        //private EmployeeContext _db;

        public EmployeeController(IEmployeeStorage storage)
        {
            _storage = storage;
            //_db = new EmployeeContext();
        }

        public ActionResult DeleteEmployee(int id)
        {
            //var employee = _db.Employees.Find(id);
            //_db.Employees.Remove(employee);
            //_db.SaveChanges();
            _storage.DeleteEmployee(id);

            return RedirectToAction("Employees");

        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }

    public class RedirectResult : ActionResult { }

    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}