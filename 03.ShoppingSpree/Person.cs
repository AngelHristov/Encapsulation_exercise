namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private int money;
        public List<Product> bag;

        public string Name
        {
            get => this.name;
            set
            {
                Validator.ValidateName(value); // checks if name is not null or empty string;

                name = value;
            }
        }
        public int Money
        {
            get => this.money;
            set
            {
                Validator.ValidateMoney(value); // checks if money < 0;

                money = value;
            }
        }

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;

            bag = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                bag.Add(product);
                money -= product.Cost;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
