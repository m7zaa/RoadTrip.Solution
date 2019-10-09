using Microsoft.AspNetCore.Mvc;
using RoadTrip.Models;

namespace RoadTrip.Controllers
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