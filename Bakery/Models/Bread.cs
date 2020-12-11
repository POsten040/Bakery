using System;

namespace Item
{
  public class Bread
  {
    public int Cost { get; set; }
    public int Order { get; set; }
    public Bread(int order)
    {
      Order = order;
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