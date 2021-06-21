using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Stock : BaseEntity
    {
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Variation { get; set; }
        public string SKU { get; set; }

        public Stock(int id, string name, double costPrice, double sellingPrice, int quantity, string category, string variation, string sku)
        {
            Id = id;
            Name = name;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            Category = category;
            Variation = variation;
            SKU = sku;
            CreatedTime = DateTime.Now;
        }

    }
}
