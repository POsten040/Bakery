using Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
      int input = 2;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void BreadOrder_CalculatesSalePriceOfBreadOrder_Int()
    {
      int input = 5;
      Bread uOrder = new Bread(input);
      int result = uOrder.BreadOrder();
      Assert.AreEqual(15, result);
    }
  }
}
      