using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repositories;

namespace StockManagementSystem
{
    class Menu
    {
        StockRepository stockRepository         = new StockRepository();
        CategoryRepository categoryRepository   = new CategoryRepository();

        public void MainMenu()
        {
            bool running = true;

            do
            {
                ShowMenu();
                Console.Write("Enter your option: ");
                string option = Console.ReadLine().Trim();

                switch (option)
                {
                    case "0":
                        running = false;
                        break;

                    case "1":
                        ShowStockMenu();
                        break;

                    case "2":
                        ShowCategoryMenu();
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
            } while (running);

        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("0. Exit.");
            Console.WriteLine("1. Stock Menu.");
            Console.WriteLine("2. Category Menu.");
        }

        public void ShowStockMenu()
        {
            Console.Clear();
            Console.WriteLine("0. Go Back To Main Menu.");
            Console.WriteLine("1. Create Stock.");
            Console.WriteLine("2. List All Stock.");
            Console.WriteLine("3. Find Stock By Id.");
            Console.WriteLine("4. Update Stock.");
            Console.WriteLine("5. Delete Stock.");

            Console.Write("Enter your option: ");
            string option = Console.ReadLine().Trim();
            StockMenu(option);
        }

        public void StockMenu(string option)
        {
            switch (option)
            {
                case "0":
                    
                    break;

                case "1":
                    stockRepository.CreateStock();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "2":
                    stockRepository.ListStock();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "3":
                    stockRepository.FindStock();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "4":
                    stockRepository.UpdateStock();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "5":
                    stockRepository.DeleteStock();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                default:
                    Console.Write("Invalid option.");
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;
            }
            if( !option.Equals("0") )
            {
                ShowStockMenu();
            }  
        }

        public void ShowCategoryMenu()
        {
            Console.Clear();
            Console.WriteLine("0. Go Back To Main Menu.");
            Console.WriteLine("1. Create Category.");
            Console.WriteLine("2. List All Category.");
            Console.WriteLine("3. Find Category By Id.");
            Console.WriteLine("4. Update Category.");
            Console.WriteLine("5. Delete Category.");

            Console.Write("Enter your option: ");
            string option = Console.ReadLine().Trim();
            CategoryMenu(option);
        }

        public void CategoryMenu(string option)
        {
            switch (option)
            {
                case "0":

                    break;

                case "1":
                    categoryRepository.CreateCategory();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "2":
                    categoryRepository.ListAllCat();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "3":
                    categoryRepository.Find();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "4":
             //       categoryRepository.UpdateCategory();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                case "5":
             //       categoryRepository.DeleteCategory();
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;

                default:
                    Console.Write("Invalid option.");
                    Console.Write("Press any key to continue: ");
                    Console.ReadKey();
                    break;
            }
            if (!option.Equals("0"))
            {
                ShowCategoryMenu();
            }
        }
    }
}
