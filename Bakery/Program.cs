using System;
using System.Collections.Generic;
using Item;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to bakery, Would you like Bread or Pastry?");
      string input = Console.ReadLine();
      if (input == "bread")
      {
        Console.WriteLine("How much Bread do you need?");
        int bread = int.Parse(Console.ReadLine());
        Bread uOrder = new Bread(bread);
        Console.WriteLine($"Your {uOrder.Order} Loaves of bread will cost ${uOrder.BreadOrder()}");
        Console.WriteLine(Bread.GetAll());
      }
      else if (input == "pastry")
      {
        Console.WriteLine("How many Pastries do you need?");
        int pastry = int.Parse(Console.ReadLine());
        Pastry uOrder = new Pastry(pastry);
        Console.WriteLine($"Your {uOrder.Order} Pastries will cost ${uOrder.PastryOrder()}");
      }
    }
  }
}