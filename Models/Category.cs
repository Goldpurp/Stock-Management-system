using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedTime = DateTime.Now;
        }
    }
}
