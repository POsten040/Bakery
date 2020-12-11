using System;
using System.Collections.Generic;
using Item;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to bakery, Would you like Bread or Pastry?(bread/pastry)");
      string input = Console.ReadLine();
      Console.WriteLine($"How much {input} do you need?");
      int quantity = int.Parse(Console.ReadLine());
      if (input == "bread")
      {
        Bread uOrder = new Bread(quantity);
        Console.WriteLine($"Your {uOrder.Order} Loaves of bread will cost ${uOrder.BreadOrder()}");
        Console.WriteLine("Would you like to add to your order? (y/n)");
        string x = Console.ReadLine();
        if (x == "y")
        {
          Main();
        }
        else if (x == "n")
        {
          Program.PrintOrder();
        }
        else 
        {
          Console.WriteLine("Not a valid selection");
        }
      }
      else if (input == "pastry")
      {
        Pastry uOrder = new Pastry(quantity);
        Console.WriteLine($"Your {uOrder.Order} Pastries will cost ${uOrder.PastryOrder()}");
        Console.WriteLine("Would you like to add to your order, y/n?");
        string x = Console.ReadLine();
        if (x == "y")
        {
          Main();
        }
        else if (x == "n")
        {
          Program.PrintOrder();
        }
        else 
        {
          Console.WriteLine("Not a valid selection");
        }
      }
    }
    public static void PrintOrder()
    {
      int finalBread = Bread.GetAll();
      int finalPastry = Pastry.GetAll();
      double cost = Bread.BreadOrder(finalBread) + Pastry.PastryOrder(finalPastry);
      Console.WriteLine($"You bought {finalBread} Loaves of bread and {finalPastry} pastries for ${cost}");
      Console.WriteLine("Bye!");
    }
  }
}