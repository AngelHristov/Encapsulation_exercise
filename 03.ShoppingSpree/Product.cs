namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;

        public string Name
        {
            get => this.name;
            set
            {
                Validator.ValidateName(value); // checks if name is not null or empty string;

                name = value;
            }
        }

        public int Cost
        {
            get => this.cost;
            set
            {
                Validator.ValidateMoney(value); // checks if money < 0;

                cost = value;
            }
        }

        public Product(string name, int money)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
