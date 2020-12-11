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
        Console.WriteLine("Would you like to add to your order, y/n?");
        string x = Console.ReadLine();
        if (x == "y")
        {
          Main();
        }
        else if (x == "n")
        {
          int finalOrder = Bread.GetAll();
          Console.WriteLine($"You bought {finalOrder} Loaves for ${Bread.BreadOrder(finalOrder)}");
          Console.WriteLine("Bye!");
        }
        else 
        {
          Console.WriteLine("Not a valid selection");
        }
      }
      else if (input == "pastry")
      {
        Console.WriteLine("How many Pastries do you need?");
        int pastry = int.Parse(Console.ReadLine());
        Pastry uOrder = new Pastry(pastry);
        Console.WriteLine($"Your {uOrder.Order} Pastries will cost ${uOrder.PastryOrder()}");
      }
      else 
      {
        Console.WriteLine("Not a valid selection");
      }
    }
  }
}