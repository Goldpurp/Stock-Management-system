using System;
using System.Collections.Generic;
using StockManagementSystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    class CategoryRepository
    {
        List<Category> categoryList = new List<Category>(); //List Table
        public void CreateCategory()
             
        {
            Console.Write("Please enter Category of Stock:");
            string name = Console.ReadLine();

            Console.Write("Please enter id of the Category");
            int id = int.Parse (Console.ReadLine());

            Console.Write("Please enter Description of the Category");
            string description = Console.ReadLine();

            Category newCat = new Category(id, name, description); //Reg Constructor

            categoryList.Add(newCat); //Insert To


            
            Console.WriteLine("Category Successfully Created");
        }
        public void ListAllCat()
        {
            foreach (Category cat in categoryList)
            {
                Console.WriteLine($"{cat.Id},{cat.Description},{cat.Name}{cat.CreatedTime}");
            }
        }
            
        public void Find()   
        {
            Console.Write("Please enter Category Id you want to find:");
            int id = int.Parse(Console.ReadLine());

            Category cat = LocateCatId(id);
            if (cat != null)
            {
                Console.WriteLine($"{cat.Id},{cat.Description},{cat.Name}{cat.CreatedTime}");
            }
            else
            {
                Console.WriteLine("Sorry the category does not exist");
            }
        
        }
        public Category LocateCatId(int id)
        {
            foreach (Category ct in categoryList)
            {
                if (ct.Id == id)
                {
                    return ct;
                }
               
            }
            return null;
        }

        

            
    }
}
