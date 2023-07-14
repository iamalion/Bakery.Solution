namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryUnits { get; set; }
    public int CostOfUnit { get; set; }

    public Pastry() { }

    public Pastry(int numOfUnits)
    {
        PastryUnits = numOfUnits;
        CostOfUnit = 3;
    }
    public int PastryCost()
    {
        int pastryCost = PastryUnits * CostOfUnit;
        return pastryCost;
    }
  }
}