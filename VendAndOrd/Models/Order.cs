using System.Collections.Generic;

namespace VendAndOrd.Models
{
  public class Order
  {
    public string Description { get; set; }
    
    public Order(string description)
    {
      Description = description;
      
    }

  }
} 