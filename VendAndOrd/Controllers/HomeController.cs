using Microsoft.AspNetCore.Mvc;

namespace VendAndOrd.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}