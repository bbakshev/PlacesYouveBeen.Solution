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
      Places newPlaces = new Places();
      Assert.AreEqual(typeof(Places), newPlaces.GetType());
    }
  }
}