using System;
using System.Collections.Generic;

namespace Item
{
  public class Bread
  {
    private static int total = 0;
    public int Cost { get; set; }
    public int Order { get; set; }
    public Bread(int order)
    {
      Order = order;
      total = total + order;
    }
    public static int GetAll()
    {
      return total;
    }
    public static void ClearAll()
    {
      total = 0;
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
    public int BreadOrder(int total)
    {
      int cost = total * 5;
      int final = Math.Abs(((this.Order/2) * 5) - cost);
      return final;
    }
  }
}