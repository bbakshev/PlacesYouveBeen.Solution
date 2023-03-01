using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class DestinationController : Controller
  {

    [HttpGet("/destinations")]
    public ActionResult Index()
    {
      List<Destination> allDestinations = Destination.GetAll();
      return View(allDestinations);
    }

    [HttpGet("/destinations/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/destinations")]
    public ActionResult Create(string description)
    {
      Destination myDestination = new Destination(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/destinations/delete")]
    public ActionResult DeleteAll()
    {
      Destination.ClearAll();
      return View();
    }

    [HttpGet("/destinations/{id}")]
    public ActionResult Show(int id)
    {
      Destination foundDestination = Destination.Find(id);
      return View(foundDestination);
    }
  }
}