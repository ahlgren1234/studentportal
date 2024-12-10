using Microsoft.AspNetCore.Mvc;

namespace studentportal.Controllers
{
  public class StudentsController : Controller 
  {
    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }
  }
}