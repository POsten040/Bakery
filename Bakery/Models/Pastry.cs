using System;

namespace Item
{
  public class Pastry
  {
    private static int total = 0;
    public int Cost { get; set; }
    public int Order { get; set; }
    public Pastry(int order)
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
    public int PastryOrder()
    {
      this.Cost = this.Order;
      int total = this.Cost * 2;
      if (this.Order >= 3) 
      {
        int sale = 5 * (this.Order/3);
        int reg = 2 * (this.Order % 3);
        return sale + reg;
      } 
      else 
      {
      return total;
      }
    }
    public static double PastryOrder(int total)
    {
      double d = (double)total;
      double cost = 5 * (total/3);
      double reg = 2 * (total%3);
      return cost + reg;
    }
  }
}