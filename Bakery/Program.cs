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
      Console.WriteLine("How many bread loaves would you like to order?");
      string breadOrder = Console.ReadLine();
      Console.WriteLine("How many pastries would you like to order?");
      string pastryOrder = Console.ReadLine();

    
    }
  }
}