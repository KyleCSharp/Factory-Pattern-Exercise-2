using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ExtraErrorClass : IDataAccess
    {
        

        public static List<Product> Error1 = new List<Product>()
        {
            new Product(){Name="ERROR",Price=000},
            new Product(){Name="ERROR -",Price=0000},
            new Product(){Name="ERRORc -",Price=0000},
            new Product(){Name="ERROR -",Price=0000},
            new Product(){Name="ERROR -",Price=0000},
            new Product(){Name="ERROR -",Price=000},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"READING.........ERROR!");
            return Error1;

        }

        public void SaveData()
        {
            Console.WriteLine("saving data..............ERROR!");
        }
    }
}
