using System;

namespace Item
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int order)
    {
      Order = order;
    }
    public int BreadOrder()
    {
      Console.WriteLine(this.Order);
      return 5 * this.Order;
    }
  }
}