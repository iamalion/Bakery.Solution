namespace Bakery.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    public int CostOfLoaf { get; set; }

    public Bread() { }
    public Bread(int numOfLoaves)
    {
        Loaves = numOfLoaves;
    }
    public int BreadCost()
    {
        int costOfBreadOrder = 0;
        int numberOfMultiples = this.Loaves/3;
        int remainder = this.Loaves%3;
        costOfBreadOrder = (numberOfMultiples*10)+(remainder*5);
        return costOfBreadOrder;
    }
  }
}