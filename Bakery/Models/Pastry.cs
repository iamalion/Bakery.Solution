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
    }
    public int PastryCost()
    {
        int costOfPastryOrder = 0;
        int numberOfMultiples = this.PastryUnits/4;
        int remainder = this.PastryUnits%4;
        costOfPastryOrder = (numberOfMultiples*6)+(remainder*2);
        return costOfPastryOrder;
    }
  }
}