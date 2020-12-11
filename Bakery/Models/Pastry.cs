using System;

namespace Item
{
  public class Pastry
  {
    public int Cost { get; set; }
    public int Order { get; set; }
    public Pastry(int order)
    {
      Order = order;
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
  }
}