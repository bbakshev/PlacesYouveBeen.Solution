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
    public void GetAndSetCityName_ReturnsCityName_String()
    {
      string city = "Paris, Texas";
      Destination newDestination = new Destination(city);
      string result = newDestination.CityName;
      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_DestinationList()
    {
      List<Destination> newList = new List<Destination> { };
      List<Destination> result = Destination.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsDestinationList_DestinationList()
    {
    string city1 = "Paris, Texas";
    string city2 = "Paris, France";
    Destination newDestination1 = new Destination(city1);
    Destination newDestination2 = new Destination(city2);
    List<Destination> newList = new List<Destination> { newDestination1, newDestination2 };
    }
  }
}