namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] lineOfPersons = LineSpliter();

            var people = new List<Person>();

            for (int i = 0; i < lineOfPersons.Length; i++)
            {
                string name;
                int money;
                ItemSpliter(lineOfPersons, i, out name, out money);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            string[] lineOfProducts = LineSpliter();

            var products = new List<Product>();

            for (int i = 0; i < lineOfProducts.Length; i++)
            {
                string name;
                int money;
                ItemSpliter(lineOfProducts, i, out name, out money);

                try
                {
                    Product product = new Product(name, money);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = tokens[0];
                string productName = tokens[1];

                var person = people.FirstOrDefault(x => x.Name == personName);
                var product = products.FirstOrDefault(x => x.Name == productName);

                if (person.AddProduct(product))
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }               
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.bag)}");
            }
        }


        private static void ItemSpliter(string[] lineOfPersons, int i, out string name, out int money)
        {
            string[] tokens = lineOfPersons[i].Split("=");

            name = tokens[0];
            money = int.Parse(tokens[1]);
        }

        private static string[] LineSpliter()
        {
            return Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
