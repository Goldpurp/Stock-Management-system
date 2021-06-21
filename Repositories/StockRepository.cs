using System;
using System.Collections.Generic;
using StockManagementSystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class StockRepository
    {
        List<Stock> stocks = new List<Stock>();

        public void CreateStock()
        {
            Console.Write("Please enter stock Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Please enter stock name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter stock cost price: ");
            double costPrice = double.Parse(Console.ReadLine());

            Console.Write("Please enter stock selling price: ");
            double sellingPrice = double.Parse(Console.ReadLine());

            Console.Write("Please enter stock quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Please enter stock category: ");
            string category = Console.ReadLine();

            Console.Write("Please enter stock variation: ");
            string variation = Console.ReadLine();

            Console.Write("Please enter stock sku: ");
            string sku = Console.ReadLine();

            Stock newStock = new Stock(id, name, costPrice, sellingPrice, quantity, category, variation, sku);

            stocks.Add(newStock);
            Console.WriteLine("Stock created successfully.");
        }

        public void ListStock()
        {
            foreach(Stock s in stocks)
            {
                Console.WriteLine($"Id: {s.Id} Name: {s.Name} Cost Price: {s.CostPrice} Selling Price: {s.SellingPrice} Quantity: {s.Quantity} Category: {s.Category} Variation: {s.Variation} SKU: {s.SKU} Date Created: {s.CreatedTime}");
            }
        }

        public void FindStock()
        {
            Console.Write("Please enter stock Id you want to find: ");
            int id = int.Parse(Console.ReadLine());
            Stock stock = GetStock(id);

            if(stock != null)
            {
                Console.WriteLine($"Id: {stock.Id} Name: {stock.Name} Cost Price: {stock.CostPrice} Selling Price: {stock.SellingPrice} Quantity: {stock.Quantity} Category: {stock.Category} Variation: {stock.Variation} SKU: {stock.SKU} Date Created: {stock.CreatedTime}");
            }
            else
            {
                Console.WriteLine($"Stock with id {id} does not exist.");
            }
        }

        public void UpdateStock()
        {
            Console.Write("Please enter stock Id you want to edit: ");
            int id = int.Parse(Console.ReadLine());
            Stock stock = GetStock(id);
            if(stock != null)
            {
                Console.Write("Please enter new stock name: ");
                string name = Console.ReadLine();
                stock.Name = name;

                Console.Write("Please enter stock cost price: ");
                double costPrice = double.Parse(Console.ReadLine());
                stock.CostPrice = costPrice;

                Console.Write("Please enter stock selling price: ");
                double sellingPrice = double.Parse(Console.ReadLine());
                stock.SellingPrice = sellingPrice;

                Console.Write("Please enter stock quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                stock.Quantity = quantity;

                Console.Write("Please enter stock category: ");
                string category = Console.ReadLine();
                stock.Category = category;

                Console.Write("Please enter stock variation: ");
                string variation = Console.ReadLine();
                stock.Variation = variation;

                Console.Write("Please enter stock sku: ");
                string sku = Console.ReadLine();
                stock.SKU = sku;

                Console.WriteLine("Stock updated successfully.");

            } else
            {
                Console.WriteLine($"Stock with id {id} does not exist.");
            }
        }

        public void DeleteStock()
        {
            Console.Write("Please enter id of the stock you want to delete: ");
            int id = int.Parse(Console.ReadLine());
            Stock stock = GetStock(id);
            if (stock != null)
            {
                stocks.Remove(stock);
                Console.WriteLine("Stock deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Sorry, there is no stock with the id {id}.");
            }
        }

        public Stock GetStock(int id)
        {
            foreach(Stock st in stocks)
            {
                if (st.Id == id)
                {
                    return st;
                }
            }
            return null;
        }
    }
}
