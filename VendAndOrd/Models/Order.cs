using System.Collections.Generic;

namespace VendAndOrd.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string DeliveryDate { get; set; }
    public int Price { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public int Id { get; }
    
    public Order(string description, string deliveryDate, int price)
    {
      Description = description;
      DeliveryDate = deliveryDate;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
} 