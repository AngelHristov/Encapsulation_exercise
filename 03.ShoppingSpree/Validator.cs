namespace _03.ShoppingSpree
{
    using System;

    public static class Validator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        public static void ValidateMoney(int money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
