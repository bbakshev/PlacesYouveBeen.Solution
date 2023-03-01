using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Destination
  {
    public string CityName { get; set; }
    public string Image { get; set; }
    public string Journal { get; set; }

    public int Id { get; }
    private static List<Destination> _instances = new List<Destination> { };
    public Destination(string city, string image, string journal)
    {
      CityName = city;
      Image = image;
      Journal = journal;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Destination> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Destination Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void Update(string city, string image, string journal)
    {
      this.CityName = city;
      this.Image = image;
      this.Journal = journal;
    }

  }
}