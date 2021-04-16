using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public double Weight { get; set; }
    public bool IsPacked { get; set; }
    public bool IsPurchased { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item>();

    public Item (string name, double weight, bool packed, bool purchased)
    {
      Name = name;
      Weight = weight;
      IsPacked = packed;
      IsPurchased = purchased;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}