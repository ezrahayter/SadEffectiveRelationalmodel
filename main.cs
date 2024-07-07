using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the estimated number of hours for the move: ");
    double hours = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the estimated number of miles for the move: ");
    double miles = Convert.ToDouble(Console.ReadLine());
    double totalFee = 200 + (150 * hours) + (2 * miles);

    Console.WriteLine("The total moving fee is: $" + totalFee);
  }
}