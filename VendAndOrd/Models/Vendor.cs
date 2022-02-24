using System.Collections.Generic;

namespace VendAndOrd.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor>{};
    public string Name { get; set; }
    public int Id { get; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }

        public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}