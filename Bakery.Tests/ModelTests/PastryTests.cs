using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
    [TestMethod]
    public void PastryCost_ReturnsCostOfOneUnit_PastryCost()
    {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(2, newPastry.PastryCost());
    }

    [TestMethod]
    public void PastryCost_ReturnsCostOfOTwoUnits_PastryCost()
    {
        Pastry newPastry = new Pastry(2);
        Assert.AreEqual(4, newPastry.PastryCost());
    }

    [TestMethod]

    public void PastryCost_ReturnsCostOfThreeUnits_PastryCost()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(6, newPastry.PastryCost());
    }

    public void PastryCost_ReturnsCostOfFourUnits_PastryCost()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(6, newPastry.PastryCost());
    }

    public void PastryCost_ReturnsCostOfFiveUnits_PastryCost()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(8, newPastry.PastryCost());
    }
    public void PastryCost_ReturnsCostOfGiantOrder_PastryCost()
    {
      Pastry newPastry = new Pastry(12345);
      Assert.AreEqual(18518, newPastry.PastryCost());
    }
  }
}