using System;
using System.Collections.Generic;

namespace Item
{
  public class Bread
  {
    private static List<Bread> _instances = new List<Bread> {};
    public int Cost { get; set; }
    public int Order { get; set; }
    public Bread(int order)
    {
      _instances.Add(this);
      Order = order;
    }
    public static List<Bread> GetAll()
    {
      return _instances;
    }
    public int BreadOrder()
    {
      this.Cost = this.Order;
      int total = 5 * this.Cost;
      if (this.Order > 1) {
        int discount = Math.Abs(((this.Order/2) * 5) - total);
        return discount;
      } 
      else
      {
        return total;
      }
    }
  }
}