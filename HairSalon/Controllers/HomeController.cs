using Microsoft.AspNetCore.Mvc;

namespace Bestaurant.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return RedirectToAction("Index", "Stylist");
    }
  }
}