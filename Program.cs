using System;

namespace StockManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("==== STOCK MANAGEMENT SYSTEM ====");
            Console.WriteLine("=================================");

            Menu newMenu = new Menu();
            newMenu.MainMenu();
        }
    }
}
