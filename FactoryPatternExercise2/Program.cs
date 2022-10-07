namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string UserInput;
            bool CorrectInput;
            do
            {
                CorrectInput = true;
                Console.WriteLine(" what database do you want to use: a List, SQL, or Mongo");

                UserInput = Console.ReadLine().ToLower();


                if (UserInput != "sql"&& UserInput!= "mongo" && UserInput!= "list")
                {
                    CorrectInput=false;
                }
            } while (CorrectInput== false);
              
            
            
                IDataAccess db = DataAccessFactory.GetDataAccessType(UserInput);
                var products = db.LoadData();
                db.SaveData();


                foreach (var product in products)
                {
                Console.WriteLine($"{product.Name}");
                Console.WriteLine($"{product.Price}");
                }
            
        }
    }
}