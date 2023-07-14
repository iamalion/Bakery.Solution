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
        Assert.AreEqual(3, newPastry.PastryCost());
    }
  }
}