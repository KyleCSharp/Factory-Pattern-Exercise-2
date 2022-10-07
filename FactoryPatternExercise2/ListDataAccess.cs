using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess: IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name="xbox",Price=500},
            new Product(){Name="High end gaming pc -",Price=3000},
            new Product(){Name="Mid tier gaming pc -",Price=2000},
            new Product(){Name="Low end gaming pc -",Price=1000},
            new Product(){Name="Gaming laptop -",Price=1800},
            new Product(){Name="apple air pods -",Price=200},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from LIST database access");
            return Products;

        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a ListDataAccess database");
        }
    }
}
