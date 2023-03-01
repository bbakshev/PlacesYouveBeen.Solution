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
    public ActionResult Create(string description, string image, string journal)
    {
      Destination myDestination = new Destination(description, image, journal);
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

    [HttpGet("destinations/update/{id}")]
    public ActionResult Update(int id)
    {
      Destination foundDestination = Destination.Find(id);
      return View(foundDestination);
    }

    [HttpPost("/destinations/patch")]
    public ActionResult Patch(string city, string image, string journal, int id)
    {
      Destination thisDestination = Destination.Find(id);
      thisDestination.Update(city, image, journal);
      return RedirectToAction("Index");
    }
  }
}