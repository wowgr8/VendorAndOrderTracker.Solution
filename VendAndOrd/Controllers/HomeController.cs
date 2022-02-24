using Microsoft.AspNetCore.Mvc;

namespace VendAndOrd.Controllers
{
  public class HomeController : Controllers
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}