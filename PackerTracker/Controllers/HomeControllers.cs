using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}