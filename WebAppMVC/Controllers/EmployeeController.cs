using Microsoft.AspNetCore.Mvc;
using System.Linq;
public class EmployeeController : Controller
{
  public ActionResult Index()
  {
    var employees = Person.GetEmployee();
    return View(employees);
  }
  public ActionResult Detail([FromQuery] int id)
  { 
    var employees =Person.GetEmployee();
    Person employee = employees.FirstOrDefault(x => x.Id == id);
    return View(employee);
  }
  public ActionResult Add()
  {
    return View();
  }

  [HttpPost]
  public ActionResult<string> Add(Person person)
  {
    return "Record Saved";
  }

}
