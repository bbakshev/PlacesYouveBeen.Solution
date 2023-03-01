using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlacesTests
  {
    // public void Dispose()
    // {
    //   Places.ClearAll();
    // }

    [TestMethod]
    public void PlacesConstructor_CreatesInstanceOfPlaces_Places()
    {
      Destination newPlaces = new Destination("test");
      Assert.AreEqual(typeof(Destination), newPlaces.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string city = "Paris, Texas";
      Destination newDestination = new Destination(city);
      string result = newDestination.CityName;
      Assert.AreEqual(city, result);
    }

  }
}