using Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Items.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void MakeBread_CreatesBreadObject_True()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      Assert.AreEqual(typeof(Bread), uOrder.GetType());
    }
    [TestMethod]
    public void MakePastry_CreatesPastryObject_True()
    {
      int input = 5;
      Pastry uOrder = new Pastry(input);
      Assert.AreEqual(typeof(Pastry), uOrder.GetType());
    }
    [TestMethod]
    public void BreadOrder_CalculatesPriceOfBreadOrder_Int()
    {
      int input = 1;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadOrder_CalculatesSalePriceOfBreadOrder_Int()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(15, result);
    }
    [TestMethod]
    public void PastryOrder_CalculatePriceOfPastry_Int()
    {
      int input = 1;
      Pastry uOrder = new Pastry(input);
      int result = uOrder.PastryOrder();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void PastryOrder_CalculateSalePriceOfPastry_Int()
    {
      int input = 4;
      Pastry uOrder = new Pastry(input);
      int result = uOrder.PastryOrder();
      Assert.AreEqual(7, result);
    }
    [TestMethod]
    private List<Bread> GetAll_ReturnsAllListItems_True()
    {
      Bread uOrder = new Bread(1);
      List<Bread> u = Bread.GetAll();
      Assert.AreEqual(typeof(List<Bread>), u.GetType());
    }
  }
}
      