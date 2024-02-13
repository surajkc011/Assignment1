using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How much did you receive money ($)?");
        int totalMoney = Convert.ToInt32(Console.ReadLine());

        // Calculate three quarters of the total money for books and supplies
        double booksAndSupplies = totalMoney * 0.75;

        // Calculate the remaining money for coffee, Flash Computer, and subway tickets
        double remainingMoney = totalMoney - booksAndSupplies;

        // Calculate the number of coffees, Flash Computer, and subway tickets that can be purchased
        int coffees = (int)(remainingMoney / 2);
        int flashComputer = (int)(remainingMoney / 4);
        int subwayTickets = (int)(remainingMoney / 3);

        // Calculate the remaining money for white roses
        double remainingMoneyForRoses = remainingMoney - (coffees * 2 + flashComputer * 4 + subwayTickets * 3);

        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputer} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {remainingMoneyForRoses} dollars for the white roses.");
    }
}
