using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Item;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to bakery, Would you like Bread or Pastry?(bread/pastry)");
      string input = Console.ReadLine();
      try
        {
        Regex rg = new Regex("[0-9]");
        bool matches = rg.IsMatch(input);
        // Console.WriteLine(Regex.Matches(input, rg));
        if (matches == true)
        {
          Program.InputOrder(input);
          Console.WriteLine("Would you like to add to your order? (y/n)");
          string x = Console.ReadLine();
          Program.Menu(x);
        }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
          Main();
        }
      //   Console.WriteLine("Not a valid selection");
      //   Main();
      // }
      // else
      // {
    }
    public static void PrintOrder()
    {
      int finalBread = Bread.GetAll();
      int finalPastry = Pastry.GetAll();
      double cost = Bread.BreadOrder(finalBread) + Pastry.PastryOrder(finalPastry);
      Console.WriteLine($"You bought {finalBread} Loaves of bread and {finalPastry} pastries for ${cost}");
      Console.WriteLine("Bye!");
    }
    public static void Menu(string x)
    {
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
        Main();
      }
    }
    public static void InputOrder(string input)
    {
      Console.WriteLine($"How much {input} do you need?");
      int quantity = int.Parse(Console.ReadLine());
      if (input == "bread")
      {
        Bread uOrder = new Bread(quantity);
        Console.WriteLine($"Your {uOrder.Order} Loaves of bread will cost ${uOrder.BreadOrder()}");
      }
      else if (input == "pastry") 
      {
        Pastry uOrder = new Pastry(quantity);
        Console.WriteLine($"Your {uOrder.Order} Pastries will cost ${uOrder.PastryOrder()}");
      }
      else 
      {
        Console.WriteLine("not a valid selection");
        Main();
      }
    }
  }
}