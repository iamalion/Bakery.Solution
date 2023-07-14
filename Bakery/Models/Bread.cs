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
        CostOfLoaf = 5;
    }
    public int BreadCost()
    {
        int breadCost = Loaves * CostOfLoaf;
        return breadCost;
    }
  }
}