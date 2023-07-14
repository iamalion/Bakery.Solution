using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread loaves cost $5 each");
      Console.WriteLine("Pastries are $2 a piece");
      Console.WriteLine("Today's Special: Buy 2 loaves get 1 free & Buy 3 pastries get 1 free");

      try 
      {
        Console.WriteLine("How many bread loaves would you like to order?");
        int breadOrder = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like to order?");
        int pastryOrder = int.Parse(Console.ReadLine());

        Bread newBread = new Bread(breadOrder);
        Pastry newPastry = new Pastry(pastryOrder);

        int breadCost = newBread.BreadCost();
        int pastryCost = newPastry.PastryCost();
        int finalTotal = breadCost + pastryCost;

        Console.WriteLine("Your order:");
        Console.WriteLine($"Bread loaves: {breadOrder}");
        Console.WriteLine($"Pastries: {pastryOrder}");

        Console.WriteLine($"Final total: ${finalTotal}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Oops! There was an error. {e.Message}");
        Console.WriteLine("Please enter a postive whole number for your order.");
      }

      Console.WriteLine("Would you like to make another order? Please type 'yes' or 'no'.");
      string response = Console.ReadLine().ToLower();
      if (response == "y" || response == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thanks for your order! Come again soon!");
        Console.WriteLine("~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
      }
    }
  }
}